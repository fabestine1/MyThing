int LED_red_pin = 5;
int LED_green_pin = 6;

void diode_lightup();

void setup() {
  Serial.begin(9600);
  pinMode(LED_red_pin,OUTPUT);
  pinMode(LED_green_pin,OUTPUT);

}


void loop() {
  diode_lightup();
}


void diode_lightup(){

  Serial.print("On\n");
  digitalWrite(LED_green_pin, HIGH);   
  delay(100);
  
  Serial.println("Off");
  digitalWrite(LED_green_pin, LOW);
  delay(100);

   Serial.print("On\n");
  digitalWrite(LED_red_pin, HIGH);   
  delay(100);
  
  Serial.println("Off");
  digitalWrite(LED_red_pin, LOW);
  delay(100);

}
