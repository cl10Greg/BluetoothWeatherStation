/* 
 * File:   16x4LCD.h
 * Author: Greg Laptop
 *
 * Created on December 15, 2013, 12:32 AM
 */

/* 16x4 LCD
 * RS:  RD0
 * RW:  RD1
 * E:   RD2
 * D4:  RD4
 * D5:  RD5
 * D6:  RD6
 * D7:  RD7
 */
/*RS:   Register Select     1:Instruction
 *                          0:Data
 * RW:  Read/Write          1:Read
 *                          0:Write
 * E:   Clock               Read when E pulsed
 * D4:7 Data Nibble         MSB first
 *
 */
#include <htc.h>


#define RS  RD0
#define RW  RD1
#define E   RD2
#define D4  RD4
#define D5  RD5
#define D6  RD6
#define D7  RD7

#define lcdData PORTD

#ifndef __16X4LCD_H
#define	__16X4LCD_H

void initLCD();
void togE();
void lcdWrite(unsigned char c);
void lcdClear();
void lcdPuts(const char* s);
void lcdPutch(char c);
void lcdGoto(unsigned char pos);


#endif	/* 16X4LCD_H */

