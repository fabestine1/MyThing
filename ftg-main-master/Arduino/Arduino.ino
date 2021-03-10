#include <Adafruit_NeoPixel.h>
#include <Servo.h>
#include <RGBTools.h>
#include <SensorTool.h>
#include <ComData.h>
#include <StringEater.h>
#include <DataInterpretor.h>
#include <SPI.h>
#include "PN532_SPI.h"
#include "PN532.h"
#include "NfcAdapter.h"

#define STRIP0PIXELS      56
#define STRIP1PIXELS      18
#define STRIP0PIN          6
#define STRIP1PIN          5
#define SERVOARRAYSIZE     2

PN532_SPI interface(SPI, 10);
NfcAdapter nfc = NfcAdapter(interface);
DataInterpretor DataManager;

Adafruit_NeoPixel strip0 = Adafruit_NeoPixel(STRIP0PIXELS, STRIP0PIN, NEO_GRB + NEO_KHZ800);
Adafruit_NeoPixel strip1 = Adafruit_NeoPixel(STRIP1PIXELS, STRIP1PIN, NEO_GRB + NEO_KHZ800);

const String DeviceName = "Garage IO";
int senderID = -1;
int serverID = -1;
bool doChipScan = false;

void AddCommand(void(*CommandFunction)(ComData comdata));


enum comdatatypes
{
  _Undefined,//0
  _String,//1
  _Int,//2
  _UInt,//3
  _Float,//4
  _Long,//5
  _ULong,//6
  _Double,//7
  _LDouble,//8
  _Char,//9
  _UChar,//10
  _bool,//11  NOTE: _Bool cannot be used because it is used as reserved keyword..
  _ComData//12
};

Sensor SensorList[] =
{
  Sensor(A0, Analog)
};

Servo servos[SERVOARRAYSIZE];

void setup()
{
  Serial.begin(19200);

  SetupCommands();

  servos[0].attach(9);
  servos[1].attach(10);

  strip0.begin();
  strip0.show();

  strip1.begin();
  for (int i = 0; i < STRIP1PIXELS - 4; i++)
  {
    strip1.setPixelColor(i, 0, 255, 0);
  }
  strip1.show();

  nfc.begin();

  pinMode(11, OUTPUT);
}

void loop() //MAIN LOOP
{
  GetSerialInput();
  ReadNfcUid();

  analogWrite(11, 255);
}

void GetSerialInput()
{
  if (Serial.available())
  {
    char inputbyte = (char)Serial.read();

    DataManager.addChar(inputbyte);

    if (DataManager.usableInput)
    {
      ///<summary>
      //	DataManager interprets the inputbytes and buffers them.
      //      They will be read as data parameters [numbers, strings, parameters].

      // All interpreted data is placed in ComData Object
      // Each parameter can be addressed by its own index
      // I.E.
      //{0, "parameter 2", "parameter 3", "parameter 4"}
      //returns comdata object:
      /*
      	comdata = {
      		index 0:   5 (int)
      		index 1:	"parameter 2" (string)
      		index 2:	"parameter 3" (string)
      		index 3:	"parameter 4" (string)
      	}

      	comdata parameters can be addressed by supplying a variable as reference for type and index number

      	string parameter_2 = "";

      	comdata.Get(1, parameter_2);

      	//parameter_2 = "parameter 2";


      	string parameter_1 = "";
      	comdata.Get(1, parameter_1);
      	//parameter_1 = "5";

      	int parameter_1 = 0;
      	comdata.Get(1, parameter_1);
      	//parameter_1 = 5;

      	*/
      ///</summary>
      ComData params = DataManager.getComData();
      processCommands(params);
    }
  }
}

