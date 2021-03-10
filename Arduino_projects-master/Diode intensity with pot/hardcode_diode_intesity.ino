int LED_red_pin = 5;
int LED_green_pin = 6;

void intensity_diode();

void setup() {
  Serial.begin(9600);
  pinMode(LED_red_pin,OUTPUT);
  pinMode(LED_green_pin,OUTPUT);
  pinMode(button_pin,INPUT);
  pinMode(pot_pin,INPUT);
}


void loop() {
   security_button();

}


void intensity_diode(){

  analogWrite(LED_green_pin, intensity_max);  
  delay(1000);
     
  analogWrite(LED_green_pin, intensity_max/2);  
  delay(1000);
  
  analogWrite(LED_green_pin, 0);  
  delay(1000);

}
