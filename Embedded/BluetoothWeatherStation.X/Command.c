#include "userMacro.h"
#include "Bluetooth.h"
#include <htc.h>

/********************************************************************
 * Function:    readCommands                                        *
 * Type:        Void                                                *
 * Argument:    None                                                *
 * Return:      None                                                *
 * Function:    Read the cmd to determine what information to return*
 *******************************************************************/
void readCommands(){

    switch(eeprom_read(cmdByteAddr)){
        //Get temperature
        case 0:
            writeByte(userStartByte);
            writeByte(tempValHAddr);
            writeByte(tempValLAddr);
            break;
        //Get temp high
        case 1:
            writeByte(userStartByte);
            writeByte(tempHiAddr);
            break;
        //Get temp low
        case 2:
            writeByte(userStartByte);
            writeByte(tempLoAddr);
            break;
        //Get humidity
        case 3:
            writeByte(userStartByte);
            writeByte(humValHAddr);
            writeByte(humValLAddr);
            break;
        //Get humidity high
        case 4:
            writeByte(userStartByte);
            writeByte(humHiAddr);
            break;
        //Get humidity low
        case 5:
            writeByte(userStartByte);
            writeByte(humLoAddr);
            break;
        //Get Time
        case 6:
            writeByte(userStartByte);
            writeByte('R');
            writeByte('T');
            writeByte('C');
            break;
        //Get all
        case 7:
            writeByte(userStartByte);
            writeByte(tempValHAddr);
            writeByte(tempValLAddr);
            writeByte(tempHiAddr);
            writeByte(tempLoAddr);
            writeByte(humValHAddr);
            writeByte(humValLAddr);
            writeByte(humHiAddr);
            writeByte(humLoAddr);
            writeByte('R');
            writeByte('T');
            writeByte('C');
            break;
        //Error
        default:
            writeString(readError);
            break;
    }
    //Check the cmd byte
    //Return the data wanted
}

/********************************************************************
 * Function:    writeCommands                                       *
 * Type:        Void                                                *
 * Argument:    None                                                *
 * Return:      None                                                *
 * Purpose:     Set the system parameter based on user data         *
 *******************************************************************/
void writeCommands(){
    //Check the cmd byte
    //set the values
    //return ack
}
