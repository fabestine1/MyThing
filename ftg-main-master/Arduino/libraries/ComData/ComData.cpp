/*Library written by Marco Schriek*/
#ifndef ComData_C
#define ComData_C

#include "ComData.h"

String stof(long double d)
{
	String result_str;
	char Result[10]; // string which will contain the number

	long int rounded = (long int)floor(d);
	sprintf(Result, "%d", rounded); // %d makes the result be a decimal integer

	result_str = Result;
	result_str += ".";

	d -= rounded;

	rounded = -1;

	for (unsigned int zero_count = 0; zero_count < NUMBER_BUFFER; zero_count++)
	{
		d *= 10;
		rounded = (long int)floor(d);
		sprintf(Result, "%d", rounded); // %d makes the result be a decimal integer

		result_str += Result;

		d -= rounded;
	}

	return result_str;
}
//<<constructor>>
ComData::ComData(void){

	Reset();
}

void ComData::Reset(void)
{
	for (unsigned int i = 0; i < MAX_PARAMS_COMDATA; i++)
	{
		params[i] = "";//initialise as string
		paramTypes[i] = INVALID_TYPE_COMDATA;
	}
}

void ComData::CopyTo(ComData &comdataObject)
{
	for (int i = 0; i < MAX_PARAMS_COMDATA; i++)
	{
		if (paramTypes[i] == INVALID_TYPE_COMDATA || paramTypes[i]>12)
		{
			break;
		}
		else
		{
			comdataObject.params[i] = params[i];
			comdataObject.paramTypes[i] = paramTypes[i];
		}
	}

}

ComData::~ComData(void){
	//nothing to destruct
}

bool ComData::Set(const unsigned int index, String value)
{
	if (index >= MAX_PARAMS_COMDATA)
		return false;

	params[index] = value;
	paramTypes[index] = 1;//1

	return true;
}
bool ComData::Set(const unsigned int index, int value)
{
	if (index >= MAX_PARAMS_COMDATA)
		return false;

	char Result[5]; // string which will contain the number
	sprintf(Result, "%d", value); // %d makes the result be a decimal integer

	params[index] = Result;
	paramTypes[index] = 2;//2

	return true;
}
bool ComData::Set(const unsigned int index, unsigned int value)
{
	if (index >= MAX_PARAMS_COMDATA)
		return false;

	char Result[4]; // string which will contain the number
	sprintf(Result, "%d", value); // %d makes the result be a decimal integer

	params[index] = Result;
	paramTypes[index] = 3;//3

	return true;
}
bool ComData::Set(const unsigned int index, float value)
{
	if (index >= MAX_PARAMS_COMDATA || index<0)
		return false;

	char Result[32]; // string which will contain the number
	sprintf(Result, "%f", value); // %d makes the result be a decimal integer

	params[index] = Result;
	paramTypes[index] = 4;

	return true;
}
bool ComData::Set(const unsigned int index, long value)
{
	if (index >= MAX_PARAMS_COMDATA || index<0)
		return false;

	char Result[32]; // string which will contain the number
	sprintf(Result, "%ld", value); // %d makes the result be a decimal integer

	params[index] = Result;
	paramTypes[index] = 5;

	return true;
}
bool ComData::Set(const unsigned int index, unsigned long value)
{
	if (index >= MAX_PARAMS_COMDATA || index<0)
		return false;

	char Result[32]; // string which will contain the number
	sprintf(Result, "%lu", value); // %d makes the result be a decimal integer

	params[index] = Result;
	paramTypes[index] = 6;

	return true;
}
bool ComData::Set(const unsigned int index, double value)
{
	if (index >= MAX_PARAMS_COMDATA || index<0)
		return false;

	String result; // string which will contain the number

	result = stof(value);

	params[index] = result;
	paramTypes[index] = 7;

	return true;
}
bool ComData::Set(const unsigned int index, long double value)
{
	if (index >= MAX_PARAMS_COMDATA || index<0)
		return false;

	char Result[64]; // string which will contain the number
	sprintf(Result, "%Lf", value); // %d makes the result be a decimal integer

	params[index] = Result;
	paramTypes[index] = 8;

	return true;
}
bool ComData::Set(const unsigned int index, char value)
{
	if (index >= MAX_PARAMS_COMDATA)
		return false;

	params[index] = String(value);
	paramTypes[index] = 9;

	return true;
}
bool ComData::Set(const unsigned int index, unsigned char value)
{
	if (index >= MAX_PARAMS_COMDATA)
		return false;

	params[index] = String(value);
	paramTypes[index] = 10;

	return true;
}

