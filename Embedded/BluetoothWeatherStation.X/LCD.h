/* 
 * File:   lcd.h
 * Author: Greg Laptop
 *
 * Created on December 15, 2013, 12:00 AM
 */


#ifndef LCD_H
#define	LCD_H

#define RS  RD0
#define RW  RD1
#define E   RD2
#define D4  RD4
#define D5  RD5
#define D6  RD6
#define D7  RD7

#define RS_DIR  TRISD0
#define RW_DIR  TRISD1
#define E_DIR   TRISD2
#define D4_DIR  TRISD4
#define D5_DIR  TRISD5
#define D6_DIR  TRISD6
#define D7_DIR  TRISD7

// Constants
#define E_Delay       500


// Function Declarations
void WriteCommandToLCD(unsigned char);
void WriteDataToLCD(char);
void InitLCD(void);
void WriteStringToLCD(const char*);
void ClearLCDScreen(void);

#endif	/* LCD_H */

