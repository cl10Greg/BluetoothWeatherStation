#include "Temperature.h"
#include "userMacro.h"
#include <htc.h>
#include "customADC.h"

unsigned int readTemp()
{
    //Turn on ADC
    ADON = 1;
    
    //Wait acquisition time
    //10ms
    __delay_ms(10);
    //Start conversion (set go/done bit)
    GO_nDONE = 1;
    
    //Wait for go/done bit to be cleared
    while(GO_nDONE);
    
    //Read AD register pair
    return ((ADRESH<<8)+ADRESL);
}

void initTemp(){
    //Set the start value and the default hi and low temps
    eeprom_write(tempValHAddr,0x00);
    eeprom_write(tempValLAddr, 0x00);
    eeprom_write(tempHiAddr, tempStartHi);
    eeprom_write(tempLoAddr, tempStartLo);
    eeprom_write(tempUnitAddr, tempC);
}

void setTempUnit(){

}

void setTempHi(){

}

void setTempLo(){
    
}

void getTemp(){
    unsigned int tempReading;
        //Select the channel
        selectTemp();
        //Get the values
        tempReading = readTemp();
        //Write lower 8 bits here
        eeprom_write(tempValLAddr,tempReading);
        //Write higher 2 bits here
        eeprom_write(tempValHAddr+1,tempReading>>8);
}
/*unsigned char convertToTemp(){
    
}*/