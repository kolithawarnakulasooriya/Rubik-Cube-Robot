#include <Stepper.h>
#include <Servo.h> 

#define MOTOR_LEFT 0
#define MOTOR_RIGHT 1

#define TOUCH 0
#define RELEASE 1

#define DELAY_FUNC 1000

const int Motor3Rev = 53;
const int Motor2Rev = 50;
const int Motor1Rev = 53;
const int Motor4Rev = 50;
const int Motordua24Rev=53;
const int Motordua13Rev=50;

Stepper stepperMotor4(200, 26, 27, 28, 29);
Stepper stepperMotor3(200, 30, 31, 32, 33);
Stepper stepperMotor2(200, 34, 35, 36, 37);
Stepper stepperMotor1(200, 38, 39, 40, 41);

Servo servoMotor1;
Servo servoMotor2;
Servo servoMotor3;
Servo servoMotor4;

char seq[256];

void setup() {
  
  stepperMotor1.setSpeed(60);//200
  pinMode(48,OUTPUT);
  pinMode(49,OUTPUT);
  stepperMotor2.setSpeed(60);
  pinMode(52,OUTPUT);
  pinMode(53,OUTPUT);
  stepperMotor3.setSpeed(60);
  pinMode(51,OUTPUT);
  pinMode(50,OUTPUT);
  stepperMotor4.setSpeed(60);
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
  
  servoMotor1.attach(2);
  //servoMotor1.write(0);
  servoMotor2.attach(3);
  //servoMotor2.write(0);
  servoMotor3.attach(4);
  //servoMotor3.write(0);
  servoMotor4.attach(5);
  //servoMotor4.write(0);


  
  // relase motor
  motorRelease();
  delay(1000);
  motorTouch();
  delay(1000);

  
}

void loop() {

  Serial.println("Start :");
  while(1){
    if(Serial.available()){
    int y = Serial.read(); 
    if(y=='I'){
      initCube();
      break;  
    } 
    if(y=='D'){
      break;  
    }
    }  
  }

 int k=0;
 Serial.println("Done");
 
 while(1){
  if(Serial.available()){
    char c= Serial.read();
    if(c=='A')
      break;
    seq[k++]= c;
    
  }
 }

 Serial.println(" Sequence : ");
 Serial.println(seq);
 Serial.println("\n");
 //solve
 solveCube();


}

void solveCube(){
  for(int i=0;i<256;i++){
      rotateCube(seq[i]);
      Serial.println(seq[i]);
//       while(1){
//        if(Serial.available()){
//          char c= Serial.read();
//          if(c=='D')
//            break;
//        }
//       }
       delay(2000);
  }  
  // finish
  motorRelease();
}

void rotateCube(char ch){
  switch(ch){
        case 'F': FMove(); break;
        case 'f': FiMove(); break;
        case 'B': BMove(); break;
        case 'b': BiMove(); break;
        case 'R': RMove(); break;
        case 'r': RiMove(); break;
        case 'L': LMove(); break;
        case 'l': LiMove(); break;   
        case 'U': UMove(); break;
        case 'u': UiMove(); break;
        case 'D': DMove(); break;
        case 'd': DiMove(); break; 
  }
  Serial.println(ch);
}

void motorRelease(){
  servoMotor(1,RELEASE);
  servoMotor(2,RELEASE);
  servoMotor(3,RELEASE);
  servoMotor(4,RELEASE);
}

void motorTouch(){
  servoMotor(1,TOUCH);
  servoMotor(3,TOUCH);
  delay(3000);
  servoMotor(2,TOUCH);
  servoMotor(4,TOUCH);
}

void FMove(){
    // close motor
    servoMotor(1,TOUCH);
    StepperDrive(1,MOTOR_RIGHT);
    servoMotor(1,RELEASE);
    StepperDrive(1,MOTOR_LEFT);
    servoMotor(1,TOUCH);
}

