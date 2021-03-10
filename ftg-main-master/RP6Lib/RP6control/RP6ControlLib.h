/* ****************************************************************************
 *                           _______________________
 *                           \| RP6  ROBOT SYSTEM |/
 *                            \_-_-_-_-_-_-_-_-_-_/             >>> RP6 CONTROL
 * ----------------------------------------------------------------------------
 * ------------------- [c]2006 / 2007 - AREXX ENGINEERING ---------------------
 * -------------------------- http://www.arexx.com/ ---------------------------
 * ****************************************************************************
 * File: RP6ControlLib.h
 * Version: 1.1
 * Target: RP6 CONTROL - ATMEGA32 @16.00MHz
 * Author(s): Dominik S. Herwald
 * ****************************************************************************
 * Description:
 * The RP6 Robot Base function Library header file. Detailled description
 * of each function can be found in the RP6RobotBaseLib.c file!
 * 
 * ****************************************************************************
 * CHANGELOG AND LICENSING INFORMATION CAN BE FOUND AT THE END OF THIS FILE!
 * ****************************************************************************
 */

#ifndef RP6CONTROLLIB_H
#define RP6CONTROLLIB_H

/*****************************************************************************/
// Includes:

#include "internal/RP6Control.h" // General RP6 Robot Base definitions
#include "RP6uart.h"		 // RP6 UART function lib
#include "RP6Config.h"           // Configuration for RP6BaseLibrary - Constants for 
				 // speed and distance calculation etc.
							
#include <avr/sleep.h>		// Power saving functions
#include <util/delay.h>		// Some delay loops

#include "RP6_control.h"
#include "Adc.h"
#include "SPI.h"
#include "SPI_Eeprom.h"
#include "Leds.h"
#include "LCD.h"
#include "Keys.h"
#include "Stopwatch.h"
#include "Timer.h"
#include "Beep.h"
#include "Microphone.h"

/*****************************************************************************/

// You can use this define to identify the RP6Library version:
#define RP6LIB_VERSION 13
// (this does not mean file version - each file has its own
// sub-version but the complete library has an overall version)

/*****************************************************************************/
// External Interrupts:

void INT0_setEventHandler(void (*i0eventHandler)(void));
void INT1_setEventHandler(void (*i1eventHandler)(void));
void INT2_setEventHandler(void (*i2eventHandler)(void));

#endif
/******************************************************************************
 * Additional info
 * ****************************************************************************
 * Changelog:
 * 
 *  ---> changes are documented in the file "RP6ControlLib.c"
 *
 * ****************************************************************************
 * Bugs, feedback, questions and modifications can be posted on the AREXX Forum
 * on http://www.arexx.com/forum/ !
 * Of course you can also write us an e-mail to: info@arexx.nl
 * AREXX Engineering may publish updates from time to time on AREXX.com!
 * ****************************************************************************
 * - LICENSE -
 * GNU GPL v2 (http://www.gnu.org/licenses/gpl.txt, a local copy can be found
 * on the RP6 CD in the RP6 sorce code folders!)
 * This program is free software. You can redistribute it and/or modify
 * it under the terms of the GNU General Public License version 2 as published
 * by the Free Software Foundation.
 * ****************************************************************************
 */

/*****************************************************************************/
// EOF
