#define OPEN 150
#define CLOSED 90

/*
//<SUMMARY>
//This function is used to control the servos; these are pre-defined in the servoList
//Receiving either 0 or 1 as the 'state' parameter, the servo is set to either the OPEN or CLOSED state.
*/
void MoveServo(int servoID, int state)
{
  if (servoID < SERVOARRAYSIZE)
  {
    if (state == 1)
    {
      servos[servoID].write(OPEN);
    }
    else if (state == 0)
    {
      servos[servoID].write(CLOSED);
    }
  }
}
