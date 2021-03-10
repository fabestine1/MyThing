/**
 * @file UART.h
 * @author Juul Bloemers
 * @brief This program is writting for: "Fontys university of applied sciences"; Course: "E-DES-E-T3"; Assignment: "45 Build your UART". Uses the timer1 interrupt for timing. Baud rates up to 4800 are tested and should work fine.
 * @version 0.1
 * @date 2019-01-04
 * 
 * @copyright Copyright (c) 2019
 * 
 */
#ifndef UART_H
#define UART_H


////////////////////////////////////
// INCLUDES
////////////////////////////////////

#include <stdint.h>

#include "Arduino.h"

#include "TimerOne.h"

#include "ParityBit.h"
#include "CharBuffer.h"


////////////////////////////////////
// DEFINES
////////////////////////////////////

#define MICROS_PER_SECOND (1000000)                                                         //Micro seconds per second.

#define UART_FIXED_MESSAGE_LENGTH (10)                                                      //Length a message always will be (parity bit is ignored).

#define UART_RX_SAMPLES (8)                                                                 //Samples used for reading data.
#define UART_RX_SAMPLES_CENTER ((UART_RX_SAMPLES / 2) - 1)                                  //Center of the samples.
#define UART_START_BIT (0b0)                                                                //Message starts with this bit.
#define UART_STOP_BIT (0b1)                                                                 //Message ends with this bit.

#define UART_START_MASK (UART_START_BIT | (UART_START_BIT >> 1) | (UART_START_BIT >> 2))    //Mask for detecting UART start.

#define UART_RX_BUFFER_LENGTH (128)                                                         //Max amount of received chars that can be stored.
#define UART_TX_BUFFER_LENGTH (128)                                                         //Max amount of chars waiting to be transmitted.

#define UART_BAUD_RATE_TO_INTERVAL(UART_FREQUENCY) (\
            (uint32_t)((double)MICROS_PER_SECOND / (UART_FREQUENCY * UART_RX_SAMPLES))\
    )                                                                                       //Calculate interrupt interval using frequency and samples.


////////////////////////////////////
// CLASSES
////////////////////////////////////

class UART {

    public:

        UART();
        ~UART();

        /**
         * @brief Begin UART.
         * 
         * @param rxPin Receiving pin.
         * @param txPin Transmission pin.
         * @param baudRate Symbols per second.
         * 
         * @return int8_t 0 if success.
         * 
         * @pre rxPin Needs to be a digital pin higher than 1.
         * @pre txPin Needs to be a digital pin higher than 1. Cannot be the same as rxPin.
         */
        const int8_t Begin(uint8_t rxPin, uint8_t txPin, uint32_t baudRate, ParityBit parityBit);
        
        /**
         * @brief End UART.
         * 
         * @return int8_t 0 if success.
         */
        const int8_t End();

        /**
         * @brief If receiving buffer contains data.
         * 
         * @return uint16_t Number of bytes available.
         */
        const uint16_t DataAvailable() const;

        /**
         * @brief Read data from UART.
         * 
         * @return const char 
         */
        const char Read();

        /**
         * @brief Write data to UART.
         * 
         * @param data 
         */
        void Write(const char data);

        /**
         * @brief Write data to UART.
         * 
         * @param data 
         * 
         * @pre data Needs to be an array.
         */
        void Write(const char* data);

        /**
         * @brief Handles the timer interrupt callback.
         * 
         */
        void HandleInterrupt();

    private:

        bool isInitialized = false;                                         //UART is initialized.         

        uint8_t rxPin;                                                      //Pin setup for receiving.
        uint8_t txPin;                                                      //Pin setup for transmitting.
        uint32_t baudRate;                                                  //Symbols per second.
        uint8_t messageLength;                                              //Length of a message.
        ParityBit parityBit;                                                //What type of parity bit to use.

        uint8_t uartUpdates;                                                //Number of times the interrupt has called the update function.

        //RX
        CharBuffer receivingBuffer = CharBuffer(UART_RX_BUFFER_LENGTH);     //Stores all received data.
        uint16_t receivedDataBuffer;                                        //Stores the currently receiving data.
        uint8_t currentReceivedBitIndex;                                    //The current bit that is being read.
        uint16_t receivedSamplesBuffer;                                     //Samples taken from the RX pin.
        uint8_t currentReceivedSampleIndex;                                 //The current sample that is being read.
        bool isReceiving = false;                                           //Is receiving data.

        //TX
        CharBuffer transmissionBuffer = CharBuffer(UART_TX_BUFFER_LENGTH);  //Stores data that needs to be transmitted.
        uint16_t transmittingDataBuffer;                                    //Stores the data that is currently being transmitted.
        uint8_t currentTransmittingBitIndex;                                //The current bit thit is being transmitted.

        /**
         * @brief Prepares dat to be transmitted (Adds start bit, stop bit and parity bit(If needed)).
         * 
         * @param data 
         * @return const uint16_t Prepated data.
         */
        const uint16_t PrepareDataForTransmission(const char data);

        /**
         * @brief Counts all bits that are equal to 1.
         * 
         * @param data 
         * @return const uint8_t 
         */
        const uint8_t CountOnes(const char data);

        /**
         * @brief Get event parity bit.
         * 
         * @param data 
         * @return const uint8_t 
         */
        const uint8_t GetEvenParity(const char data);

        /**
         * @brief Get odd parity bit.
         * 
         * @param data 
         * @return const uint8_t 
         */
        const uint8_t GetOddParity(const char data);

        /**
         * @brief Determines what bit is received using the receivedSamplesBuffer.
         * 
         * @return const uint8_t
         */
        const uint8_t DetermineReceivedBit();

        /**
         * @brief Verifies data.
         * 
         * @param data Data to verify.
         * @return true Data is verified.
         * @return false Data is not verified.
         */
        const bool VerifyData(const uint16_t data);

        /**
         * @brief Flips the byte vertically.
         * 
         * @param data Data to flip.
         * @return const char Flipped data.
         */
        const char FlipData(const char data);

        /**
         * @brief Handles the received data.
         * 
         */
        void HandleReceivedData();

        /**
         * @brief Clears the receiving samples buffer.
         * 
         */
        void ClearReceivedSamplesBuffer();

        /**
         * @brief Update receiving.
         * 
         */
        void UpdateRX();

        /**
         * @brief Update tranmission.
         * 
         */
        void UpdateTX();

};

////////////////////////////////////
// EXTERNS
////////////////////////////////////

extern UART* uart;

#endif