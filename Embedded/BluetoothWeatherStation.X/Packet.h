/* 
 * File:   Packet.h
 * Author: ggirard
 *
 * Created on December 4, 2013, 1:35 PM
 */

#ifndef PACKET_H
#define	PACKET_H

//Check to see if the packet is an even number (even bytes)
int checkEven();
//Check to see if the packet is a minimum length
int checkLength();
//Check to see the data frames are valid
int checkDataFrames();
//Parse the packets to the correct categories
void parsePacket(unsigned char* dataPacket);
//Check to see the packet is valid
int validatePacket();
//Add the data frames to the check sum calculation
void addDataToCheckSum();
//Check to see if it is a valid start byte
int checkStartByte();
//Check to see if the Read/write byte is in the correct range
int checkRWByte();
//Check to see if the cmd byte is in the correct range
int checkCMDByte();
//Check to see if the data length byte matches the data
int checkDataLenByte();
//Check the checksum provided versus calculated
int checkCS();
//Display all the packet values
void displayPacket();


#endif	/* PACKET_H */

