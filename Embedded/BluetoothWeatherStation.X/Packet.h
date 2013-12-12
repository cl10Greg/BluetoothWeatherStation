/* 
 * File:   Packet.h
 * Author: ggirard
 *
 * Created on December 4, 2013, 1:35 PM
 */

#ifndef PACKET_H
#define	PACKET_H

int checkEven();
int checkLength();
int checkDataFrames();
void parsePacket(unsigned char* dataPacket);
int validatePacket();
void addDataToCheckSum();
int checkStartByte();
int checkRWByte();
int checkCMDByte();
int checkDataLenByte();
int checkCS();
void displayPacket();


#endif	/* PACKET_H */

