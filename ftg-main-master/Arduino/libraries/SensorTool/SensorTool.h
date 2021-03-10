#ifndef SENSORTOOL_H
#define SENSORTOOL_H

#include <Arduino.h>

enum Type
{
	Analog, Digital
};

class Sensor
{
public:
	Sensor(int _SensorPin, Type _type);
	int Read();
	int DetectChange();
	String toString();

	int SensorPin;
	Type SensorType;
	int PreviousValue;
	
};






#endif SENSORTOOL_H