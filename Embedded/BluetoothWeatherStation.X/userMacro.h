/* 
 * File:   userMacro.h
 * Author: ggirard
 *
 * Created on December 3, 2013, 9:33 AM
 */

#ifndef USERMACRO_H
#define	USERMACRO_H

#define GROUPNUM    2
#define NULL    '\0'
#define NEWLINE '\n'

//Set the oscillator frequency to 20MHz
#define _XTAL_FREQ 20000000
//#define _XTAL_FREQ 4000000

const char member1[] = "Greg Girard";
const char member2[] = "Deepak Chandrasekar";
const char member3[] = "Apurve Bhide";
const char classNum[] = "ECE5620";
const char classTerm[] = "Fall 2013";
const char groupNum = '2';

unsigned char readError[] = "Not a valid read command";

//Constants used for logic
//Defined start byte
const unsigned char userStartByte = 0xAA;
//Defined end byte (new line feed)
const unsigned char userEndByte = 0x0A;
//Line feed character
const unsigned char newLineChar = 0x0A;
//Minimum packet size
const unsigned char minSizeByte = 0x0A;
//Length of packet with no data
const unsigned char noDataLen = 0x0A;
//Max command value
const unsigned char maxCmd = 0x0E;
//The byte value for read
const unsigned char readByteVal = 0x00;
//The byte value for write
const unsigned char writeByteVal = 0x01;
//The timeout byte
const unsigned char timeoutByte = 0xFF;

//Memory addresses
//Address where the rx data length is stored
const unsigned char RXLenAddr = 0x00;
//Address where the start byte is stored
const unsigned char startByteAddr = 0x01;
//Address where the rw byte is stored
const unsigned char rwByteAddr = 0x02;
//Address where the cmd byte is stored
const unsigned char cmdByteAddr = 0x03;
//Address where the data length byte is stored
const unsigned char lenByteAddr = 0x04;
//Address where the checksum received is stored
const unsigned char csByteAddr = 0x05;
//Address where the end byte is stored
const unsigned char endByteAddr = 0x06;
//Address where the data is stored
const unsigned char dataBytesAddr = 0x07;
//Address where the check sum is calculated
const unsigned char calcCSByteAddr = 0x30;

//Temperature addresses
//Address where the lower 8 bits are stored
const unsigned char tempValHAddr = 0x60;
//Address where the higher 2 bits are stored
const unsigned char tempValLAddr = 0x61;
//Address where the high temp is stored
const unsigned char tempHiAddr = 0x62;
//Address where the low temp is stored
const unsigned char tempLoAddr = 0x64;
//Address where the unit is stored
const unsigned char tempUnitAddr = 0x66;

//Temperature start values
//Init value for temp high
const unsigned char tempStartHi = 0x64; //100C
//Init value for temp low
const unsigned char tempStartLo = 0xA0; //10C
//Value for C
const unsigned char tempC = 0x00;
//Value for F
const unsigned char tempF = 0x10;

//Humidity addresses
//Lower 8 bits of humidity value
const unsigned char humValHAddr = 0x80;
//Higher 2 bits of humidity value
const unsigned char humValLAddr = 0x82;
//Address to store the humidity high
const unsigned char humHiAddr = 0x84;
//Address to store the humidity low
const unsigned char humLoAddr = 0x86;

//Init Humidity values
//Init humidity high
const unsigned char humStartHi = 0x50; //80%
//Init humidity low
const unsigned char humStartLo = 0x0A; //10%

#endif	/* USERMACRO_H */

