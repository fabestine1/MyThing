int LED_red_pin = 5;
int LED_green_pin = 6;

void diode_ping();


void setup() {
  Serial.begin(9600);
  pinMode(LED_red_pin,OUTPUT);
  pinMode(LED_green_pin,OUTPUT);

}


void loop() {
   security_button();

}

void diode_ping(){
  
  Serial.print("On\n");
  digitalWrite(LED_red_pin, HIGH);   
  delay(1000);
  
  Serial.println("Off");
  digitalWrite(LED_red_pin, LOW);
  delay(1000);
  
}

