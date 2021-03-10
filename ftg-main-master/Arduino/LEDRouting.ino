/*
//<SUMMARY>
//SetLed is the command which controls the LED-Strip.
//It automatically parses to the next led strip if the incoming ID surpases the first strip.
*/
void SetLed(int ledID, int red, int green, int blue)
{
  if (ledID > -1)
  {
    if (ledID > (STRIP0PIXELS-1))
    {
      ledID -= STRIP0PIXELS;
      strip1.setPixelColor(ledID, red, green, blue);
      strip1.show();
    }
    else
    {
      strip0.setPixelColor(ledID, red, green, blue);
      strip0.show();
    }
  }
  else if (ledID == -1)
  {
    for (int i = 0; i < STRIP0PIXELS; i++)
    {
      strip0.setPixelColor(i, red, green, blue);
    }
    for (int i = 14; i < STRIP1PIXELS; i++)
    {
      strip1.setPixelColor(i, red, green, blue);
    }
    strip0.show();
    strip1.show();
  }
  else if (ledID == -2)
  {
    for (int i = 0; i < 14; i++)
    {
      strip1.setPixelColor(i, red, green, blue);
    }
    strip1.show();
  }    
}
