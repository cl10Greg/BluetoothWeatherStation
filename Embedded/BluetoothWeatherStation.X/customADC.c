#include "customADC.h"
#include <htc.h>
#include "userMacro.h"


void initADC()
{
    TRISA = 0x03;

    /* ADCON1:      Configures the functions of the port pins
     * 7:ADFM       A/D result format select bit
     * 6:ADCS2      Conversion clock select bit
     * 5:Unimplemented
     * 4:Unimplemented
     * 3:PCFG3      Port configuration control bits
     * 2:PCFG2      Port configuration control bits
     * 1:PCFG1      Port configuration control bits
     * 0:PCFG0      Port configuration control bits
     * 0100 0000:   0xC0
     */
    ADCON1 = 0x80;
   //ADCON1 = 0x0F;
    //ADCON1 = 0x8F;

    /* ADCON0:      A/D module control register
     * 7:ADCS1      Conversion clock select bit
     * 6:ADCS0      Converstion clock select bit
     * 5:CHS2       Analog channel select bit
     * 4:CHS1       Analog channel select bit
     * 3:CHS0       Analog channel select bit
     * 2:GO/DONE    Conversion status bit
     * 1:Unimplemented
     * 0:ADON       A/D on bit
     * Temperature is connected to AN0
     * FOSC/64 is 312500 herts (3.2microseconds)
     * 1000 0xx0:   0x80
     * The AD isn't on yet, just configured
     */

    ADCON0 = 0x80;
}

void selectTemp()
{
    ADCON0 = 0x80;
}

void selectHumidity()
{
    ADCON0 = 0x84;
}
