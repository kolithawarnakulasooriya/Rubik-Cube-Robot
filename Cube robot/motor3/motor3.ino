#include <Stepper.h>

const int Motor3Rev = 54;
const int Motor2Rev = 54;

Stepper stepperMotor3(Motor3Rev, 30, 31, 32, 33);
Stepper stepperMotor2(Motor2Rev, 34, 35, 36, 37);

void setup() {
  
  stepperMotor3.setSpeed(200);
  
  Serial.begin(9600);
}

void loop() {
  // step one revolution  in one direction:
  Serial.println("clockwise");
  stepperMotor2.step(Motor2Rev);
  delay(500);

  // step one revolution in the other direction:
  Serial.println("counterclockwise");
  stepperMotor2.step(-Motor2Rev);
  delay(500);
}

