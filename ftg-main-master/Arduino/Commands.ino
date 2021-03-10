void SetupCommands() //List of all commands in the Arduino IO.
{
  AddCommand(ERRORCOMMAND);//0  INVALID command indentifier
  Serial.println("Command ERROCOMMAND(0) Initialized.");
  AddCommand(ERRORFOUND);//1
  Serial.println("Command ERRORFOUND(1) Initialized.");
  AddCommand(HANDSHAKE);//2
  Serial.println("Command HANDSHAKE(2) Initialized.");
  AddCommand(DEBUGTEXT);//3
  Serial.println("Command DEBUGTEXT(3) Initialized.");
  AddCommand(COMMAND_NULL);//4 - SEND NFC tag
  Serial.println("Command COMMAND_NULL(4) Initialized.");
  AddCommand(SETRGB);//5
  Serial.println("Command SETRGB(5) Initialized.");
  AddCommand(DOCHIPSCAN);//6
  Serial.println("Command DOCHIPSCAN(6) Initialized.");
  AddCommand(READSENSOR); //7
  Serial.println("Command READSENSOR(7) Initialized.");
  AddCommand(MOVEGATE); //8
  Serial.println("Command MOVESERVO(9) Initialized.");
  AddCommand(SETLED); //9
  Serial.println("Command SETLED(10) Initialized.");
}

/*<summary>
///  TEST command returns the senderID that has been given by the garage management server

//  PARAMETERS:
    0: SENDERID - The original sender of the message that has been received
    1: GIVENID  - The ID the garage management server assigned this arduino
    2: CommandID - the ID that is associated to a command given in SetupCommands

</summary>*/
void ERRORCOMMAND(ComData comdata) //Return invalid command
{
}

void HANDSHAKE(ComData comdata)
{
  //check parameters
  if (comdata.GetType(3) == _Int) //check whether serverID is set
  {
    int expectedserver;
    comdata.Get(3, expectedserver);

    if (expectedserver > 0)
    {
      serverID = expectedserver;
    }
  }
  if (comdata.GetType(4) == _Int) //check whether arduino own ID is set
  {
    int expectedOwnID;
    comdata.Get(4, expectedOwnID);

    if (expectedOwnID > 0)
    {
      senderID = expectedOwnID;
    }
  }
}

void DEBUGTEXT(ComData comdata) //Returns the same incoming data
{
  printComData(comdata);
}

//This function is used internally, no need to add it to command handler
void RETURNNFCTAG(String UID)
{
  if (UID.length() > 0)
  {
    ComData comdata;

    comdata.Set(0, serverID);
    comdata.Set(1, senderID);
    comdata.Set(2, 4);//NFC send tag command ID
    comdata.Set(3, UID);

    printComData(comdata);
  }
}

/*<summary>
// ERRORFOUND is a command that will be triggered when an error occured on an external device (computer or other microcontroller)

//  PARAMETERS:
    1: error ID
    2: error Message

//</summary>*/
void ERRORFOUND(ComData comdata)
{
}

void DOCHIPSCAN(ComData comdata)
{
  doChipScan = true;
}

void SETRGB(ComData comdata)
{
  //check parameters
  if (comdata.GetType(3) != _Int) //RGB ID
  {
    Serial.print("Invalid type");
    return;//invalid parameter 1
  }

  int R = 0;
  int G = 0;
  int B = 0;

  int PINNUMBER;

  if (comdata.GetType(4) == _Int) //R
  {
    comdata.Get(4, R);//get parameter 2
    R = abs(R);
    if (R > 255)R = 255;
  }
  if (comdata.GetType(5) == _Int) //G
  {
    comdata.Get(5, G);//get parameter 2
    G = abs(G);
    if (G > 255)G = 255;
  }
  if (comdata.GetType(6) == _Int)
  {
    comdata.Get(6, B);//Get parameter 2
    B = abs(B);
    if (B > 255)B = 255;
  }

  comdata.Get(3, PINNUMBER);//Get parameter 1

  PINNUMBER++;
}

void READSENSOR(ComData comdata) //Returns sensor, which have been initialized in the sensorList, values.
{
  int sensorID;
  int sensorValue;
  comdata.Get(3, sensorID);

  sensorValue = SensorList[sensorID].Read();

  comdata.Set(0, serverID);
  comdata.Set(1, senderID);
  comdata.Set(2, 7); //Command ID for ReadSensor
  comdata.Set(3, sensorID);
  comdata.Set(4, sensorValue);
  printComData(comdata);
}

void MOVEGATE(ComData comdata)
{
  int servoID;
  int state;

  comdata.Get(3, servoID);
  comdata.Get(4, state);  //Either 0 or 1

  MoveServo(servoID, state);
}

//This is different from SETRGB. This is used to control the LED-Strip!
void SETLED(ComData comdata)
{
  int ledID;
  int red, green, blue;
  
  comdata.Get(3, ledID);
  comdata.Get(4, red);
  comdata.Get(5, green);
  comdata.Get(6, blue);
  
  SetLed(ledID, red, green, blue);
}
