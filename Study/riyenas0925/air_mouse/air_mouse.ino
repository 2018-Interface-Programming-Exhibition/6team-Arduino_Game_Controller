#include <Wire.h>
#include <Mouse.h>
#include <Keyboard.h>
#include "Kalman.h"
 
int gyroX, gyroZ;
 
int Sensitivity = 400;
int keydelay = 30;
int loopdelay = 3;

uint32_t timer;
uint8_t i2cData[14]; // Buffer for I2C data

void JoyStick(int JoyX, int JoyY){
  (JoyX < 100) ? Keyboard.press('a') : Keyboard.release('a');
  (JoyX > 500) ? Keyboard.press('d') : Keyboard.release('d');

  (JoyY < 100) ? Keyboard.press('w') : Keyboard.release('w');
  (JoyY > 500) ? Keyboard.press('s') : Keyboard.release('s');
}
 
void setup() {
  Serial.begin(9600);
  Wire.begin();
  i2cData[0] = 7; // Set the sample rate to 1000Hz - 8kHz/(7+1) = 1000Hz
  i2cData[1] = 0x00; // Disable FSYNC and set 260 Hz Acc filtering, 256 Hz Gyro filtering, 8 KHz sampling
  
  i2cData[3] = 0x00; // Set Accelerometer Full Scale Range to ±2g
  while(i2cWrite(0x19,i2cData,4,false)); // Write to all four registers at once
  while(i2cWrite(0x6B,0x01,true)); // PLL with X axis gyroscope reference and disable sleep mode
  while(i2cRead(0x75,i2cData,1));
  if(i2cData[0] != 0x68) { // Read "WHO_AM_I" register
    Serial.print(F("Error reading sensor"));
    while(1);
  }
 
  delay(100); // Wait for sensor to stabilize
 
  /* Set kalman and gyro starting angle */
  while(i2cRead(0x3B,i2cData,6));
  timer = micros();
 
  Mouse.begin();
}
 
void loop() {
  /* Update all the values */
  while(i2cRead(0x3B,i2cData,14));
  gyroX = ((i2cData[8] << 8) | i2cData[9]);
  gyroZ = ((i2cData[12] << 8) | i2cData[13]);
 
  gyroX = gyroX / Sensitivity / 1.1  * -1;
  gyroZ = gyroZ / Sensitivity  * -1;

  Mouse.move(gyroZ, gyroX);

  int JoyX = analogRead(A0);
  int JoyY = analogRead(A1);
  
  JoyStick(JoyX, JoyY);

  //시리얼 출력부분

  Serial.println("=================================");
  Serial.print("gyroX : ");
  Serial.print(gyroX);
  Serial.print(" ");
  Serial.print("gyroZ : ");
  Serial.println(gyroZ);
  Serial.println("F Button : ");
  Serial.println("I Button : ");
  Serial.println("Space Button : ");
  Serial.println("=================================");

  delay(loopdelay);  
}
