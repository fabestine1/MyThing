#include <Servo.h> 
 
int servoPin = 13;
Servo servo;  

int angle = 0;   
 
void setup() 
{ 
  servo.attach(servoPin); 
} 
 
 
void loop() 
{ 
  //moves servo to the 180dg position infinitive times
  for(; ; )  
  {                                  
    servo.write(angle);      
    if(angle<180) angle++;  //turn 180 degrees
    else angle-= 180; //back to inital position    
    delay(15);     
  } 

} 