void FiMove(){
    // close motor
    servoMotor(1,TOUCH);
    StepperDrive(1,MOTOR_LEFT);
    servoMotor(1,RELEASE);
    StepperDrive(1,MOTOR_RIGHT);
    servoMotor(1,TOUCH);
}

void LMove(){
    // close motor
    servoMotor(2,TOUCH);
    StepperDrive(2,MOTOR_RIGHT);
    servoMotor(2,RELEASE);
    StepperDrive(2,MOTOR_LEFT);
    servoMotor(2,TOUCH);
}

void LiMove(){
    // close motor
    servoMotor(2,TOUCH);
    StepperDrive(2,MOTOR_LEFT);
    servoMotor(2,RELEASE);
    StepperDrive(2,MOTOR_RIGHT);
    servoMotor(2,TOUCH);
}

void BMove(){
    // close motor
    servoMotor(3,TOUCH);
    StepperDrive(3,MOTOR_RIGHT);
    servoMotor(3,RELEASE);
    StepperDrive(3,MOTOR_LEFT);
    servoMotor(3,TOUCH);
}

void BiMove(){
    // close motor
    servoMotor(3,TOUCH);
    StepperDrive(3,MOTOR_LEFT);
    servoMotor(3,RELEASE);
    StepperDrive(3,MOTOR_RIGHT);
    servoMotor(3,TOUCH);
}

void RMove(){
    // close motor
    servoMotor(4,TOUCH);
    StepperDrive(4,MOTOR_RIGHT);
    servoMotor(4,RELEASE);
    StepperDrive(4,MOTOR_LEFT);
    servoMotor(4,TOUCH);
}

void RiMove(){
    // close motor
    servoMotor(4,TOUCH);
    StepperDrive(4,MOTOR_LEFT);
    servoMotor(4,RELEASE);
    StepperDrive(4,MOTOR_RIGHT);
    servoMotor(4,TOUCH);
}

