int LED_red_pin = 5;
int LED_green_pin = 6;
int button_pin = 9;
int pot_pin = 0;
int system_button_pin = 2;
int intensity_max = 255; 
 bool system_on = false;

void diode_lightup();
void diode_ping();
void switch_diodes();
void switch_diodes_seconds();
void button_reading_diodes_lighting();
void intensity_diode();
void pot_diod();
void pot_diodes();
void diodes_changing();
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


void diode_lightup(){

  Serial.print("On\n");
  digitalWrite(LED_red_pin, HIGH);   
  delay(10);
  
  Serial.println("Off");
  digitalWrite(LED_red_pin, LOW);
  delay(10);

}


void diode_ping(){
  
  Serial.print("On\n");
  digitalWrite(LED_red_pin, HIGH);   
  delay(1000);
  
  Serial.println("Off");
  digitalWrite(LED_red_pin, LOW);
  delay(1000);
  
}


void switch_diodes(){

  digitalWrite(LED_red_pin, HIGH);   
  digitalWrite(LED_green_pin, HIGH);   
  delay(1000);
  
  digitalWrite(LED_green_pin, HIGH);   
  digitalWrite(LED_red_pin, HIGH);  
  delay(1000);
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


void button_reading_diodes_lighting(){
    if(digitalRead(button_pin) == HIGH){
        //button clicked
        digitalWrite(LED_red_pin, HIGH); 
        digitalWrite(LED_green_pin, HIGH);   
    }
    else {
          //not clicked
          digitalWrite(LED_red_pin, LOW); 
          digitalWrite(LED_green_pin, LOW);   
    }

}


void intensity_diode(){

  analogWrite(LED_green_pin, intensity_max);  
  delay(1000);
     
  analogWrite(LED_green_pin, intensity_max/2);  
  delay(1000);
  
  analogWrite(LED_green_pin, 0);  
  delay(1000);

}


void pot_diod(){
  
  if(analogRead(pot_pin)>600){
      analogWrite(LED_green_pin, intensity_max);  
  }else if(analogRead(pot_pin)>200) {
      analogWrite(LED_green_pin, intensity_max/2);  
  }else{ 
      analogWrite(LED_green_pin, 0);  
  }
}


void diodes_changing(){
  
  if(analogRead(pot_pin)>600){
      analogWrite(LED_green_pin, intensity_max);  
      analogWrite(LED_red_pin, 0);  
  }else if(analogRead(pot_pin)>200) {
      analogWrite(LED_green_pin, intensity_max/2);  
      analogWrite(LED_red_pin, intensity_max/2);  
  }else{ 
      analogWrite(LED_red_pin, intensity_max);   
      analogWrite(LED_green_pin, 0);  
  }
  
}


void pot_diodes(){
  int pot_reading = analogRead(pot_pin)/4;
  analogWrite(LED_green_pin, pot_reading);  
  analogWrite(LED_red_pin, 255 - pot_reading);  

}


void security_button(){
 int buttonState = digitalRead(button_pin);
 if(buttonState){
   if(system_on)system_on = false;
   else system_on = true;  
 }
 if(system_on) analogWrite(LED_green_pin, 255);
 else analogWrite(LED_green_pin, 0);
 if(buttonState)delay(500);
 }
 
 
