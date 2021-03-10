
// Including the Display
#include "Display.h".

// Declaring Red and Green lights
const int LED1 = 4;
const int LED2 = 5;
const int LED3 = 6;
const int LED4 = 7;

//Declaring Buttons
const int PIN_KEY1 = 9;
const int PIN_KEY2 = 8;

//StartTheProgram
int attempts = 0;

//Counter
int cnt = 0;
//counters for the loops
int c = 0;
int g = 0;

//passcodes
int originalPasscode = 0;
int inputPasscode = 0;

//boolean for checking if the pass is set
bool setPass = false;

void setup() {
  //Red and green light
pinMode(LED1, OUTPUT);
pinMode(LED2, OUTPUT);
pinMode(LED3, OUTPUT);
pinMode(LED4, OUTPUT);

//TwoButtons
pinMode(PIN_KEY1, INPUT_PULLUP);
pinMode(PIN_KEY2, INPUT_PULLUP);

}
//function for reading the key
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
//function which displays the numbers
void displayNums(int pos, int cnt)
{
  if(cnt == 0)
  {
    Display.showDigitAt(pos, '-');
  }
  else
  {
      Display.showDigitAt(pos, cnt);
  }
  digitalWrite(LED2, HIGH);
  delay(500);
  digitalWrite(LED2, LOW);
}

void loop() {
//reading the key
int key = read_key();
//starting the sequence
// if confirm button is clicked we increase the attempts and move to the next num
if(key == 1 && attempts == 0)
{

  attempts++;
digitalWrite(LED1, HIGH);
digitalWrite(LED2, HIGH);
delay(2000);
digitalWrite(LED1, LOW);
digitalWrite(LED2, LOW);

//if the pass is not set print read and flash the lights
  if(!setPass)
  {
    while(g < 4)
    {
      Display.show("rEAd");
      digitalWrite(LED1, HIGH);
      digitalWrite(LED2, HIGH);
      digitalWrite(LED3, HIGH);
      digitalWrite(LED4, HIGH);
      delay(600);
      digitalWrite(LED1, LOW);
      digitalWrite(LED2, LOW);
      digitalWrite(LED3, LOW);
      digitalWrite(LED4, LOW);
      delay(600);
      g++;
    }
  }
  // replacing zeros with dashes for better UI
Display.showDigitAt(0, '-');
Display.showDigitAt(1, '-');
Display.showDigitAt(2, '-');
Display.showDigitAt(3, '-');
}
else if(key == 1 && attempts == 1) //when confirm button is clicked we move to the next digit (in this if else statement - the first)
{

  cnt++;
      if(cnt > 4)
  {
    cnt = 0;
  }
  displayNums(0, cnt);

}
else if(key == 1 && attempts == 2) //second digit
{
    cnt++;
        if(cnt > 4)
  {
    cnt = 0;
  }
    displayNums(1, cnt);

}
else if(key == 1 && attempts == 3)//third digit
{

    cnt++;
        if(cnt > 4)
  {
    cnt = 0;
  }
    displayNums(2, cnt);

}
else if(key == 1 && attempts == 4)//fourth digit
{

    cnt++;
        if(cnt > 4)
  {
    cnt = 0;
  } 
    displayNums(3, cnt);

}
// confirm button is pressed
if(key == 2 && attempts > 0)
{
  if(attempts == 1)
  {
    inputPasscode = cnt * 1000;
    attempts++;
    cnt = 0;
    digitalWrite(LED1, HIGH);
    delay(1000);
    digitalWrite(LED1, LOW);
  }
  else if(attempts == 2)
  {
    inputPasscode = inputPasscode + (cnt * 100);
    attempts++;
            cnt = 0;
        digitalWrite(LED1, HIGH);
    delay(1000);
    digitalWrite(LED1, LOW);
  }
    else if(attempts == 3)
  {
    inputPasscode = inputPasscode + (cnt * 10);
    attempts++;
            cnt = 0;
        digitalWrite(LED1, HIGH);
    delay(1000);
    digitalWrite(LED1, LOW);
  }
    else if(attempts == 4)
  {
        inputPasscode = inputPasscode + cnt;
                attempts++;
        cnt = 0;
    digitalWrite(LED1, HIGH);
    delay(1000);
    digitalWrite(LED1, LOW);
        if(!setPass)
        {
            digitalWrite(LED1, HIGH);
          digitalWrite(LED2, HIGH);
          digitalWrite(LED3, HIGH);
          digitalWrite(LED4, HIGH);
          delay(600);
          digitalWrite(LED1, LOW);
          digitalWrite(LED2, LOW);
          digitalWrite(LED3, LOW);
          digitalWrite(LED4, LOW);
          
          originalPasscode = inputPasscode;
          attempts = -1;
          setPass = true;
          
        }


    if(inputPasscode == originalPasscode && attempts > 0)
    {
      while(c < 3)
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
    else if(attempts > 0)
    {
      digitalWrite(LED1, HIGH);
      delay(5000);
      digitalWrite(LED1, LOW);
      delay(1000);
    }
    inputPasscode = 0;
    cnt = 0;
    c = 0;
    attempts = 0;
  }

}
}