void initCube(){
  // get upper picture
    servoMotor(1,RELEASE);
    servoMotor(3,RELEASE);
    Serial.print('U');
    while(1){
      if(Serial.available()){
         char c=Serial.read();
         if(c=='D')
          break; 
      }  
    }
    
    servoMotor(1,TOUCH);
    servoMotor(3,TOUCH);
    servoMotor(2,RELEASE);
    servoMotor(4,RELEASE);
    Serial.print('U');
    while(1){
      if(Serial.available()){
         char c=Serial.read();
         if(c=='D')
          break; 
      }  
    }
    
    // Back
    servoMotor(2,TOUCH);
    servoMotor(4,TOUCH);
    servoMotor(1,RELEASE);
    servoMotor(3,RELEASE);

    StepperDrive(24,MOTOR_RIGHT);
    
    Serial.print('B');
    while(1){
      if(Serial.available()){
         char c=Serial.read();
         if(c=='D')
          break; 
      }  
    }

    digitalWrite(46,HIGH);
    digitalWrite(47,HIGH);
    digitalWrite(48,LOW);
    digitalWrite(49,LOW);
    digitalWrite(52,HIGH);
    digitalWrite(53,HIGH);
    digitalWrite(50,LOW);
    digitalWrite(51,LOW);
    
    for(int i=0;i<100;i++){ 
        stepperMotor2.step(1);
        stepperMotor4.step(-1);
    }

    digitalWrite(46,LOW);
    digitalWrite(47,LOW);
    digitalWrite(48,LOW);
    digitalWrite(49,LOW);
    digitalWrite(52,LOW);
    digitalWrite(53,LOW);
    digitalWrite(50,LOW);
    digitalWrite(51,LOW);

    Serial.print('F');
    while(1){
      if(Serial.available()){
         char c=Serial.read();
         if(c=='D')
          break; 
      }  
    }
    // down
    StepperDrive(24,MOTOR_LEFT);
    Serial.print('D');
    while(1){
      if(Serial.available()){
         char c=Serial.read();
         if(c=='D')
          break; 
      }  
    }

    servoMotor(1,TOUCH);
    servoMotor(3,TOUCH);
    servoMotor(2,RELEASE);
    servoMotor(4,RELEASE);

    Serial.print('D');
    while(1){
      if(Serial.available()){
         char c=Serial.read();
         if(c=='D')
          break; 
      }  
    }
    servoMotor(2,TOUCH);
    servoMotor(4,TOUCH);
    servoMotor(1,RELEASE);
    servoMotor(3,RELEASE);
    
    digitalWrite(46,HIGH);
    digitalWrite(47,HIGH);
    digitalWrite(48,LOW);
    digitalWrite(49,LOW);
    digitalWrite(52,HIGH);
    digitalWrite(53,HIGH);
    digitalWrite(50,LOW);
    digitalWrite(51,LOW);
    
    for(int i=0;i<100;i++){ 
        stepperMotor2.step(-1);
        stepperMotor4.step(1);
    }

    digitalWrite(46,LOW);
    digitalWrite(47,LOW);
    digitalWrite(48,LOW);
    digitalWrite(49,LOW);
    digitalWrite(52,LOW);
    digitalWrite(53,LOW);
    digitalWrite(50,LOW);
    digitalWrite(51,LOW);
    
    
    servoMotor(1,TOUCH);
    servoMotor(3,TOUCH);
    servoMotor(2,RELEASE);
    servoMotor(4,RELEASE);
    StepperDrive(13,MOTOR_LEFT);
    Serial.print('R');
    while(1){
      if(Serial.available()){
         char c=Serial.read();
         if(c=='D')
          break; 
      }  
    }

    digitalWrite(46,LOW);
    digitalWrite(47,LOW);
    digitalWrite(48,HIGH);
    digitalWrite(49,HIGH);
    digitalWrite(52,LOW);
    digitalWrite(53,LOW);
    digitalWrite(50,HIGH);
    digitalWrite(51,HIGH);
    
    for(int i=0;i<100;i++){  
        stepperMotor1.step(1);
        stepperMotor3.step(-1);
    }

    digitalWrite(46,LOW);
    digitalWrite(47,LOW);
    digitalWrite(48,LOW);
    digitalWrite(49,LOW);
    digitalWrite(52,LOW);
    digitalWrite(53,LOW);
    digitalWrite(50,LOW);
    digitalWrite(51,LOW);
    
    Serial.print('L');
    while(1){
      if(Serial.available()){
         char c=Serial.read();
         if(c=='D')
          break; 
      }  
    }

    StepperDrive(13,MOTOR_LEFT);
    servoMotor(2,TOUCH);
    servoMotor(4,TOUCH);
    digitalWrite(46,LOW);
    digitalWrite(47,LOW);
    digitalWrite(48,LOW);
    digitalWrite(49,LOW);
    digitalWrite(52,LOW);
    digitalWrite(53,LOW);
    digitalWrite(50,LOW);
    digitalWrite(51,LOW);
    Serial.print('E');
    while(1){
      if(Serial.available()){
         char c=Serial.read();
         if(c=='D')
          break; 
      }  
    }

    
}

void UiMove(){
    // release 
    servoMotor(1,RELEASE);
    servoMotor(3,RELEASE);
    StepperDrive(24,MOTOR_RIGHT);
    servoMotor(1,TOUCH);
    servoMotor(3,TOUCH);
    servoMotor(2,RELEASE);
    servoMotor(4,RELEASE);
    StepperDrive(24,MOTOR_LEFT);
    servoMotor(2,TOUCH);
    servoMotor(4,TOUCH);
    StepperDrive(1,MOTOR_LEFT);
    servoMotor(1,RELEASE);
    StepperDrive(1,MOTOR_RIGHT);
    servoMotor(3,RELEASE);

    StepperDrive(24,MOTOR_LEFT);
    servoMotor(1,TOUCH);
    servoMotor(3,TOUCH);
    servoMotor(2,RELEASE);
    servoMotor(4,RELEASE);
    StepperDrive(24,MOTOR_RIGHT);
    servoMotor(2,TOUCH);
    servoMotor(4,TOUCH);
}

