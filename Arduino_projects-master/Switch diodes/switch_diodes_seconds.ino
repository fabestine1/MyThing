int LED_red_pin = 5;
int LED_green_pin = 6;

void switch_diodes_seconds();


void setup() {
  Serial.begin(9600);
  pinMode(LED_red_pin,OUTPUT);
  pinMode(LED_green_pin,OUTPUT);

}


void loop() {
	switch_diodes_seconds();
}


void switch_diodes_seconds(){
  digitalWrite(LED_red_pin, HIGH);   
  digitalWrite(LED_green_pin, HIGH);   
  delay(500);
  
  digitalWrite(LED_red_pin, LOW);   
  delay(500);
  
  digitalWrite(LED_green_pin, LOW);   
  digitalWrite(LED_red_pin, HIGH); 
  delay(500);
 
}

 