bool ComData::Set(const unsigned int index, bool value)
{
	if (index >= MAX_PARAMS_COMDATA)
		return false;

	if (value)
	{
		params[index] = "1";
	}
	else
	{
		params[index] = "0";
	}
		
	paramTypes[index] = 11;

	return true;
}
bool ComData::Set(const unsigned int index, ComData value)
{
	if (index >= MAX_PARAMS_COMDATA)
		return false;

	//TODO make a converter for COMDATA
	params[index] = value.ToString();

	paramTypes[index] = 12;

	return true;
}

bool ComData::Get(const unsigned int index, String &value)
{
	if (index >= MAX_PARAMS_COMDATA)
		return false;

	value = params[index];

	return true;
}
bool ComData::Get(const unsigned int index, int &value)
{
	if (index >= MAX_PARAMS_COMDATA)
		return false;

	value = params[index].toInt();

	return true;
}
bool ComData::Get(const unsigned int index, unsigned int &value)
{
	if (index >= MAX_PARAMS_COMDATA)
		return false;

	value = params[index].toInt();

	return true;
}
bool ComData::Get(const unsigned int index, float &value)
{
	if (index >= MAX_PARAMS_COMDATA)
		return false;

	char stringer[17];
	params[index].toCharArray(stringer, 17);

	value = atof(stringer);

	return true;
}
bool ComData::Get(const unsigned int index, long &value)
{
	if (index >= MAX_PARAMS_COMDATA)
		return false;

	char stringer[17];
	params[index].toCharArray(stringer, 17);

	value = atol(stringer);

	return true;
}
bool ComData::Get(const unsigned int index, unsigned long &value)
{
	if (index >= MAX_PARAMS_COMDATA)
		return false;

	char stringer[16];
	params[index].toCharArray(stringer, 16);

	value = atol(stringer);

	return true;
}
bool ComData::Get(const unsigned int index, double &value)
{
	if (index >= MAX_PARAMS_COMDATA)
		return false;

	char stringer[33];
	params[index].toCharArray(stringer, 33);

	value = atof(stringer);

	return true;
}
bool ComData::Get(const unsigned int index, long double &value)
{
	if (index >= MAX_PARAMS_COMDATA)
		return false;

	char stringer[65];
	params[index].toCharArray(stringer, 65);

	value = atof(stringer);

	return true;
}
bool ComData::Get(const unsigned int index, char &value)
{
	if (index >= MAX_PARAMS_COMDATA)
		return false;

	value = params[index][0];

	return true;
}
bool ComData::Get(const unsigned int index, unsigned char &value)
{
	if (index >= MAX_PARAMS_COMDATA)
		return false;

	value = params[index][0];

	return true;
}

bool ComData::Get(const unsigned int index, bool &value)
{
	if (index >= MAX_PARAMS_COMDATA)
		return false;

	value = (params[index] != "0");

	return true;
}

bool ComData::Get(const unsigned int index, ComData &value)
{
	if (index >= MAX_PARAMS_COMDATA)
		return false;

	//TODO make an unserialiser for index params[index][0]
	//value = params[index][0];

	return true;
}

int ComData::GetType(int index)
{
	if (index >= MAX_PARAMS_COMDATA)
		return -1;

	//TODO make an unserialiser for index params[index][0]
	//value = params[index][0];

	return paramTypes[index];
}

String ComData::ToString(void)
{
	//TODO make a serialiser for the ComData Object
	//KEEP IN MIND that comdata supports more comdata objects
	return "";
}
#endif