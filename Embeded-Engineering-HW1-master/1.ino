int num_of_pins = 5;

int pins[num_of_pins*2] = {2, 3, 4, 5, 6, 7, 8, 9, 10, 11}; //pins that we'll be using
// shape - bool array which diodes we want to light up(1 - lights up,0 - nope)
bool shape[num_of_pins][num_of_pins] = {{0, 0, 0, 0, 0}, {0, 0, 0, 0, 0},{0, 0, 0, 0, 0},{0, 1, 0, 0, 0},{0, 0, 0, 0, 0}};

void setup() {
  // make arduino know the pins will be used as OUTPUT - will be high or low
  for(int i = 0 ; i < 10;++i) pinMode(pins[i], OUTPUT);
}

void loop() {
  for(int row = 0 ; row < num_of_pins ; row++){
    digitalWrite(pins[row], HIGH);//anode - 1 for all rows
    for(int column = 0 ; column < num_of_pins ; column++){      
      if(shape[row][column] == true) digitalWrite(pins[num_of_pins + column], LOW); //has to light up => anode - 1, catode -0
      else digitalWrite(pins[num_of_pins + column], HIGH); // catode - 1 => no I
    }
    for(int columm = 0 ; column < num_of_pins ; column ++) digitalWrite(pins[num_of_pins + j], HIGH); // return all colomns to 1
    digitalWrite(pins[i], LOW); // return state to 0
  }
}
