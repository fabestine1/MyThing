int pins[5] = {2, 3, 4, 5, 6};//array of the number of pins we will be using
bool shape[5][5] = {{0, 0, 0, 0, 0},{0, 1, 0, 0, 0},{0, 0, 0, 0, 0},{0, 0, 0, 0, 0},{0, 0, 0, 0, 0}}; // 1 - the ones we want to light up

int pinCount = 5;

void setup() {
  // setup all pins as input
  for(int i = 0 ; i < pinCount ; i ++) pinMode(pins[i], INPUT);
}

void loop() {
  for(int row = 0 ; row < pinCount ; row++)
    for(int column = 0 ; column < pinCount ; column++){
        if(shape[row][column] == true && row != column){
          //setup pins as OUTPUT
          pinMode(pins[row], OUTPUT);
          pinMode(pins[column], OUTPUT); 
          
          //we want diode (row;column) to light up -> row -> 1, column -> 0
          digitalWrite(pins[row], HIGH);
          digitalWrite(pins[column], LOW);
          
          //pins back to input
          // the change input-output -> no parasite diode
          // when in INPUT - big R => I is almost 0 => can't light up a diode
          pinMode(pins[row], INPUT);
          pinMode(pins[column], INPUT);

        }
    }
  
}
