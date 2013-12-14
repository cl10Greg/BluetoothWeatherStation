#include "userMacro.h"
#include "Bluetooth.h"
#include <htc.h>


void getCommands(){
    //If read has been detected
    switch(eeprom_read(rwByteAddr)){
        case 0:
            writeByte('R');
            break;
        case 1:
            writeByte('W');
            break;
        default:
            writeByte('N');
            break;
    }
}

void setCommands(){

}
