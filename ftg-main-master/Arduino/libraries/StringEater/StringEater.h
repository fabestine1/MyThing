/*Library written by Marco Schriek*/
#ifndef StringEater_H
#define StringEater_H

#include "Arduino.h"

class StringEater {
public:
	StringEater();
	~StringEater();

		void eat(const unsigned int endindex);
		void eat(const unsigned int startindex, const unsigned int endindex);
		void eat(const unsigned int startindex, const unsigned int endindex, const int skip);
	
		void string(String eatable_string);
		String string();

		bool finished();
		unsigned int endindex();

		void eatUntil(int(*condition_func)(unsigned int currentindex, const char character, String *buffer));

		void reset(const unsigned int index);
		void reset();

		String EatenText;
		String Buffer;

	private:
		int				isEating;//converted int, larger than 0 is true
		unsigned int	startIndex;
		unsigned int	endIndex;
		unsigned int	length;
		String			CompleteText;

};

#endif