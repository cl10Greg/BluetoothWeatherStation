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


const char member1[] = "Greg Girard";
const char member2[] = "Deepak Chandrasekar";
const char member3[] = "Apurve Bhide";
const char classNum[] = "ECE5620";
const char classTerm[] = "Fall 2013";
const char groupNum = '2';

const unsigned char userStartByte = 0xAA;
const unsigned char userEndByte = 0x0A;
const unsigned char newLineChar = 0x0A;
const unsigned char minSizeByte = 0x0A;
const unsigned char noDataLen = 0x0A;
const unsigned char maxCmd = 0x0E;
const unsigned char readByteVal = 0x00;
const unsigned char writeByteVal = 0x01;
const unsigned char timeoutByte = 0xFF;

const unsigned char RXLenAddr = 0x00;
const unsigned char startByteAddr = 0x01;
const unsigned char rwByteAddr = 0x02;
const unsigned char cmdByteAddr = 0x03;
const unsigned char lenByteAddr = 0x04;
const unsigned char csByteAddr = 0x05;
const unsigned char endByteAddr = 0x06;
const unsigned char dataBytesAddr = 0x07;

const unsigned char calcCSByteAddr = 0x30;

const unsigned char tempValHAddr = 0x60;
const unsigned char tempValLAddr = 0x61;
const unsigned char tempHiAddr = 0x62;
const unsigned char tempLoAddr = 0x64;
const unsigned char tempUnitAddr = 0x66;

const unsigned char tempStartHi = 0x64; //100C
const unsigned char tempStartLo = 0xA0; //10C
const unsigned char tempC = 0x00;
const unsigned char tempF = 0x10;

const unsigned char humValAddr = 0x80;
const unsigned char humHiAddr = 0x82;
const unsigned char humLoAddr = 0x84;

const unsigned char humStartHi = 0x50; //80%
const unsigned char humStartLo = 0x0A; //10%

#endif	/* USERMACRO_H */

