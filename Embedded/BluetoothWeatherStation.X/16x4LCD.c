#include "16x4LCD.h"
#include "userMacro.h"
#include <htc.h>


void initLCD(){
    TRISD = 0x00;
    RW = 0;
    E = 0;
    RS = 0;
    D4 = 0;
    D5 = 0;
    D6 = 0;
    D7 = 0;
    __delay_ms(15);
    lcdData = 0x30;
    togE();
    __delay_ms(5);
    togE();
    __delay_us(200);
    togE();
    lcdData = 0x20;
    togE();

    lcdWrite(0x28);
    lcdWrite(0xF0);
    lcdClear();
    lcdWrite(0x60);
    
}

void togE(){
    E = 1;
    __delay_ms(2);
    E = 0;
    __delay_ms(2);
}

void lcdWrite(unsigned char c){
    __delay_us(40);
    lcdData = ((c >> 4) & 0xF0);
    togE();
    lcdData = (c & 0xF0);
    togE();
}

void lcdClear(){
    RS = 0;
    lcdWrite(0x10);
    __delay_ms(2);
}

void lcdPuts(const char* s){
    RS = 1;
    while(*s)
        lcdWrite(*s++);
}

void lcdPutch(char c){
    RS = 1;
    lcdWrite(c);
}

void lcdGoto(unsigned char pos){
    RS = 0;
    lcdWrite(0x80+pos);
    __delay_ms(10);
}