/* 
 * ****************************************************************************
 * RP6 ROBOT SYSTEM - ROBOT CONTROL EXAMPLE
 * ****************************************************************************
 * Example: Serial Interface Example - reading and writing numbers and strings
 * ****************************************************************************
 *
 * Description:
 * This sample program shows how to send and receive data over the serial port (UART).
 * It uses some of the interface functions of the RP6Library (see also "RP6uart.c"). 
 * The writeInteger function is very important because you can
 * output sensor values over the serial interface with it.
 * This is very useful to solve problems in your programs or optimize some
 * parameters.
 *
 */

/*****************************************************************************/
// Includes:
#include "stdbool.h"
#include "request_parser.h"
#include "test_requestparser.h"

#include "RP6Control_I2CMasterLib.h"

/*****************************************************************************/

#define I2C_RP6_BASE_ADR 10		// The default address of the Slave Controller 
								// on the RP6 Mainboard

#define RECEIVE_BUFFER_SIZE 101

#define CMD_MOVE_FORWARD	0x1
#define CMD_MOVE_BACKWARD	0x2
#define CMD_MOVE_LEFT		0x3
#define CMD_MOVE_RIGHT		0x4
#define CMD_GET_SPEED		0x5
#define CMD_GET_FUELLVL		0x6
#define CMD_STOP_MOVING		0xFF
#define CMD_LIFETIME		0xEF

#define RP6_MaxBatInmV		900

#define LIFETIME_tIMEOUT	1500

int move_horizontal = 0;
int move_turning = 0;
int topSpeed = 0;

uint8_t transmit_buffer[10]; // temporary transmit buffer
							 // A global variable saves space on the heap... 
							 

 /**
 * This function gets called automatically if there was an I2C Error like
 * the slave sent a "not acknowledge" (NACK, error codes e.g. 0x20 or 0x30).
 * The most common mistakes are: 
 *   - using the wrong address for the slave
 *   - slave not active or not connected to the I2C-Bus
 *   - too fast requests for a slower slave
 * Be sure to check this if you get I2C errors!
 */
void I2C_transmissionError(uint8_t errorState)
{
	writeString_P("\nI2C ERROR - TWI STATE: 0x");
	writeInteger(errorState, HEX);
	writeChar('\n');
}

int get_BatteryLevelAsPercentage(void)
{
	return 900 / getBatteryLevel();
}

void DoDataProcess( void )
{
	uint8_t nrOfCharsReceived = getBufferLength();	
	// check if no data was received
	if (nrOfCharsReceived == 0) return;
	
	static char receiveBuffer[RECEIVE_BUFFER_SIZE];
	static int index = -1;
	
	static bool wrapped = false;

	while(getBufferLength() > 0)
	{
		char newchar = readChar();
		
		if(!wrapped)
		{
			if(newchar == '{')
			{
				wrapped = true;
			}
			continue;
		}
		
		if(newchar == '}')
		{					
			if(index > -1)
			{				
				//parse request
				REQUEST_STRUCT request = {0, 0};
				parseRequest(&request, receiveBuffer, (index+1));
				
				writeString_P("{cmd=0x");
				writeInteger(request.cmd, HEX);
				writeString_P(";val=0x");
				writeInteger(request.val, HEX);
				writeString_P("}\n");
				
				switch(request.cmd)
				{
					case CMD_MOVE_FORWARD:
					{		
						if(move_horizontal<=0)
						{
							move_horizontal = request.val;
							if (request.val > topSpeed)
							{
								topSpeed = request.val;
							}
						}
						else
						{
							move_horizontal = 0;
						}
						move_turning = 0;
						break;
					}
					case CMD_MOVE_BACKWARD:
					{		
						if(move_horizontal>=0)
						{
							move_horizontal = request.val;
						}
						else
						{
							move_horizontal = 0;
						}	
						move_turning = 0;
						break;
					}
					case CMD_MOVE_LEFT:
					{		
						if(move_turning<=0)
						{
							move_turning = 1;
						}
						else
						{
							move_turning = 0;
						}		
						move_horizontal = 0;
						break;
					}
					case CMD_MOVE_RIGHT:
					{		
						if(move_turning >= 0)
						{
							move_turning = -1;
						}
						else
						{
							move_turning = 0;
						}
						move_horizontal = 0;
						break;
					}
					case CMD_STOP_MOVING:
					{
						move_horizontal = 0;
						move_turning = 0;
						break;
					}
					case CMD_GET_FUELLVL:
					{
						writeString_P("{cmd=0x");
						writeInteger(request.cmd, HEX);
						writeString_P(";val=0x");
						writeInteger(get_BatteryLevelAsPercentage(), HEX);
						writeString_P("}\n");
						break;
					}
					
					case CMD_GET_SPEED:
					{
						writeString_P("{cmd=0x");
						writeInteger(request.cmd, HEX);
						writeString_P(";val=0x");
						writeInteger(topSpeed, HEX);
						writeString_P("}\n");
						break;
					}
					
					default: //stop
					{
						
					}
				}
				
				//
			}
			wrapped = false;
			index = -1;
			continue;
		}
		
		receiveBuffer[++index] = newchar;

		//- reserve the last character of the buffer for '\0' character
		//- check not to write outside array boundaries.	
		if (index > (RECEIVE_BUFFER_SIZE-2)) //loop from 0 to (RECEIVE_BUFFER_SIZE-)
		{
			index = -1;
			wrapped = false;
			//THROW 'exception'/Error
			continue;
		}
	}
}

int main(void)
{
	initRP6Control(); // Always call this first! 
	                  // The Processor will not work correctly otherwise.
					 
	initLCD(); // Initialize the LC-Display (LCD)
			   // Always call this before using the LCD!

	// Play two sounds with the Piezo Beeper on the RP6Control:
	sound(180,80,25);
	sound(220,80,0);
	
	//IMPORTANT:
	I2CTWI_initMaster(100); // Initialize the TWI Module for Master operation
	// with 100kHz SCL Frequency
	
	// Register the event handlers:
	I2CTWI_setTransmissionErrorHandler(I2C_transmissionError);

	// Write a text message to the UART:
	writeString_P("{cmd=0x");
	writeInteger(CMD_LIFETIME, HEX);
	writeString_P("}\n");
	
	run_testCases();
	
	// Define a counting variable:
	//uint16_t counter = 0;
	
	// clear the UART buffer once at the start of the program
	clearReceptionBuffer();
	
	
	mSleep(1000);
	
	setStopwatch1(500);
	startStopwatch1();
	
	while(true)
	{
		//example of receiving some data over UART
		DoDataProcess();
		
		if(move_turning!=0)
		{
			if(move_turning == 1)
			{
				rotate(60, LEFT, 3, false);
			}
			else
			{
				rotate(60, RIGHT, 3, false);
			}
		}
		else		
		if(move_horizontal != 0)
		{
			if(move_horizontal > 0)
			{
				move(move_horizontal, FWD, 3, false);
			}
			else
			{
				move(move_horizontal, BWD, 3, false);
			}
		}
		
		//mSleep(100); // delay 100ms = 0.1s
	}
	return 0;
}
