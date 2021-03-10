/**
 * @file UART.h
 * @author Juul Bloemers
 * @brief This program is writting for: "Fontys university of applied sciences"; Course: "E-DES-E-T3"; Assignment: "45 Build your UART". A self build software UART library.
 * @version 0.1
 * @date 2019-01-04
 * 
 * @copyright Copyright (c) 2019
 * 
 */
#include "UART.h"

////////////////////////////////////
// EXTERNS
////////////////////////////////////

extern UART* uart = new UART();


////////////////////////////////////
// FUNCTIONS
////////////////////////////////////

void InterruptCallback()
{
    //updates uart.
    uart->HandleInterrupt();
}


////////////////////////////////////
// METHODS
////////////////////////////////////

UART::UART()
{
}

UART::~UART()
{
}

const int8_t UART::Begin(uint8_t rxPin, uint8_t txPin, uint32_t baudRate, ParityBit parityBit)
{
    //If an uart is already, return -1;
    if(this->isInitialized)
    {
        return -1;
    }

    //Set fields.
    this->rxPin = rxPin;
    this->txPin = txPin;
    this->baudRate = baudRate;
    this->parityBit = parityBit;
    this->messageLength = UART_FIXED_MESSAGE_LENGTH;

    //If parity bit is not parity bit none, add one to message length.
    if(parityBit != ParityBit::PARITY_BIT_NONE)
    {
        this->messageLength++;
    }

    //Set pin modes.
    pinMode(rxPin, INPUT);
    pinMode(txPin, OUTPUT);

    //Set TX pin to stop bit.
    digitalWrite(txPin, UART_STOP_BIT);

    //Set timer interrupt.
    Timer1.initialize(UART_BAUD_RATE_TO_INTERVAL(baudRate));
    Timer1.attachInterrupt(InterruptCallback);

    //Set isInitialized true.
    this->isInitialized = true;

    //Return success.
    return 0;
}

const int8_t UART::End()
{
    //If uart is not initialized, return -1;
    if(!this->isInitialized)
    {
        return -1;
    }

    //Remove interrupt.
    Timer1.stop();
    Timer1.detachInterrupt();

    //Set isInitialized false.
    this->isInitialized = false;

    //Return success.
    return 0;
}

const uint16_t UART::DataAvailable() const
{
    return this->receivingBuffer.Count();
}

void UART::Write(const char data)
{
    //Add data to buffer.
    this->transmissionBuffer.Push(data);
}

void UART::Write(const char* data)
{
    for(uint16_t i = 0; i < strlen(data); i++)
    {
        this->Write(data[i]);
    }
}

const char UART::Read()
{
    return this->receivingBuffer.Shift();
}

void UART::HandleInterrupt()
{
    //Increment uart updates.
    this->uartUpdates++;

    //update receiving.
    this->UpdateRX();

    if(this->uartUpdates >= UART_RX_SAMPLES)
    {
        //Reset uart updates.
        this->uartUpdates = 0;

        //Update transmitting.
        this->UpdateTX();
    }
}

const uint16_t UART::PrepareDataForTransmission(const char data)
{
    //Tmp saves data that needs to be transmitted. Set data to stop bit.
    uint16_t tmpData = UART_STOP_BIT;

    //If parity bit needs to be added.
    if(this->parityBit != ParityBit::PARITY_BIT_NONE)
    {
        //Shift current data to the left.
        tmpData = (tmpData << 1);

        //Add odd or even parity.
        tmpData |= (this->parityBit == ParityBit::PARITY_BIT_EVEN)? this->GetEvenParity(data) : this->GetOddParity(data);
    }

    //Shift stop bit and parity bit (if enabled) to the left for the length of data.
    tmpData = (tmpData << 8);

    //Add data.
    tmpData |= data;
    tmpData = (tmpData << 1);
    
    //Add start bit.
    tmpData |= UART_START_BIT;

    //Return tmp data.
    return tmpData;
}

const uint8_t UART::CountOnes(const char data)
{
    uint8_t ones = 0x00;

    for(uint8_t i = 0; i < 7; i++)
    {
        if(((data >> i) & 0b1))
        {
            ones++;
        }
    }

    return ones;
}

const uint8_t UART::GetEvenParity(const char data)
{
    return (this->CountOnes(data) % 2);
}

const uint8_t UART::GetOddParity(const char data)
{
    return (1 - this->GetEvenParity(data));
}

const uint8_t UART::DetermineReceivedBit()
{
    //Set determination buffer equal to the middle three bits.
    uint8_t determinationBuffer = ((this->receivedSamplesBuffer >> UART_RX_SAMPLES_CENTER) & 0b111);

    //If more ones than zeros, return 0b1 else return 0b0.
    if(this->CountOnes(determinationBuffer) >= 2)
    {
        return 0b1;
    }
    else
    {
        return 0b0;
    }
}

