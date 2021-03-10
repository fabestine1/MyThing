int LED_red_pin = 5;
int LED_green_pin = 6;
int pot_pin = 0;
int intensity_max = 255; 

void pot_diodes();

void setup() {
  Serial.begin(9600);
  pinMode(LED_red_pin,OUTPUT);
  pinMode(LED_green_pin,OUTPUT);
  pinMode(button_pin,INPUT);
  pinMode(pot_pin,INPUT);
}

void loop() {
    pot_diodes();
}

void pot_diodes(){
  int pot_reading = analogRead(pot_pin)/4;
  analogWrite(LED_green_pin, pot_reading);  
  analogWrite(LED_red_pin, 255 - pot_reading);  

}
