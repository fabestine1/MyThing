#define MAX_COMMANDS 15
#define MAX_PARAM 7

int registered_commands = 0;

void(*CommandList[MAX_COMMANDS])(ComData comdata);
void AddCommand(void(*CommandFunction)(ComData comdata))
{
  CommandList[registered_commands] = CommandFunction;
  registered_commands++;
}

void processCommands(ComData &comdata)
{
  if (comdata.GetType(0) == _Int && comdata.GetType(1) == _Int && comdata.GetType(2) == _Int)
  {
    //setup variables
    unsigned int commandID;

    //get first parameter {parameter 1, parameter 2, parameter n..}
    comdata.Get(2, commandID);

    //check if commandID is within range of registered commands
    if (commandID >= registered_commands || commandID == 0)
    {
      ComData returnprint;

      returnprint.Set(0, serverID);
      returnprint.Set(1, senderID);
      returnprint.Set(2, 1);//ERROR found
      returnprint.Set(3, "Invalid ID supplied");

      printComData(returnprint);
      return;
    }
    if (CommandList[commandID] != COMMAND_NULL)
    {
      CommandList[commandID](comdata);
    }
  }
}

void COMMAND_NULL(ComData comdata)
{

}

void printComData(ComData &comdata)
{
  String comdataExport;

  comdataExport = "";

  for (unsigned int i = 0; i < MAX_PARAMS_COMDATA; i++)
  {
    int type = comdata.GetType(i);

    if (type == _Undefined)
    {
      break;//stop loop
    }

    String value;

    comdata.Get(i, value);

    switch (type)
    {
      case _String:
        {
          value.replace("\"", "\\\"");
          comdataExport += "\"" + value + "\",";
          break;
        }
      case _Int:
        {
          comdataExport += "" + value + ",";
          break;
        }
      case _Char:
        {
          comdataExport += value + ",";
          break;
        }
      case _Double:
        {
          comdataExport += value + ",";
          break;
        }
      default:
        {
          comdataExport += "Unknown,";
          break;
        }
    }
  }

  if (comdataExport.length() > 0)
  {
    comdataExport = comdataExport.substring(0, comdataExport.length() - 1);
  }

  Serial.print("{" + comdataExport + "}");
}
