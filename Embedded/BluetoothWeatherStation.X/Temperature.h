/* 
 * File:   Temperature.h
 * Author: ggirard
 *
 * Created on December 3, 2013, 9:31 AM
 */

#ifndef TEMPERATURE_H
#define	TEMPERATURE_H

//Int because it is 10 bit response
unsigned int readTemp();
void initTemp();
void setTempUnit();
void setTempHi();
void setTempLo();
//unsigned char convertToTemp();

#endif	/* TEMPERATURE_H */

