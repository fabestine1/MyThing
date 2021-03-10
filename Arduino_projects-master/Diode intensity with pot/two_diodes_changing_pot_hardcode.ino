int LED_red_pin = 5;
int LED_green_pin = 6;
int button_pin = 9;
int pot_pin = 0;

void diodes_changing();


void setup() {
  Serial.begin(9600);
  pinMode(LED_red_pin,OUTPUT);
  pinMode(LED_green_pin,OUTPUT);
  pinMode(pot_pin,INPUT);
}


void loop() {
  diodes_changing();
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

