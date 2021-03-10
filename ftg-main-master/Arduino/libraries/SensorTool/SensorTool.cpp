#include "SensorTool.h"

Sensor::Sensor(int _SensorPin, Type _type)
{
	SensorPin = _SensorPin;
	SensorType = _type;
	PreviousValue = 0;
}

int Sensor::Read()
{
	switch (SensorType)
	{
		case Analog:
		{
			int Value = analogRead(SensorPin);
			return Value;
		}

		case Digital:
		{
			pinMode(SensorPin, INPUT);
			int Value = digitalRead(SensorPin);
			return Value;
		}
	}
}

int Sensor::DetectChange()
{
	int Value = Read();
	if (PreviousValue != Value)
	{
		PreviousValue = Value;
		return PreviousValue;
	}
	return 0;
}

String Sensor::toString() //FOR DEBUG USE ONLY! PRINTS TO SERIAL MONITOR
{
	String _type;
	Serial.print("Sensor Pin: ");
	Serial.println(SensorPin);
	if (SensorType == Analog) _type = "Analog";
	else _type = "Digital";
	Serial.print("Sensor Type: ");
	Serial.println(_type);
}