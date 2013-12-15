/* 
 * File:   display.h
 * Author: Greg Laptop
 *
 * Created on December 14, 2013, 11:49 PM
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

/*Clear Display:    RS:0,RW:0,D:0x01
 * Return Home:     RS:0,RW:0,D:0x02
 *
 */

#define RS  RD0
#define RW  RD1
#define E   RD2
#define D4  RD4
#define D5  RD5
#define D6  RD6
#define D7  RD7

#define lcdData PORTD

#define lcdStrobe()   ((E=1),(E=0))

#ifndef DISPLAY_H
#define	DISPLAY_H

void lcdInit();
void lcdWrite(unsigned char c);
void lcdClear();
void lcdPuts(const char* s);
void lcdPutch(char c);
void lcdGoto(unsigned char pos);

#endif	/* DISPLAY_H */

