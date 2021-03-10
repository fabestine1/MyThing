const int buttonPin = 2; 

int buttonState = 0;      
int state=1;
int count=0;
void setup() {
  pinMode(buttonPin, INPUT_PULLUP);
  Serial.begin(9600);

}

void loop() {
  buttonState = digitalRead(buttonPin);

  if (buttonState == LOW ) {
    if(state==1){
      state = 0;
      count++;
      Serial.print("PUSHED: ");
      Serial.println(count);
    }
  } else {
    // turn LED off:
    state=1;
  }
  

}
