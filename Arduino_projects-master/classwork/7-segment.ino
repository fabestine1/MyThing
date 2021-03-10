int a = 1;
int b = 2;
int c = 3;
int d = 4;
int e = 5;
int f = 6;
int g = 7;
int dot = 8;


void setup() {
  // put your setup code here, to run once:
  pinMode(a,OUTPUT);
  pinMode(b,OUTPUT);
  pinMode(c,OUTPUT);
  pinMode(d,OUTPUT);
  pinMode(e,OUTPUT);
  pinMode(f,OUTPUT);
  pinMode(g,OUTPUT);
  pinMode(dot,OUTPUT);
  pinMode(9,OUTPUT); // first one
  pinMode(10,OUTPUT); //second one
}

void loop() {
  // put your main code here, to run repeatedly:
  all();
  //digitalWrite(9,LOW);
  //digitalWrite(a,LOW);
  //digitalWrite(10,LOW);
  //digitalWrite(a,LOW);
  delay(5000);
  all();
  delay(10000);
  //digitalWrite(b,HIGH);

}


void nulling(){
    digitalWrite(a,LOW);
    digitalWrite(b,LOW);
    digitalWrite(c,LOW);
    digitalWrite(d,LOW);
    digitalWrite(e,LOW);
    digitalWrite(f,LOW);
    digitalWrite(g,LOW);
    digitalWrite(dot,LOW);

}

void all(){
    digitalWrite(a,HIGH);
    digitalWrite(b,HIGH);
    digitalWrite(c,HIGH);
    digitalWrite(d,HIGH);
    digitalWrite(e,HIGH);
    digitalWrite(f,HIGH);
    digitalWrite(g,HIGH);
    digitalWrite(dot,HIGH);

}
