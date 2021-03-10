int LED_red_pin = 5;
int LED_green_pin = 6;
int button_pin = 9;
int pot_pin = 0;
int system_button_pin = 2;
int intensity_max = 255; 
 bool system_on = false;

void security_button();

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

void security_button(){

 int buttonState = digitalRead(button_pin);
 
 if(buttonState){
   
     if(system_on)
            system_on = false;
     else 
            system_on = true;  
            
 }
 
 if(system_on) 
        analogWrite(LED_green_pin,intensity_max);
 else
      analogWrite(LED_green_pin, 0);
 
 
 if(buttonState)
      delay(500);
 }
 
 
