/* 
 * File:   Temperature.h
 * Author: ggirard
 *
 * Created on December 3, 2013, 9:31 AM
 */

#ifndef TEMPERATURE_H
#define	TEMPERATURE_H

//Int because it is 10 bit response
//Get the 10 bit ADC value
unsigned int readTemp();
//Initialize the temperature values (hi, lo, etc..)
void initTemp();
//Set the unit
void setTempUnit();
//Set the high alarm value
void setTempHi();
//Set the low alarm value
void setTempLo();
//Get the temperature and write to memory
void getTemp();
//Convert to a useable value
//unsigned char convertToTemp();

#endif	/* TEMPERATURE_H */

