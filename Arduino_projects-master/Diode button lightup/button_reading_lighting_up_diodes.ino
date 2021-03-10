int LED_red_pin = 5;
int LED_green_pin = 6;
int button_pin = 9;

void button_reading_diodes_lighting();


void setup() {
  Serial.begin(9600);
  pinMode(LED_red_pin,OUTPUT);
  pinMode(LED_green_pin,OUTPUT);
  pinMode(button_pin,INPUT);
  pinMode(pot_pin,INPUT);
}


void loop() {
   button_reading_diodes_lighting();

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
