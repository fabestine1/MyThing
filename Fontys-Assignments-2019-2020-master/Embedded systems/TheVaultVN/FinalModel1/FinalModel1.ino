
// Including the Display
#include "Display.h".

// Declaring Red and Green lights
const int LED1 = 4;
const int LED2 = 5;
const int LED3 = 6;

//Declaring Buttons
const int PIN_KEY1 = 9;
const int PIN_KEY2 = 8;

//StartTheProgram
int attempts = 0;

//iterator to follow the numbers
int i = 0;

//counter which data we will use to assign
int count1 = 1000;
int count2 = 100;
int count3 = 10;
int count4 = 1;


//passcodes
int originalPasscode = 2431;
int inputPasscode = 0;

//iterator for the while loop
int c;


void setup() {
//Red and green light
pinMode(LED1, OUTPUT);
pinMode(LED2, OUTPUT);
pinMode(LED3, OUTPUT);

//TwoButtons
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

void loop() {
  int key = read_key();

  if(key == 1 && attempts == 0)
  {
    attempts++;
    digitalWrite(LED1, HIGH);
    digitalWrite(LED2, HIGH);
    delay(2000);
    digitalWrite(LED1, LOW);
    digitalWrite(LED2, LOW);
    Display.show(count1);
  }
  else if(key == 1 && attempts > 0 && i == 0)
  {
    if (key == 1)
    {
      if(count1 == 1000)
      {
         Display.show(count1);
         count1 = ((count1 / 1000) + 1)  * 1000;
      }
      else
      {
        if(count1 > 4000)
        {
          count1= 1000;
        }
        Display.show(count1);
        digitalWrite(LED2, HIGH);
        delay(500);
        digitalWrite(LED2, LOW);
        count1 = ((count1 / 1000) + 1)  * 1000;
      }
  }
  //digitalWrite(LED3, HIGH);
  //delay(500);
  //digitalWrite(LED3, LOW);
  }
  else if(key == 1 && attempts > 0 && i == 1)
  {
    if (key == 1)
    {       
        if(count2 >  400)
        {
          count2 = 100;
        }
        Display.show((count1 - 1000) + count2);
        digitalWrite(LED2, HIGH);
        delay(500);
        digitalWrite(LED2, LOW);
        count2 = count2 + 100;
  }
  }
    else if(key == 1 && attempts > 0 && i == 2)
  {
    if (key == 1)
    {       
        if(count3 >  40)
        {
          count3 = 10;
        }
        Display.show((count1 - 1000) + (count2 - 100) + count3);
        digitalWrite(LED2, HIGH);
        delay(500);
        digitalWrite(LED2, LOW);
        count3 = count3 + 10;
  }
  }
  else if(key == 1 && attempts > 0 && i == 3)
  {
    if (key == 1)
    {       
        if(count4 >  4)
        {
          count4 = 1;
        }
        Display.show((count1 - 1000) + (count2 - 100) + (count3 - 10) + count4);
        digitalWrite(LED2, HIGH);
        delay(500);
        digitalWrite(LED2, LOW);
        count4 = count4 + 1;
  }
  }
  if(key == 2 && i == 3)
  {
    inputPasscode = (count1 - 1000) + (count2 - 100) + (count3 - 10) + (count4 - 1);
    if(inputPasscode == originalPasscode)
    {
        while(c < 5)
        {
          digitalWrite(LED2, HIGH);
          Display.show("5UCC");
          delay(500);
          digitalWrite(LED2, LOW);
          Display.show("UCCE");
          delay(500);
          digitalWrite(LED2, HIGH);
          Display.show("CCE5");
          delay(500);
          digitalWrite(LED2, LOW);
          Display.show("CE55");
          delay(500);
          c++;
        }
    }
    else
    {
      digitalWrite(LED1, HIGH);
      delay(5000);
      digitalWrite(LED1, LOW);
      delay(1000);



      attempts = 0;
      
    }
      i = 0;
      count1 = 1000;
      count2 = 100;
      count3 = 10;
      count4 = 1;
      inputPasscode = 0;
      c = 0;
  }
  else if(key == 2)
  {
    digitalWrite(LED1, HIGH);
    delay(1000);
    digitalWrite(LED1, LOW);
    i++;
  }

  
}
