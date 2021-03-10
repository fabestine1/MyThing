#define POTMETER_PIN 1
#define LDR_PIN 0
#define LED_PIN 3
#define HYSTERSIS 100

int potmeter;


void setup()
{

	pinMode(LED_PIN, OUTPUT);
	pinMode(POTMETER_PIN, INPUT);
	pinMode(LDR_PIN, INPUT);

  /* add setup code here */

	Serial.begin(9600);
	Serial.write("Communication started\n");
}

void loop()
{
	static int potmeter_previousValue;
	static int LDR_previousValue;

	int potmeter_Value = analogRead(POTMETER_PIN);
	int LDR_Value = analogRead(LDR_PIN);
	
	//calculate update
	if (abs(potmeter_Value-potmeter_previousValue)>17)
	{
		Serial.write("potmeter verandering (");
		
		char waarde[33];

		itoa(potmeter_Value, waarde, 10);

		Serial.write(waarde);
		Serial.write(")!\n");

		potmeter_previousValue = potmeter_Value;

                onPotmeterUpdate(potmeter_Value);
	}

	//calculate update
	if (abs(LDR_Value-LDR_previousValue)>10)
	{
		Serial.write("LDR verandering (");
		char waarde[33];

		itoa(LDR_Value, waarde, 10);

		Serial.write(waarde);
		Serial.write(")!\n");

		LDR_previousValue = LDR_Value;

                onLDRUpdate(LDR_Value);
	}
}

void onPotmeterUpdate(int value)
{
    potmeter = value;
}

void onLDRUpdate(int value)
{
    if(value> potmeter)
    {
  
      analogWrite(LED_PIN, 700);
    }
    else if(value + HYSTERSIS < potmeter)
    {
      analogWrite(LED_PIN, 0);
    }
}
