int sensorPin1 = 0; //analog pin 0
int sensorPin2 = 1;
int sensorPin3 = 2;

void setup(){
  Serial.begin(9600);
}

void loop(){
  int val1 = analogRead(sensorPin2);
  int val2 = analogRead(sensorPin2);
  int val3 = analogRead(sensorPin3);
  
  
  
  Serial.print("1 = " + String(val1) + "\t");
  Serial.print("2 = " + String(val2) + "\t");
  Serial.print("3 = " + String(val3) + "\r\n");

  //just to slow down the output - remove if trying to catch an object passing by
  delay(100);

}