const bool UART::VerifyData(const uint16_t data)
{
    //Check for start bit.
    if(((data >> (this->messageLength - 1)) & 0b1) != UART_START_BIT)
    {
        return false;
    }

    //Check for stop bit.
    if((data & 0b1) != UART_STOP_BIT)
    {
        return false;
    }

    //Check for parity bit.
    if(this->parityBit == ParityBit::PARITY_BIT_EVEN)
    {
        if(this->GetEvenParity((data >> 2)) != 0b1)
        {
            return false;
        }
    }
    else if(this->parityBit == ParityBit::PARITY_BIT_ODD)
    {
        if(this->GetOddParity((data >> 2)) != 0b1)
        {
            return false;
        }
    }

    //Return encapsulated data.
    return true;
}

const char UART::FlipData(const char data)
{
    char tmpData = 0x00;
    for(uint8_t i = 0; i < 8; i++)
    {
        if(i > 0) tmpData = (tmpData << 1);
        tmpData |= ((data >> i) & 0b1);
    }
    return tmpData;
}

void UART::HandleReceivedData()
{
    if(this->VerifyData(this->receivedDataBuffer))
    {
        //If parity bit is used shift with 2 else with 1.
        uint8_t shiftNum = (this->parityBit != ParityBit::PARITY_BIT_NONE)? 2 : 1;

        char data = ((this->receivedDataBuffer >> shiftNum) & 0xFF);
        this->receivingBuffer.Push(this->FlipData(data));
    }
}

void UART::ClearReceivedSamplesBuffer()
{
    //Clear sample buffer.
    this->receivedSamplesBuffer = 0x00;

    //Set current received sample index to 0.
    this->currentReceivedSampleIndex = 0;
}

void UART::UpdateRX()
{
    //Shift one to the left.
    this->receivedSamplesBuffer = (this->receivedSamplesBuffer << 1);

    //Add bit to received data buffer.
    this->receivedSamplesBuffer |= digitalRead(this->rxPin);

    //Increment current received sample index.
    this->currentReceivedSampleIndex++;

    //If not receiving.
    if(!this->isReceiving)
    {
        //If start condition met (last received bit = stop bit && current received bit = start bit).
        if((this->receivedDataBuffer & 0b1) == UART_STOP_BIT && (this->receivedSamplesBuffer & 0b111) == UART_START_MASK) 
        {
            //Clear received samples buffer.
            this->ClearReceivedSamplesBuffer();

            //Clear received data buffer.
            this->receivedDataBuffer = 0x00;
            this->currentReceivedBitIndex = 0;
            this->currentReceivedSampleIndex = 3;

            //Start receiving.
            this->isReceiving = true;
        }
    }

    if(this->currentReceivedSampleIndex >= UART_RX_SAMPLES)
    {
        //Shift received buffer one to the left.
        this->receivedDataBuffer = (this->receivedDataBuffer << 1);
        
        //Add new received bit to received data buffer.
        this->receivedDataBuffer |= this->DetermineReceivedBit();

        //Clear received samples buffer.
        this->ClearReceivedSamplesBuffer();

        //If is receiving.
        if(this->isReceiving)
        {
            //Serial.print(this->receivedDataBuffer & 0b1);
            //Increment received bits.
            this->currentReceivedBitIndex++;

            if(this->currentReceivedBitIndex >= this->messageLength)
            {
                //Reset current recieved bit index.
                this->currentReceivedBitIndex = 0;

                //Set is recieving false.
                this->isReceiving = false;

                //handles the received data.
                this->HandleReceivedData();
            }
        }
    }
}

void UART::UpdateTX()
{
    //If transmission data buffer not empty and current transmitting bit index is lower than the message length.
    if(this->transmittingDataBuffer != 0x00 && this->currentTransmittingBitIndex < this->messageLength)
    {
        //Transmit bit.
        digitalWrite(this->txPin, ((this->transmittingDataBuffer >> this->currentTransmittingBitIndex) & 0b1));

        //Increment current transmitting bit index.
        this->currentTransmittingBitIndex++;
    }
    else
    {
        //Clear transmitting data buffer. 
        this->transmittingDataBuffer = 0x00;

        //Reset current transmitting bit index to 0.
        this->currentTransmittingBitIndex = 0;

        //If dat available.
        if(this->transmissionBuffer.Count() > 0)
        {
            //Prepare and set next data byte for transmission.
            this->transmittingDataBuffer = this->PrepareDataForTransmission(this->transmissionBuffer.Shift());
        }

    }
}