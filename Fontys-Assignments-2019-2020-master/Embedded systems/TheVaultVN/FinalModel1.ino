
// Including the Display
#include "Display.h".

// Declaring Red and Green lights
const int LED1 = 4;
const int LED2 = 5;
const int LED3 = 6;

//Declaring Buttonsint PIN_KEY1 = 9;
int PIN_KEY2 = 8;

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

Display.showDigitAt(0, 3);

Display.showDigitAt(1, 2);


Display.showDigitAt(2, 1);


Display.showDigitAt(3, 4);

delay(5000);
  
}