void UMove(){
    // release 
    servoMotor(1,RELEASE);
    servoMotor(3,RELEASE);
    StepperDrive(24,MOTOR_RIGHT);
    servoMotor(1,TOUCH);
    servoMotor(3,TOUCH);
    servoMotor(2,RELEASE);
    servoMotor(4,RELEASE);
    StepperDrive(24,MOTOR_LEFT);
    servoMotor(2,TOUCH);
    servoMotor(4,TOUCH);
    StepperDrive(1,MOTOR_RIGHT);
    servoMotor(1,RELEASE);
    StepperDrive(1,MOTOR_LEFT);
    servoMotor(3,RELEASE);

    StepperDrive(24,MOTOR_LEFT);
    servoMotor(1,TOUCH);
    servoMotor(3,TOUCH);
    servoMotor(2,RELEASE);
    servoMotor(4,RELEASE);
    StepperDrive(24,MOTOR_RIGHT);
    servoMotor(2,TOUCH);
    servoMotor(4,TOUCH);
}


void DiMove(){
    // release 
    servoMotor(1,RELEASE);
    servoMotor(3,RELEASE);
    StepperDrive(24,MOTOR_RIGHT);
    servoMotor(1,TOUCH);
    servoMotor(3,TOUCH);
    servoMotor(2,RELEASE);
    servoMotor(4,RELEASE);
    StepperDrive(24,MOTOR_LEFT);
    servoMotor(2,TOUCH);
    servoMotor(4,TOUCH);
    StepperDrive(3,MOTOR_LEFT);
    servoMotor(3,RELEASE);
    StepperDrive(3,MOTOR_RIGHT);
    servoMotor(1,RELEASE);

    StepperDrive(24,MOTOR_LEFT);
    servoMotor(1,TOUCH);
    servoMotor(3,TOUCH);
    servoMotor(2,RELEASE);
    servoMotor(4,RELEASE);
    StepperDrive(24,MOTOR_RIGHT);
    servoMotor(2,TOUCH);
    servoMotor(4,TOUCH);
}

void DMove(){
    // release 
    servoMotor(1,RELEASE);
    servoMotor(3,RELEASE);
    StepperDrive(24,MOTOR_RIGHT);
    servoMotor(1,TOUCH);
    servoMotor(3,TOUCH);
    servoMotor(2,RELEASE);
    servoMotor(4,RELEASE);
    StepperDrive(24,MOTOR_LEFT);
    servoMotor(2,TOUCH);
    servoMotor(4,TOUCH);
    StepperDrive(3,MOTOR_RIGHT);
    servoMotor(3,RELEASE);
    
    StepperDrive(3,MOTOR_LEFT);
    servoMotor(1,RELEASE);
    
    StepperDrive(24,MOTOR_LEFT);
    servoMotor(1,TOUCH);
    servoMotor(3,TOUCH);
    servoMotor(2,RELEASE);
    servoMotor(4,RELEASE);
    StepperDrive(24,MOTOR_RIGHT);
    servoMotor(2,TOUCH);
    servoMotor(4,TOUCH);
}

