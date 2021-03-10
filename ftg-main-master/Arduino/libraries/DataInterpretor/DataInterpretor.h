/*Library written by Marco Schriek*/
#ifndef SerialDataInterpretor_H
#define SerialDataInterpretor_H

#include "Arduino.h"

#include "..\ComData\ComData.h"//include dependencies
#include "..\StringEater\StringEater.h"//include dependencies

#define COMMAND_SEPARATOR ','	//NOTE, cannot use symbol escape '\' or '"'

class DataInterpretor {
public:

	void addChar(char chr);
	void addString(String str);
	void DealWithChr(char chr);

	void dealWithInput(String str);
	
	ComData getComData();
	bool usableInput;

private:
	int data_open;
	String priv_buffer;
	ComData comdata;
};

//very ugly and only fix to arduino compilation.

#endif