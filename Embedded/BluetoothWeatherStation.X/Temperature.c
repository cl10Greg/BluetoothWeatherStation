#include "C:\Users\ggirard\MPLABXProjects\BluetoothWeatherStation.X\Temperature.h"
#include "C:\Users\ggirard\MPLABXProjects\BluetoothWeatherStation.X\userMacro.h"
#include <htc.h>
#include <pic.h>

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