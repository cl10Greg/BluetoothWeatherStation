/* 
 * File:   EEPROM.h
 * Author: ggirard
 *
 * Created on December 4, 2013, 8:52 AM
 */

#ifndef EEPROM_H
#define	EEPROM_H

void eeWrite(unsigned char address, unsigned char value);
unsigned char eeRead(unsigned char address);

#endif	/* EEPROM_H */

