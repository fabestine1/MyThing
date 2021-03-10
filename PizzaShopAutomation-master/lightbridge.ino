#include "Display.h"
int const RED_DIODE_PIN = 4;
int const GREEN_DIODE_PIN = 5;
int const BUZZER_PIN = 3;
const int LIGHT_DETECTOR_PIN = A2;
bool state = false, lastState = false;
int counter = 0;
void setup() {
  Serial.begin(9600);
  pinMode(GREEN_DIODE_PIN, OUTPUT);
  pinMode(RED_DIODE_PIN, OUTPUT);
  pinMode(BUZZER_PIN, OUTPUT);
  // turn off diodes and buzzer
  digitalWrite(BUZZER_PIN, LOW); // set it to silent in case it was on
  digitalWrite(GREEN_DIODE_PIN, LOW);
  Display.show("----");
}
void brightness_sound(){
   tone(BUZZER_PIN,3000,20);
}
void warningSound(){
   tone(BUZZER_PIN,300,10);
}
void brightnessIsTooLittle(int brightness){
  (brightness < 540) ? (state = true): (state = false);
  delay(35);
}
void loop(){ 
  Display.show(counter);
  digitalWrite(GREEN_DIODE_PIN, LOW); 
  int brightness = analogRead(LIGHT_DETECTOR_PIN);
  brightnessIsTooLittle(brightness);
  Serial.print("-");
  Serial.print(counter);
  if(Serial.available() > 0){
    char input = Serial.read(); 
    switch (input){
        case '1': 
          if(counter > 0)counter--;
          digitalWrite(GREEN_DIODE_PIN, HIGH);
          break;
    }
  }
  if (state != lastState) {
    if (lastState == true) { 
        brightness_sound();
        counter++;
        digitalWrite(GREEN_DIODE_PIN, HIGH);
    }
    lastState = state;
  }
  if(counter > 5){
    digitalWrite(RED_DIODE_PIN, HIGH);
    warningSound();
  } else{
    digitalWrite(RED_DIODE_PIN, LOW);
  }
}  