void StepperDrive(int motorNumber,int motorDirection){
  
  switch(motorNumber){  // motor Number
    case 1:{
        digitalWrite(46,LOW);
        digitalWrite(47,LOW);
        digitalWrite(48,HIGH);
        digitalWrite(49,HIGH);
        digitalWrite(52,LOW);
        digitalWrite(53,LOW);
        digitalWrite(50,LOW);
        digitalWrite(51,LOW);
        
        if(motorDirection == 0)
          stepperMotor1.step(-Motor1Rev);
        else{
          stepperMotor1.step(Motor1Rev);
        }
    };break;
    case 2:{
        digitalWrite(46,LOW);
        digitalWrite(47,LOW);
        digitalWrite(48,LOW);
        digitalWrite(49,LOW);
        digitalWrite(52,HIGH);
        digitalWrite(53,HIGH);
        digitalWrite(50,LOW);
        digitalWrite(51,LOW);
        
        if(motorDirection == 0)
          stepperMotor2.step(Motor2Rev);
        else{
          stepperMotor2.step(-Motor2Rev);
        }
    };break;
    case 3:{
        digitalWrite(46,LOW);
        digitalWrite(47,LOW);
        digitalWrite(48,LOW);
        digitalWrite(49,LOW);
        digitalWrite(52,LOW);
        digitalWrite(53,LOW);
        digitalWrite(50,HIGH);
        digitalWrite(51,HIGH);
        
        if(motorDirection == 0)
          stepperMotor3.step(-Motor3Rev);
        else{
          stepperMotor3.step(Motor3Rev);
        }
    };break;
    case 4:{
        digitalWrite(46,HIGH);
        digitalWrite(47,HIGH);
        digitalWrite(48,LOW);
        digitalWrite(49,LOW);
        digitalWrite(52,LOW);
        digitalWrite(53,LOW);
        digitalWrite(50,LOW);
        digitalWrite(51,LOW);
        
        if(motorDirection == 0)
          stepperMotor4.step(Motor4Rev);
        else{
          stepperMotor4.step(-Motor4Rev);
        }
    };break;  
    case 24:{
        digitalWrite(46,HIGH);
        digitalWrite(47,HIGH);
        digitalWrite(48,LOW);
        digitalWrite(49,LOW);
        digitalWrite(52,HIGH);
        digitalWrite(53,HIGH);
        digitalWrite(50,LOW);
        digitalWrite(51,LOW);
        
        for(int i=0;i<Motordua24Rev;i++){ 
          if(motorDirection == 0){
            stepperMotor2.step(1);
            stepperMotor4.step(-1);
          }
          else{
            stepperMotor2.step(-1);
            stepperMotor4.step(1);
          }
        }
    };break;
    case 13:{
        digitalWrite(46,LOW);
        digitalWrite(47,LOW);
        digitalWrite(48,HIGH);
        digitalWrite(49,HIGH);
        digitalWrite(52,LOW);
        digitalWrite(53,LOW);
        digitalWrite(50,HIGH);
        digitalWrite(51,HIGH);
        
        for(int i=0;i<Motordua13Rev;i++){ 
          if(motorDirection == 0){
            stepperMotor3.step(1);
            stepperMotor1.step(-1);
          }
          else{
            stepperMotor3.step(-1);
            stepperMotor1.step(1);
          }
          delay(5);
        }
       
    };break;
  }
   
  
  digitalWrite(46,LOW);
  digitalWrite(47,LOW);
  digitalWrite(48,LOW);
  digitalWrite(49,LOW);
  digitalWrite(52,LOW);
  digitalWrite(53,LOW);
  digitalWrite(50,LOW);
  digitalWrite(51,LOW);
  digitalWrite(26,LOW);
  digitalWrite(27,LOW);
  digitalWrite(28,LOW);
  digitalWrite(29,LOW);
  digitalWrite(30,LOW);
  digitalWrite(31,LOW);
  digitalWrite(32,LOW);
  digitalWrite(33,LOW);
  digitalWrite(34,LOW);
  digitalWrite(35,LOW);
  digitalWrite(36,LOW);
  digitalWrite(37,LOW);
  digitalWrite(38,LOW);
  digitalWrite(39,LOW);
  digitalWrite(40,LOW);
  digitalWrite(41,LOW);
  delay(DELAY_FUNC);
}

void servoMotor(int motorNumber,int state){
  switch(motorNumber){
    case 3: {
      if(state==0)
        servoMotor3.write(10);
      else
        servoMotor3.write(70);
    }break;
    case 4: {
      if(state==0)
        servoMotor4.write(10);
      else
        servoMotor4.write(70);
    }break;
    case 1: {
      if(state==0)
        servoMotor1.write(15);
      else
        servoMotor1.write(70);
    }break;
    case 2: {
      if(state==0)
        servoMotor2.write(15);
      else
        servoMotor2.write(70);
    }break;
  }

  delay(DELAY_FUNC);
}









