/*
 * Example Key Led.
 * Copyright Fontys 2019
 * Author: Jaap Geurts <jaap.geurts@fontys.nl>
 * Date: 05/07/2019
 * Based on the Arduino Button example. Adapted for the Rich Shield.
 */
#include "Display.h"

const int PIN_LED1 = 4;
const int PIN_LED2 = 5;

const int PIN_KEY1 = 9;
const int PIN_KEY2 = 8;
int attempts = 0;

int firstTry = 0;

int i = 0;

int firstCount = 1000;
int secondCount = 100;
int thirdCount = 10;
int fourthCount = 1;

int count = 1000;


void setup()
{
    pinMode(PIN_LED1, OUTPUT);
    pinMode(PIN_LED2, OUTPUT);


    
    pinMode(PIN_KEY1, INPUT_PULLUP);
    pinMode(PIN_KEY2, INPUT_PULLUP); 
    
}
int read_key()
{
    int key1 = digitalRead(PIN_KEY1);
    int key2 = digitalRead(PIN_KEY2);

    if (key1 == LOW)
        return 1;

    if (key2 == LOW)
        return 2;

    return 0;
}
void loop()
{
  int key = read_key();
  if(key == 1  && attempts == 0)
  {
    attempts++;
    digitalWrite(PIN_LED1, HIGH);
    digitalWrite(PIN_LED2, HIGH);
    delay(2000);
    digitalWrite(PIN_LED1, LOW);
    digitalWrite(PIN_LED2, LOW);
    
  }
  if(key == 1 && attempts >= 1)
  {
    if (key == 1)
    {
      if (i == 0)
      {
      if(count == 1000)
      {
         Display.show(count);
         count = ((count / 1000) + 1)  * 1000;
      }
      else
      {
        if(count > 4000)
        {
          count = 1000;
        }
        //Display.showD(0, 5);
        digitalWrite(PIN_LED2, HIGH);
        delay(500);
        digitalWrite(PIN_LED2, LOW);
        count = ((count / 1000) + 1)  * 1000;
      }
      
    }
    if(i == 1)
    {
     if(count == firstCount)
      {
         Display.show(count);
         count = count + (((count / 1000) + 1)  * 100);
      }
      else
      {
        if(count > 4400)
        {
          count = 1100;
        }
        Display.show(count);
        digitalWrite(PIN_LED2, HIGH);
        delay(500);
        digitalWrite(PIN_LED2, LOW);
        count = count + (((count / 1000) + 1)  * 100);
      }
    }


  }
  if(key == 2 && firstCount == 1000)
  {
        digitalWrite(PIN_LED1, HIGH);
    i++;

    firstCount = count;
    //count = 1000;
  }
  else if(key == 2 && secondCount == 100 && i == 1)
  {
    i++;
    digitalWrite(PIN_LED1, HIGH);
    delay(500);
    digitalWrite(PIN_LED1, LOW);
    secondCount = count / 10;
    count = firstCount + secondCount;
  }
    
  else if(key == 2 && thirdCount == 10 && i == 2)
  {
    i++;
    thirdCount = count / 100;
    //count = 1000;
  }
  else if(key == 2 && fourthCount == 1 && i == 3)
  {
    fourthCount = count / 1000;
  }
}
}
  

  
