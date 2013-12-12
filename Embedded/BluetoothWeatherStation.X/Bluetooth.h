/* 
 * File:   Bluetooth.h
 * Author: ggirard
 *
 * Created on December 3, 2013, 9:32 AM
 */

#ifndef BLUETOOTH_H
#define	BLUETOOTH_H

//Initialize all the USART settings
void initUSART();
//Writes a byte through TX
void writeByte(unsigned char Byte);
//Read a byte from RX
unsigned char readByte();
//Echo from RX to TX
void echoBack();
//Write an array of bytes through TX
void writeString(unsigned char* userString);
//Read an array of bytes through RX
void readString(unsigned char* readStorage);
//Make a nibble from a byte
unsigned char makeNibble(unsigned char tempByte);
//Combine to nibbles into a byte
unsigned char makeHexByte(unsigned char nibOne, unsigned char nibTwo);

#endif	/* BLUETOOTH_H */

