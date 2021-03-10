#include <SoftwareSerial.h> 

SoftwareSerial mySerial(2, 3);
char txrxbuffer[255];

char get_readID[] = { 0xAA , 0x00, 0x03, 0x25, 0x26, 0x00, 0x00, 0xBB };
void setup()
{
Serial.begin(57600);
Serial.println("Hit Enter to read the RFID number");
mySerial.begin(9600);
}

void loop() // run over and over
{ 

int counter = 0;
if (mySerial.available())
  Serial.print(mySerial.read(),HEX);
  

if (Serial.available()){
    Serial.read();
    Serial.println(">");
    for (counter =0 ; counter < 8 ; counter++){
      mySerial.write(get_readID[counter]);
    }
}
}
