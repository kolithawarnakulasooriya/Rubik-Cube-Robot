

#include <Stepper.h>

const int stepsPerRevolution = 200;  // change this to fit the number of steps per revolution
// for your motor

// initialize the stepper library on pins 8 through 11:
//Stepper myStepper(stepsPerRevolution, 30, 31, 32, 33);

void setup() {
  // set the speed at 60 rpm:
  //myStepper.setSpeed(5);
  // initialize the serial port:
  Serial.begin(9600);

  pinMode(52,OUTPUT);
  pinMode(53,OUTPUT);
  digitalWrite(52,LOW);
  digitalWrite(53,LOW);
  
  pinMode(34,OUTPUT);
  pinMode(35,OUTPUT);
  pinMode(36,OUTPUT);
  pinMode(37,OUTPUT);
}

void loop() {
  stepperrun1();
}
void stepperrun1(){
  digitalWrite(34,HIGH);
  digitalWrite(35,LOW);
  digitalWrite(36,LOW);
  digitalWrite(37,LOW);
  
  delay(10);
  
  digitalWrite(34,LOW);
  digitalWrite(35,HIGH);
  digitalWrite(36,LOW);
  digitalWrite(37,LOW);
  
  delay(10);
  
  digitalWrite(34,LOW);
  digitalWrite(35,LOW);
  digitalWrite(36,HIGH);
  digitalWrite(37,LOW);
  
  delay(10);
  
  digitalWrite(34,LOW);
  digitalWrite(35,LOW);
  digitalWrite(36,LOW);
  digitalWrite(37,HIGH);
  
  delay(10);
  
}

