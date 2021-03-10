#include <LiquidCrystal.h>

// select the pins used on the LCD panel
LiquidCrystal lcd(8, 9, 4, 5, 6, 7);

// define some values used by the panel and buttons
int lcd_key     = 0;
int adc_key_in  = 0;
#define btnRIGHT  0
#define btnUP     1
#define btnDOWN   2
#define btnLEFT   3
#define btnSELECT 4
#define btnNONE   5

int player1 = 0 , player2 = 0;
// read the buttons
int read_LCD_buttons()
{
  adc_key_in = analogRead(0);
  if (adc_key_in > 1000) return btnNONE; // We make this the 1st option for speed reasons since it will be the most likely result
  // For V1.1 us this threshold
  if (adc_key_in < 50)   return btnRIGHT;
  if (adc_key_in < 250)  return btnUP;
  if (adc_key_in < 450)  return btnDOWN;
  if (adc_key_in < 650)  return btnLEFT;
  if (adc_key_in < 850)  return btnSELECT;
  return btnNONE;
}

void setup()
{
  lcd.begin(16, 2);              // start the library
  lcd.setCursor(0, 0);
  lcd.print("Taekwon-Do  "); // print a simple message
  lcd.setCursor(0, 2);
  lcd.print("Score: ");
}

void loop()
{


  lcd.setCursor(7, 2);           // move to the begining of the second line
  lcd_key = read_LCD_buttons();  // read the buttons
  lcd.print(player1);
  lcd.setCursor(10, 2);
  lcd.print("vs");
  lcd.setCursor(14, 2);
  lcd.print(player2);
  switch (lcd_key)               // depending on which button was pushed, we perform an action
  {
    case btnRIGHT:
      {
        //RIGHT
        player1++;
        delay(300);
        break;


      }
    case btnLEFT:
      {
        //LEFT
        player1--;
        delay(300);
        break;;
      }
    case btnUP:
      {
        //UP
        player2++;
        delay(300);
        break;
      }
    case btnDOWN:
      {
        //DOWN
        player2--;
        delay(300);
        break;
      }

  }

}
