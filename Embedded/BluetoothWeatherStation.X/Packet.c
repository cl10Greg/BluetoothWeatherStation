#include <htc.h>
#include "C:\Users\ggirard\MPLABXProjects\BluetoothWeatherStation.X\userMacro.h"
#include "C:\Users\ggirard\MPLABXProjects\BluetoothWeatherStation.X\Bluetooth.h"
#include <Packet.h>
#include <string.h>

/* Packet information:
 * startByte:       1 byte  AA
 * RWByte:          1 byte  00: Read
 *                          01: Write
 * CMD:             1 byte  00: Get Temperature
 *                          01: Get temp high
 *                          02: Get temp low
 *                          03: Get Humidity
 *                          04: Get humid high
 *                          05: Get humid low
 *                          06: Get time
 *                          07: Get all
 *                          08: Set temp units
 *                          09: Set temp high
 *                          0A: Set temp low
 *                          0B: Set humidity high
 *                          0C: Set humidity low
 *                          0D: Set ADC refresh rate
 *                          0E: Set RTC
 * DataLenByte:     1 byte  Hex value of the number of data bytes
 * DataBytes:       n bytes Depends on the command
 * CheckSumByte:    1 byte  Sum of all previous numbers
 * EndByte:         1 byte  \n
 */

/********************************************************************
 * Function:    checkEven                                           *
 * Type:        int                                                 *
 * Argument:    None                                                *
 * Return:      int (1 or 0 to represent true or false)             *
 * Purpose:     Check that the total received length is even.  The  *
 *              data is coming is as nibbles so two nibbles are one *
 *              hex byte.  The packet must be even because of this. *
 *              If not, there is a nibble missing.                  *
 *******************************************************************/
int checkEven() {
    // Read the packet length from memory
    //Check to see if the length is even
    if (eeprom_read(RXLenAddr) % 2 == 0) {
        //If it is return true and write yes
        writeByte('E');
        return 1;
    }
        //If it isn't return false and write no
        writeByte('N');
        return 0;
}

/********************************************************************
 * Function:    checkLength                                         *
 * Type:        int                                                 *
 * Argument:    None                                                *
 * Return:      int (1 or 0 to represent true or false)             *
 * Purpose:     Check to make sure that the received data is a      *
 *              minimum length.  The minimum length is the packet   *
 *              structure with 0 data.  So nothing can be smaller.  *
 *******************************************************************/
int checkLength() {
    //Read the packet length from memory
    //Check to see if the packet is the minimum length
    if (eeprom_read(RXLenAddr) >= minSizeByte) {
        //If it is, return true and write yes
        writeByte('L');
        return 1;
    }
    //If it isn't, return false and write no
    writeByte('N');
    return 0;
}

/********************************************************************
 * Function:    checkDataFrames                                     *
 * Type:        int                                                 *
 * Argument:    None                                                *
 * Return:      int (1 or 0 to represent true or false)             *
 * Purpose:     Checks to verify that the correct number of data    *
 *              frames matches the length it is expecting.          *
 *******************************************************************/
int checkDataFrames(){
    //If the data length is supposed to be 0 and there are no extra packets
    if(eeprom_read(lenByteAddr) == 0  && (eeprom_read(RXLenAddr)-noDataLen) == 0){
        //Return true and write yes
        writeByte('D');
        return 1;
    //For not 0 data
    //Check to see how many packets there are and make sure that is how much there are supposed to be
    //*2 to go from bytes to nibbles
    }else if((eeprom_read(RXLenAddr) - noDataLen) == (eeprom_read(lenByteAddr)*2)){
        //Return true and write yes
        writeByte('D');
        return 1;
    }
    //If the data doesn't match what is expected
    //Return false and write no
    writeByte('N');
    return 0;
}

/********************************************************************
 * Function:    parsePacket                                         *
 * Type:        Void                                                *
 * Argument:    dataPacket (pointer to char array)                  *
 * Return:      None                                                *
 * Purpose:     Breaks the packet up into it's different categories *
 *              and stores the values to eeprom for global use.     *
 *              Also does some preliminary data validation checks.  *
 *******************************************************************/
