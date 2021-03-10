/**
 * @file CharBuffer.h
 * @author Juul Bloemers
 * @brief 
 * @version 0.1
 * @date 2019-01-04
 * 
 * @copyright Copyright (c) 2019
 * 
 */
#ifndef CHAR_BUFFER_H
#define CHAR_BUFFER_H


////////////////////////////////////
// INCLUDES
////////////////////////////////////

#include <stdint.h>
#include <stdlib.h>


////////////////////////////////////
// CLASSES
////////////////////////////////////

class CharBuffer {

    public:

        /**
         * @brief Construct a new Char Buffer object
         * 
         * @param size Max number of elements that can be stored.
         */
        CharBuffer(uint16_t size);

        ~CharBuffer();

        /**
         * @brief Counts the number of elements put into the buffer.
         * 
         * @return uint16_t Number of elements.
         */
        const uint16_t Count() const;

        /**
         * @brief Add element to end of buffer.
         * 
         * @param data Element to add.
         * 
         * @return char 0 if successfully added.
         */
        const int8_t Push(char data);

        /**
         * @brief Removes the last element from the buffer and returns that element.
         * 
         * @return char Element at end of buffer.
         * 
         * @pre Buffer contains items.
         */
        const char Pop();

        /**
         * @brief Removes the first element from the buffer and returns that element.
         * 
         * @return char The first element in the buffer.
         * 
         * @pre Buffer contains items.
         */
        const char Shift();

        /**
         * @brief Removes all elements from the buffer.
         * 
         */
        void Flush();

    private:

        const uint16_t size;    //Max number of elements the buffer can store.
        
        char* buffer;           //Buffer where elements are stored.
        uint16_t count;         //Number of elements in buffer.

};

#endif