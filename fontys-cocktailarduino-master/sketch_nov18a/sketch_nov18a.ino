#include "main.h"

void setup()
{
	//Serieele communicatie klaarzetten voor de computer
	Serial.begin(9600);
	
	// Wachten tot serieel verbonden is
	while(!Serial)
	{
		continue;
	}
}

void loop()
{
	Serial.println("Initializing");
	//Initializeren van de instellingen voor het gebruik
	Settings *settings = (Settings*)malloc(sizeof(Settings));
	settings->boozeTime = 10;
	
	Serial.println("Starting loop");
	
	//Superloop
	while(true)
	{
		// Check voor seriele input
		ReadSerial(settings);
	}
	Serial.println(millis());
	// Als het debugtijd is, wachten wij 10s
	if(DEBUG)
	{
		delay(10);
		
	}
}

// Read serial data
// 0 byte indicates mode
// 1 byte indicates destination
// 2 - 6 indicates value
void ReadSerial(Settings *settings)
{
	// Read Serial
	char serialReceived[3+CHARSFORINT] = "";
	
	// Check if there's data in the input buffer
	if(Serial.peek() != -1)
	{
		Serial.readBytes(&serialReceived[0], 19);
		
		// Read
		if(serialReceived[0] == 'r')
		{
			switch(serialReceived[1])
			{
				case '1':
					Serial.println(settings->boozeTime);
					break;
				default:
					Serial.println("Bad Input");
					break;
			}
		}
		// Write
		else if (serialReceived[0] == 'w')
		{
			switch(serialReceived[1])
			{
				case '1':
					settings->boozeTime = SerialGetValue(serialReceived, 2);
					break;
				default:
					Serial.println("Bad Input");
					break;
			}
		}
		// Execute
		else if (serialReceived[0] == 'e')
		{
			switch(serialReceived[1])
			{
				default:
					Serial.println("Bad Input");
					break;
			}
		}
	}
}

// Returns the integer representation of a sequence of characters
int SerialGetValue(char* inputArray, short offset)
{
	// Create an entry buffer
	char nummerBuffer[4] = {0};
	
	// Add the character values to a sequential array so it can be converted
	for(short i = 0; i != CHARSFORINT; i++)
	{
		nummerBuffer[i] = inputArray[i+offset];
	}	
	
	if(DEBUG)
	{
		Serial.println("Received the following input number");
		Serial.println(nummerBuffer);
	}
		
	// Return the integer value of the numberBuffer
	return atoi(nummerBuffer);
}