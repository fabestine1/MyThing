//Temperature
#include "Display.h"

const int PIN_NTC = 15;
const int NTC_R25 = 10000; // the resistance of the NTC at 25'C is 10k ohm
const int NTC_MATERIAL_CONSTANT = 3950; // value provided by manufacturer

int counter = 0;

//DisabledAlarms
bool tempAlarm = true;
bool lightAlarm = true;

//Light
const int PIN_LDR = 16;

const int h4 = 1000;

//Buttons
const int PIN_KEY1 = 9;
const int PIN_KEY2 = 8;

//Leds
const int LED1 = 4;
const int LED2 = 5;
const int LED3 = 6;
const int LED4 = 7;

//Buzzer
const int BUZZER = 3;

//Temperature borders
int maxTemp = 30.00;
int minTemp = 25.00;
//Light borders
int maxLight = 950;
int minLight = 300;

const int quarternote = 250;
const int halfnote = 2 * quarternote;
const int wholenote = 4 * quarternote;

bool tempMess = true;



void setup() {
  Serial.begin(9600);
  pinMode(PIN_LDR, INPUT);
  pinMode(LED1, OUTPUT);
  pinMode(LED2, OUTPUT);
  pinMode(LED3, OUTPUT);
  pinMode(LED4, OUTPUT);
  pinMode(PIN_KEY1, INPUT_PULLUP);
  pinMode(PIN_KEY2, INPUT_PULLUP);
}

float get_temperature()
{
  float temperature, resistance;
  int value;
  value = analogRead(PIN_NTC);
  resistance   = (float)value * NTC_R25 / (1024 - value); // Calculate resistance
  /* Calculate the temperature according to the following formula. */
  temperature  = 1 / (log(resistance / NTC_R25) / NTC_MATERIAL_CONSTANT + 1 / 298.15) - 273.15;
  return temperature;
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
  int button1;
  int button2;

  int key = read_key();

  if (key == 1)
  {
    if (lightAlarm)
    {
      maxLight = 10000;
      minLight = -10000;
      lightAlarm = false;
      delay(50);
    }
    else if (!lightAlarm)
    {
      maxLight = 950;
      minLight = 300;
      lightAlarm = true;
      delay(50);
    }
  }

  if (key == 2)
  {
    if (tempAlarm)
    {
      maxTemp = 10000;
      minTemp = -10000;
      tempAlarm = false;
      delay(50);
    }
    else if (!tempAlarm)
    {
      maxTemp = 30.00;
      minTemp = 25.00;
      tempAlarm = true;
      delay(50);
    }
  }

  if (!tempAlarm && !lightAlarm)
  {
    digitalWrite(LED2, LOW);
    digitalWrite(LED1, LOW);
    digitalWrite(LED4, HIGH);
    key = read_key();
    if(key == 1)
    {
      delay(50);
       digitalWrite(LED4, LOW);
    }
    else if(key == 2)
    {
      delay(50);
       digitalWrite(LED4, LOW);
    }
  }
  else if (!lightAlarm)
  {

    button1 = digitalRead(PIN_KEY1);
    if (button1 == LOW)
    {
      delay(50);
      button1 = digitalRead(PIN_KEY1);
      if (button1 == LOW)
      {
        maxLight = 950;
        minLight = 300;
        lightAlarm = true;
        delay(50);
      }
    }
      digitalWrite(LED2, HIGH);
      delay(1000);
      digitalWrite(LED2, LOW);
      delay(1000);

  }
  else if (!tempAlarm)
  {
    button2 = digitalRead(PIN_KEY2);
    if (button2 == LOW)
    {
      delay(50);
      button1 = digitalRead(PIN_KEY2);
      if (button2 == LOW)
      {
        maxTemp = 30.00;
        minTemp = 25.00;
        tempAlarm = true;
        delay(50);
      }
    }
    
    digitalWrite(LED2, HIGH);
    delay(1000);
    digitalWrite(LED2, LOW);
    delay(900);
  }
  else
  {
    digitalWrite(LED2, HIGH);
  }


  // read the analog value
  int lightValue = analogRead(PIN_LDR);


  float celcius;

  celcius = get_temperature();
  delay(100);


  Serial.print(lightValue / 100.0);      //the first variable for plotting
  Serial.print(",");              //seperator
  Serial.println(celcius);          //the second variable for plotting including line break

  Display.show(celcius);


  delay(20);          //20ms delay


  if (lightValue < minLight || lightValue > maxLight )
  {
    digitalWrite(LED3, HIGH);

    for (int i = 0; i < 10; i++) {
      tone(BUZZER, 3830);
      digitalWrite(LED1, HIGH);
      delay(500);
      noTone(BUZZER);
      digitalWrite(LED1, LOW);
      delay(500);
    }

    digitalWrite(LED3, LOW);

  }
  if (celcius < minTemp || celcius > maxTemp )
  {
    digitalWrite(LED4, HIGH);

    for (int i = 0; i < 10; i++) {
      tone(BUZZER, 1912);
      digitalWrite(LED1, HIGH);
      delay(500);
      noTone(BUZZER);
      digitalWrite(LED1, LOW);
      delay(500);
    }

    digitalWrite(LED4, LOW);
  }
}
