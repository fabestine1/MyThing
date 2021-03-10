//Display initializing
#include <Display.h>

//Buttons initializing
const int PIN_KEY1 = 9;
const int PIN_KEY2 = 8;

//Counter for the modes
int cnt = 1;

//Buzzer initializing
const int BUZZER = 3;

//Initializing red led
const int LED1 = 4;
const int LED2 = 5;


//Temp
const int PIN_NTC = 15;
const int NTC_R25 = 10000; // the resistance of the NTC at 25'C is 10k ohm
const int NTC_MATERIAL_CONSTANT = 3950; // value provided by manufacturer

//Millis atributes
unsigned long startTime;
const int INTERVAL = 1000;

//Reading from the visual studio
String line;

//Knob initialization
const int MAX_ANGLE = 30;
const int PIN_POTMETER = 14;
int oldAngle;

//Alarm activation
bool alarmTrigger = false;


//Debounce initialization
bool period = true;

long TimeOfLastDebounce = 0;  // holds the last time the switch was pressed
long DelayofDebounce = 100;  // amount of time that needs to be experied between presses


int firstButtonState = 0;
int secondButtonState = 0;

void setup() {
  startTime = millis();
  pinMode(PIN_KEY1, INPUT_PULLUP);
  pinMode(PIN_KEY2, INPUT_PULLUP);
  pinMode(LED1, OUTPUT);
  Serial.begin(9600);

  pinMode(PIN_POTMETER, INPUT);

  oldAngle = get_knob_angle();

}

float get_temperature() // Getting temperature function
{
  float temperature, resistance;
  int value;
  value = analogRead(PIN_NTC);
  resistance   = (float)value * NTC_R25 / (1024 - value); // Calculate resistance
  /* Calculate the temperature according to the following formula. */
  temperature  = 1 / (log(resistance / NTC_R25) / NTC_MATERIAL_CONSTANT + 1 / 298.15) - 273.15;
  return temperature;
}

int get_knob_angle() // Getting knob angle function
{
  int sensor_value = analogRead(PIN_POTMETER);
  int angle;
  // map is an Arduino library function.
  // it maps one range to another range.
  angle = map(sensor_value, 0, 1023, 0, MAX_ANGLE);

  return angle;
}



void loop() {
  //Getting the temp
  float celcius;
  celcius = get_temperature();

  unsigned long currentTime1 = millis();


  if (currentTime1 - startTime > INTERVAL) // Sending the temperature to the Windows
  {
    Serial.println(celcius);
    startTime = currentTime1;
  }

  if (digitalRead(PIN_KEY1) == LOW && firstButtonState == 0) { // debouncing the first button which encrease the counter
    delay(100);  // The higher the Delay the less chance of bouncing
    firstButtonState = 1;
    cnt++;
  } else {
    if (firstButtonState == 1 && digitalRead(PIN_KEY1) == HIGH) {
      firstButtonState = 0;
    }
  }
  if (digitalRead(PIN_KEY2) == LOW && secondButtonState == 0) { // Debouncing the second button for alarm triggering
    delay(100);  // The higher the Delay the less chance of bouncing
    secondButtonState = 1;
    alarmTrigger = true;
  } else {
    if (secondButtonState == 1 && digitalRead(PIN_KEY2) == HIGH) {
      secondButtonState = 0;
    }
  }

  
// Checking if someone is moving the knob and switching to mode 3
  int angle;
  angle = get_knob_angle();
  if (angle != oldAngle)
  {
    cnt = 3;
    oldAngle = angle;
  }
// Checking the temperature
  if (celcius < 15.5 || celcius > 29.5 || alarmTrigger)
  {
    digitalWrite(LED1, HIGH);
    if (alarmTrigger)
    {
      Serial.println("alarmon");
    }
    else if (celcius < 15.5)
    {
      Serial.println("tempbelow");
    }
    else if (celcius > 29.5)
    {
      Serial.println("tempabove");
    }

    while (true) {
      //tone(BUZZER, 3830);
      digitalWrite(LED2, HIGH);

      String line;
      line = Serial.readStringUntil('\n');
      if (line == "alarmoff")
      {
        alarmTrigger = false;
        noTone(BUZZER);
        digitalWrite(LED1, LOW);
        digitalWrite(LED2, LOW);
        break;

      }
    }
  }
// The modes of the arduino
  if (cnt == 1)
  {
    line = Serial.readStringUntil('\n');
    Display.show(line);

  }
  else if (cnt == 2)
  {
    unsigned long currentTime = millis();


    if (currentTime - startTime > INTERVAL)
    {
      Display.show(celcius);
      startTime = currentTime;
    }
  }
  else if (cnt == 3)
  {
    Display.show(angle);
    delay(200);
  }
  else if (cnt == 4)
  {
    cnt = 1;
  }

}
