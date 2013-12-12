/************************************************************************
 * HTC.h:   The header file for the Hi-tech compiler                    *
 * pic.h:   The header file for pic interuppts and registers            *
 * Bluetooth.h: The header file for the UART communication              *
 * userMacro.h: The header file for user definitions                    *
 * pic16f877a.h:    The header file for the mapping of the pic16f877A   *
 *                  registers and memory.                               *
 ***********************************************************************/
#include <htc.h>
#include "Bluetooth.h"
#include "userMacro.h"
#include "Temperature.h"
#include "customADC.h"
#include "Packet.h"


/*************************************************************************
 * Configuration Bits                                                    *
 * WDTE:    Watchdog Timer                                               *
 *      Value:  Off                                                      *
 * LVP:     Low voltage in circuit serial programming enable bit         *
 *      Value:  Off                                                      *
 * BOREN:   Brown out reset enable bit                                   *
 *      Value:  Off                                                      *
 * FOSC:    Oscillator selection bits                                    *
 *      Value:  HS (high speed)                                          *
 * PWRTE:   Power up timer enable bit                                    *
 *      Value:  OFF                                                      *
 ************************************************************************/
__CONFIG(WDTE_OFF & LVP_OFF & BOREN_OFF & FOSC_HS & PWRTE_OFF) ;

/************************************************************************
 * Function:    Main                                                    *
 * Type:        Int                                                     *
 * Arguments:   None                                                    *
 * Return:      None                                                    *
 * Purpose:     The purpose of this function is the main loop of the    *
 *              software.  The program will all be contained and called *
 *              from this function.                                     *
 ***********************************************************************/
int main()
{
    char testString[] = "Welcome\n";
    char counterText[] = "Length: ";
    
    //Used to setup the UART connection for bluetooth
    initUSART();
    initADC();
    

    writeString(testString);
    //Infinite loop.  Will look for communication and get analog values. Will
    //send and receive data in this loop
    while(1){
        //echoBack();

        //Gets the raw value
        //selectTemp();
        //tempVal = readTemp();

        //This reads the uart and parses it
        while(!RCIF);
            //Reset calculated check sum
            eeprom_write(calcCSByteAddr,0x00);
            //Data input space (temporarily only 4 packets of data)
            char arrStore[50] = {0};
            //Read the UART data
            readString(arrStore);
            //Write the data to the TX
            writeString(arrStore);
            //Write the length to TX
            writeString(counterText);
            //Write the data stored in EEPROM
            writeByte(eeprom_read(RXLenAddr));
            parsePacket(arrStore);
            if(validatePacket()){
                writeByte('V');
                //Get values
                //Make response
            }else{
                writeByte('N');
            }
    }

    //Should never get to this part of the program.  If it does, there was an
    //error.
    return 0;
}
