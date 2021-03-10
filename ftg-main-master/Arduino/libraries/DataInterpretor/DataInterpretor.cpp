/*Library written by Marco Schriek*/
#ifndef DataInterpretor_C
#define DataInterpretor_C

#include "DataInterpretor.h"

bool escaped;
bool escaped_quote;
bool in_string;

int BracketEater_conditions(unsigned int currentindex, const char character, String *buffer)
{
	switch (character)
	{
		case COMMAND_SEPARATOR:
		{
								  if (!in_string)
								  {
									  escaped = false;
									  return -199;
								  }
								  break;
		}
		case '\\':
		{
					 if (in_string)
					 {
						 escaped_quote = !escaped_quote;
					 }
					 else
					 {
						 escaped = !escaped;
					 }
					 break;
		}
		case '"':
		{
					if (in_string)
					{
						if (!escaped_quote)
						{
							in_string = false;
							escaped_quote = false;
						}
					}
					else
					{
						if (!escaped)
						{
							in_string = true;
						}
					}
					break;
		}
		default:
		{
				   escaped = false;
		}
	}
	return 1;//next character
}
/// <summary>
/// Serves as a method to all DealWithChar
/// </summary>
void DataInterpretor::addChar(char chr)
{
	DealWithChr(chr);
}
///<summary>
//	does the same as AddChar but for all characters that have been given
///</summary>
void DataInterpretor::addString(String str)
{
	unsigned int length = str.length();

	for (unsigned int i = 0; i < length; i++)
	{
		DealWithChr(str[i]);
	}
}
///<summary>
//	Returns the parameter list object comdata and resets the remembered parameters for next call.
//	NOTE: returns parameter object and then cleans up for next command

//<return>
//	returns the comdata object filled with data (when UsableInput is set)
//</return>
///</summary>
ComData DataInterpretor::getComData()
{
	usableInput = false;
	//instantiate new comdata object and refer to that new object

	ComData data;

	comdata.CopyTo(data);
	
	comdata.Reset();
	//end old object
	return data;
}
///<summary>
// DealWithChar checks what character has been received.
// DealWithChar buffers input starting with opening bracket until closing bracket has been detected
///</summary>
void DataInterpretor::DealWithChr(char chr)
{
	switch (chr)
	{
		case '{'://opening bracket
		{
					data_open++;
					break;
		}
		case '}'://closing bracket
		{
					data_open--;
					if (data_open == 0)
					{
						dealWithInput(priv_buffer);
						priv_buffer = "";
					}
					else if (data_open < 0)
					{
						exit(1);//error!
						//return;
					}
					break;
		}
		default:
		{//buffer...
			if (data_open != 0)
			{
				priv_buffer += chr;
			}
		}
	}
}
///<summary>
//	dealWithInput interprets the buffered string as data parameters [numbers, strings, parameters].
// All interpreted data is placed in ComData Object
// Each parameter can be addressed by its own index
// I.E.
	//{0, "parameter 2", "parameter 3", "parameter 4"}
	//returns comdata object:
/*
	comdata = {
		index 0:   5 (int)
		index 1:	"parameter 2" (string)
		index 2:	"parameter 3" (string)
		index 3:	"parameter 4" (string)
	}

	comdata parameters can be addressed by supplying a variable as reference for type and index number

	string parameter_2 = "";

	comdata.Get(1, parameter_2);

	//parameter_2 = "parameter 2";


	string parameter_1 = "";
	comdata.Get(1, parameter_1);
	//parameter_1 = "5";

	int parameter_1 = 0;
	comdata.Get(1, parameter_1);
	//parameter_1 = 5;

	*/
///</summary>
void DataInterpretor::dealWithInput(String str)
{
	//Data between main brackets have been entered "{<buffer>}"

	StringEater eater;//initialise string eater object



	//set string to string eater
	eater.string(str);

	unsigned int overload_protection = 0;
	unsigned int index = 0;

	//iterate only till all parameter indexes have been filled
	while ((index<MAX_PARAMS_COMDATA && eater.string().length() != 0))//conditions: index < MAX_PARAM or 
	{
		eater.eatUntil(BracketEater_conditions);

		//when there is content in the buffer
		eater.Buffer.trim();
		if (eater.Buffer.length()>0)
		{
			//cleanup trailing and leading whitespaces

			//if parameter was a string, then remove quotes
			if (eater.Buffer[0] == '"' && eater.Buffer[eater.Buffer.length() - 1] == '"')
			{
				eater.Buffer = eater.Buffer.substring(1, eater.Buffer.length() - 1);

				comdata.Set(index, eater.Buffer);
			}
			else
			{
				switch (eater.Buffer[0])
				{
					case 'i':
					case 'd':
					{
								char buffer[NUMBER_BUFFER];
								eater.Buffer.substring(1).toCharArray(buffer, NUMBER_BUFFER);
								int number = atoi(buffer);

								comdata.Set(index, number);
								break;
					}
					case 'f':
					{
								char buffer[NUMBER_BUFFER * 2];
								eater.Buffer.substring(1).toCharArray(buffer, NUMBER_BUFFER);
								double number = atof(buffer);

								
								comdata.Set(index, number);

								comdata.Get(index, number);
								break;
					}
					case 'c':
					{
						if (eater.Buffer.length() > 1)
						{
							comdata.Set(index, eater.Buffer[1]);
						}
								break;
					}
					default://automatic
					{
								char buffer[NUMBER_BUFFER * 2];
								eater.Buffer.toCharArray(buffer, NUMBER_BUFFER);
								double number = atof(buffer);

								//is a rounded number?
								if (number != 0 || eater.Buffer == "0")
								{
									if (round(number) == number)
									{//int
										if (number > 4294967295)
										{
											comdata.Set(index, number);//array fits only in double
										}
										else
										if (number > 2147483647)
										{

											comdata.Set(index, (unsigned long)number);
										}
										else
										if (number > 65535)
										{
											comdata.Set(index, (long)number);
										}
										else
										if (number > 32767)
										{
											comdata.Set(index, (unsigned int)number);
										}
										else
										/*if (number < -4294967294)
										{
											comdata.Set(index, number);//array fits only in double
										}
										else*/
										if (number < -32767)
										{
											comdata.Set(index, (long)number);
										}
										else
										{
											comdata.Set(index, (int)number);
										}
									}
									else
									{//just a double
										comdata.Set(index, number);
									}
								}
								else
								comdata.Set(index, eater.Buffer);
					}
				}
			}

			//and count up parameter index
			index++;
		}
		//ELSE the buffer is empty, meaning no content between separator, like ',,,' (3x nothing)
		//do nothing

	}
	usableInput = true;
}
#endif