/**
 * @file UARTBuild.ino
 * @author Juul Bloemers
 * @brief 
 * @version 0.1
 * @date 2019-01-05
 * 
 * @copyright Copyright (c) 2019
 * 
 */


////////////////////////////////////
// INCLUDES
////////////////////////////////////

#include "Arduino.h"

#include "UART.h"


////////////////////////////////////
// DEFINES
////////////////////////////////////

#define RX_PIN (3)                                  //Pin used for receiving data.
#define TX_PIN (2)                                  //Pin used for transmitting data.
#define BAUD_RATE (4800)                            //Symbols per second.
#define PARITY_BIT (ParityBit::PARITY_BIT_NONE)     //Parity bits to use.


////////////////////////////////////
// FUNCTIONS
////////////////////////////////////

void setup()
{
    Serial.begin(115200);
	
    //If UART could not be started.
    if(uart->Begin(RX_PIN, TX_PIN, BAUD_RATE, PARITY_BIT) == -1)
    {
        Serial.println("ERROR: Could not start UART.");
    }
}

void loop()
{
    while(Serial.available() > 0)
    {
        uart->Write(Serial.read());
    }

    while(uart->DataAvailable() > 0)
    {
        Serial.print(uart->Read());
    }
}