void parsePacket(unsigned char* dataPacket) {
    //Temporary counter
    int dataCounter = 0;
    //Check that the minimum packet length has been met
    //Check to make sure no data is missing
    if (checkLength() && checkEven()) {
            //Store the packet information to memory
            //Start Byte
            eeprom_write(startByteAddr, makeHexByte(dataPacket[0], dataPacket[1]));
            //RW Byte
            eeprom_write(rwByteAddr, makeHexByte(dataPacket[2], dataPacket[3]));
            //CMD Byte
            eeprom_write(cmdByteAddr, makeHexByte(dataPacket[4], dataPacket[5]));
            //Data len Byte
            eeprom_write(lenByteAddr, makeHexByte(dataPacket[6], dataPacket[7]));
            //CS
            eeprom_write(csByteAddr, makeHexByte(dataPacket[strlen(dataPacket) - 2], dataPacket[strlen(dataPacket) - 1]));
            //Data
            //Do a loop for all the data
            for (unsigned char i = 0x00; i < eeprom_read(lenByteAddr); i++) {
                eeprom_write(dataBytesAddr+i, makeHexByte(dataPacket[8 + dataCounter], dataPacket[9 + dataCounter]));
                dataCounter += 2;
            }
        }
}

/********************************************************************
 * Function:    checkStartByte                                      *
 * Type:        int                                                 *
 * Argument:    None                                                *
 * Return:      int (1 or 0 to represent true or false)             *
 * Purpose:     Checks to see if the start byte is the same as the  *
 *              user has defined.                                   *
 *******************************************************************/
int checkStartByte() {
    //Read the start byte from memory
    //Check to see if the start byte matches the user defined byte
    if (eeprom_read(startByteAddr) == userStartByte) {
        //If it is, return true and write yet
        writeByte('S');
        eeprom_write(calcCSByteAddr,eeprom_read(calcCSByteAddr)+eeprom_read(startByteAddr));
        return 1;
    }
    //If it is, return false and write no
    writeByte('N');
    return 0;
}

int checkRWByte() {
    if(eeprom_read(rwByteAddr) == 0 || eeprom_read(rwByteAddr) == 1){
        writeByte('R');
        eeprom_write(calcCSByteAddr,eeprom_read(calcCSByteAddr)+eeprom_read(rwByteAddr));
        return 1;
    }
    writeByte('N');
    return 0;
}

int checkCMDByte(){
    if(eeprom_read(cmdByteAddr) >= 0 && eeprom_read(cmdByteAddr) <= maxCmd){
        eeprom_write(calcCSByteAddr,eeprom_read(calcCSByteAddr)+eeprom_read(cmdByteAddr));
        writeByte('C');
        return 1;
    }
    writeByte('N');
    return 0;
}

int checkCS(){
    if(eeprom_read(csByteAddr) == eeprom_read(calcCSByteAddr)){
        writeByte('Y');
        return 1;
    }
    writeByte('N');
    return 0;
}
int validatePacket(){
    //Check the start byte
    if(checkStartByte() && checkRWByte() && checkCMDByte() && checkDataFrames()){
        //Get Data frame and length for checksum
        addDataToCheckSum();
        if(checkCS())
            return 1;
    }
    return 0;
    
}

void addDataToCheckSum(){
    eeprom_write(calcCSByteAddr,eeprom_read(calcCSByteAddr)+eeprom_read(lenByteAddr));
    for (unsigned char i = 0x00; i < eeprom_read(lenByteAddr); i++) {
        eeprom_write(calcCSByteAddr,eeprom_read(calcCSByteAddr)+eeprom_read(dataBytesAddr+i));
    }
}

void displayPacket() {

    //Write Start Byte
    writeByte(newLineChar);
    writeByte(eeprom_read(startByteAddr));
    writeByte(newLineChar);
    //Write RW Byte
    writeByte(eeprom_read(rwByteAddr));
    writeByte(newLineChar);
    //Write CMD Byte
    writeByte(eeprom_read(cmdByteAddr));
    writeByte(newLineChar);
    //Write Data length Byte:
    writeByte(eeprom_read(lenByteAddr));
    writeByte(newLineChar);

    for (unsigned char i = 0x00; i < eeprom_read(lenByteAddr); i++) {
        writeByte(eeprom_read(dataBytesAddr+i));
        writeByte(newLineChar);
    }
    
    //Write Checksum Byte:
    writeByte(eeprom_read(csByteAddr));
    writeByte(newLineChar);
}