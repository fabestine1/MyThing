/*Library written by Marco Schriek*/
#ifndef StringEater_C
#define StringEater_C

#include "StringEater.h" //include the declaration for this class

//<<constructor>>
StringEater::StringEater(){
	CompleteText = "";
}

//<<destructor>>
StringEater::~StringEater(){/*nothing to destruct*/ }

void StringEater::string(String eatable_string)
{
	CompleteText = eatable_string;
	reset();
}

String StringEater::string()
{
	return CompleteText;
}

bool StringEater::finished()
{
	return endIndex == length;
}

unsigned int StringEater::endindex()
{
	return endIndex;
}

void StringEater::eat(const unsigned int endindex)
{
	eat(startIndex, endindex);
}
void StringEater::eat(const unsigned int startindex, const unsigned int endindex)
{
	if (startindex < 0)return;

	Buffer = CompleteText.substring(startindex, endindex + 1);
	string(CompleteText.substring(endindex + 1));
}
void StringEater::eat(const unsigned int startindex, const unsigned int endindex, const int skip)
{
	if (startindex < 0)return;

	Buffer = CompleteText.substring(startindex, endindex + 1);
	string(CompleteText.substring(endindex + 1 - skip));
}

void StringEater::eatUntil(int(*condition_func)(unsigned int currentindex, const char character, String *buffer))
{
		if (!isEating)
		{
			isEating = 1;
			endIndex = startIndex;
			Buffer = "";
			while (isEating!=0 && endIndex<=length)
			{
				isEating = condition_func(endIndex, CompleteText.charAt(endIndex), &Buffer);
				
				if (isEating < -198)
				{
					int skip = (isEating + 198);
					endIndex += skip;
					isEating = 0;

					eat(startIndex, endIndex, skip);
					return;
				}
				else if (isEating < -98)
				{
					endIndex += (isEating + 98);
					isEating = 0;

					eat(endIndex);
					return;
				}
				else if (isEating == 0)
				{
					eat(endIndex);
					return;
				}
				else if (isEating > 98)
				{
					endIndex += (isEating - 98);
					isEating = 0;

					eat(endIndex);
					return;
				}
				else
				{
					endIndex += isEating;
				}
			}
			eat(endIndex);
		}
}

void StringEater::reset(const unsigned int index)
{
	startIndex = index;
	length = (CompleteText.length());
	isEating = false;
}
void StringEater::reset()
{
	startIndex = 0;
	length = (CompleteText.length());
	isEating = false;
}
#endif