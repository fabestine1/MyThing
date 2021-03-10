/* Read Jostick
  * ------------
  *
  * Reads two analog pins that are supposed to be
  * connected to a jostick made of two potentiometers
  *
  * We send three bytes back to the comp: one header and two
  * with data as signed bytes, this will take the form:
  *     Jxy\r\n
  *
  * x and y are integers and sent in ASCII 
  * 
  * http://www.0j0.org | http://arduino.berlios.de
  * copyleft 2005 DojoDave for DojoCorp
  */

 int ledPin = 13;
 int joyPin1 = A0;                 // slider variable connecetd to analog pin 0
 int joyPin2 = A1;                 // slider variable connecetd to analog pin 1
 int value1 = 0;                  // variable to read the value from the analog pin 0
 int value2 = 0;                  // variable to read the value from the analog pin 1

 void setup() {
  pinMode(ledPin, OUTPUT);              // initializes digital pins 0 to 7 as outputs
  Serial.begin(9600);
  Serial.print("STARTED");
 }

 int treatValue(int data) {
  return (data * 9 / 1024) + 48;
 }

 void loop() {
  
   delay(100);
   
   // reads the value of the variable resistor 
  value1 = (analogRead(joyPin1)-500);   
  // this small pause is needed between reading
  // analog pins, otherwise we get the same value twice
            
  // reads the value of the variable resistor 
  value2 = (analogRead(joyPin2)-500);   
  
  Serial.print(value1);
  Serial.print(",");
  Serial.println(value2);
  
  int x = distance_between_points(value1, value2, 0, 513);
  
  
  //x
  

  //angleInDegrees = arctan(deltaY / deltaX) * 180 / PI
  
 }
 
int distance_between_points(x1,y1,x2,y2)
{
   return 0; 
}
