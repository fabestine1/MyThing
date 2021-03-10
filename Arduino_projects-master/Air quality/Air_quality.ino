int sensorValue;
int digitalValue;
int previousState = 0; //0 - ok, 1 - bad

int normal_air_diode = 6;
int bad_air_diode = 13;
/*
   Normal air returns approximately 100-150
   Alcohol returns approximately 700
   Lighter gas returns approximately 750
*/
void setup()

{
  Serial.begin(9600);
  pinMode( 0, INPUT);
  pinMode(bad_air_diode, OUTPUT);
  pinMode(normal_air_diode, OUTPUT);

}

void loop()

{

  sensorValue = analogRead(0);
  digitalValue = digitalRead(0);
  Serial.println(sensorValue, DEC);  // prints the value read
  if (sensorValue < 161) {
    // normal air
    Serial.print("It's okay!\n");
    digitalWrite(normal_air_diode, HIGH);
    digitalWrite(bad_air_diode, LOW);



  } else {
    Serial.print("Something's wrong!\n");
    digitalWrite(bad_air_diode, HIGH);
    digitalWrite(normal_air_diode, LOW);


  }
  delay(5000);

}
