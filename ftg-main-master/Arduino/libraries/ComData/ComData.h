/*Library written by Marco Schriek*/
#ifndef ComData_H
#define ComData_H

#include <Arduino.h>

#define NUMBER_BUFFER 15

//typedef enum vartypes { _String, _Int, _Uint, _Double, _Bool, _Char, _ComData, _Undefined };


#define MAX_PARAMS_COMDATA 7

#define INVALID_TYPE_COMDATA 0

class ComData {
public:

	ComData(void);
	~ComData(void);

	int sender;
	int PacketID;
	String params[MAX_PARAMS_COMDATA];
	int paramTypes[MAX_PARAMS_COMDATA];

	void CopyTo(ComData &comdataObject);

	bool Set(const unsigned int index, String value);
	bool Set(const unsigned int index, int value);
	bool Set(const unsigned int index, unsigned int value);
	bool Set(const unsigned int index, float value);
	bool Set(const unsigned int index, long value);
	bool Set(const unsigned int index, unsigned long value);
	bool Set(const unsigned int index, double value);
	bool Set(const unsigned int index, long double value);
	bool Set(const unsigned int index, char value);
	bool Set(const unsigned int index, unsigned char value);
	bool Set(const unsigned int index, bool value);
	bool Set(const unsigned int index, ComData value);

	bool Get(const unsigned int index, String &value);
	bool Get(const unsigned int index, int &value);
	bool Get(const unsigned int index, unsigned int &value);
	bool Get(const unsigned int index, float &value);
	bool Get(const unsigned int index, long &value);
	bool Get(const unsigned int index, unsigned long &value);
	bool Get(const unsigned int index, double &value);
	bool Get(const unsigned int index, long double &value);
	bool Get(const unsigned int index, char &value);
	bool Get(const unsigned int index, unsigned char &value);
	bool Get(const unsigned int index, bool &value);
	bool Get(const unsigned int index, ComData &value);
	int GetType(int index);

	void Reset(void);
	String ToString(void);
};

#endif