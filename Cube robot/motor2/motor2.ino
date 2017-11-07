#include <Stepper.h>

const int Motor3Rev = 53;
const int Motor2Rev = 53;
const int Motor1Rev = 53;
const int Motor4Rev = 53;

Stepper stepperMotor4(Motor4Rev, 26, 27, 28, 29);
Stepper stepperMotor3(Motor3Rev, 30, 31, 32, 33);
Stepper stepperMotor2(Motor2Rev, 34, 35, 36, 37);
Stepper stepperMotor1(Motor1Rev, 38, 39, 40, 41);

void setup() {
  
  stepperMotor1.setSpeed(200);
  pinMode(48,OUTPUT);
  pinMode(49,OUTPUT);
  stepperMotor2.setSpeed(200);
  pinMode(52,OUTPUT);
  pinMode(53,OUTPUT);
  stepperMotor3.setSpeed(200);
  pinMode(51,OUTPUT);
  pinMode(50,OUTPUT);
  stepperMotor4.setSpeed(200);
  pinMode(46,OUTPUT);
  pinMode(47,OUTPUT);
  Serial.begin(9600);
  
  digitalWrite(50,LOW);
  digitalWrite(51,LOW);
  digitalWrite(52,LOW);
  digitalWrite(53,LOW);
  digitalWrite(48,LOW);
  digitalWrite(49,LOW);
  digitalWrite(46,LOW);
  digitalWrite(47,LOW);
}

void loop() {

  digitalWrite(46,LOW);
  digitalWrite(47,LOW);
  digitalWrite(48,LOW);
  digitalWrite(49,LOW);
  digitalWrite(52,LOW);
  digitalWrite(53,LOW);
  digitalWrite(50,HIGH);
  digitalWrite(51,HIGH);
  // step one revolution  in one direction:
  Serial.println("clockwise");
  stepperMotor3.step(Motor3Rev);
  delay(500);

  // step one revolution in the other direction:
  Serial.println("counterclockwise");
  stepperMotor3.step(-Motor3Rev);
  delay(500);
  
  digitalWrite(46,LOW);
  digitalWrite(47,LOW);
  digitalWrite(48,LOW);
  digitalWrite(49,LOW);
  digitalWrite(52,HIGH);
  digitalWrite(53,HIGH);
  digitalWrite(50,LOW);
  digitalWrite(51,LOW);
  
  //  // step one revolution  in one direction:
  Serial.println("clockwise");
  stepperMotor2.step(Motor2Rev);
  delay(500);

  // step one revolution in the other direction:
  Serial.println("counterclockwise");
  stepperMotor2.step(-Motor2Rev);
  delay(500);
  
  digitalWrite(46,LOW);
  digitalWrite(47,LOW);
  digitalWrite(48,HIGH);
  digitalWrite(49,HIGH);
  digitalWrite(52,LOW);
  digitalWrite(53,LOW);
  digitalWrite(50,LOW);
  digitalWrite(51,LOW);
  
  // step one revolution  in one direction:
  Serial.println("clockwise");
  stepperMotor1.step(Motor1Rev);
  delay(500);

  // step one revolution in the other direction:
  Serial.println("counterclockwise");
  stepperMotor1.step(-Motor1Rev);
  delay(500);
  
  digitalWrite(46,HIGH);
  digitalWrite(47,HIGH);
  digitalWrite(48,LOW);
  digitalWrite(49,LOW);
  digitalWrite(52,LOW);
  digitalWrite(53,LOW);
  digitalWrite(50,LOW);
  digitalWrite(51,LOW);
  
  // step one revolution  in one direction:
  Serial.println("clockwise");
  stepperMotor4.step(Motor4Rev);
  delay(500);

  // step one revolution in the other direction:
  Serial.println("counterclockwise");
  stepperMotor4.step(-Motor4Rev);
  delay(500);
  
  
}

