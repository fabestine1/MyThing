/**
 * @file CharBuffer.cpp
 * @author Juul Bloemers
 * @version 0.1
 * @date 2019-01-04
 * 
 * @copyright Copyright (c) 2019
 * 
 */
#include "CharBuffer.h"

CharBuffer::CharBuffer(uint16_t size)
    : size(size), buffer(new char[size])
{
    this->Flush();
}

CharBuffer::~CharBuffer()
{
    delete[] this->buffer;
}

const uint16_t CharBuffer::Count() const
{
    return this->count;
}

const int8_t CharBuffer::Push(char data)
{
    //If buffer is full, return -1.
    if(this->count >= this->size) return -1;

    //Insert data at index.
    this->buffer[this->count] = data;

    //Increment counter.
    this->count++;
}

const char CharBuffer::Pop()
{
    //If buffer is empty, return 0.
    if(this->count == 0) return 0;

    //Tmp data store.
    char data = this->buffer[this->count - 1];

    //Decrement counter.
    this->count--;

    //Return data.
    return data;
}

const char CharBuffer::Shift()
{
    //If buffer is empty, return 0.
    if(this->count == 0) return 0;

    //TMP data store.
    char data = this->buffer[0];

    //Move all elements one to the front of the buffer.
    for(uint16_t i = 1; i < this->count; i++) 
    {
        //Move element one back.
        this->buffer[i - 1] = this->buffer[i];
    }

    //Decrement counter.
    this->count--;

    return data;
}

void CharBuffer::Flush()
{
    //Reset count.
    this->count = 0;
}