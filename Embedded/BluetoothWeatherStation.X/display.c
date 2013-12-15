
#include "userMacro.h"
#include "display.h"
#include <htc.h>



void lcdInit(){
    char init_value;

    init_value = 0x3;
    TRISD = 0;
    RS = 0;
    E = 0;
    RW = 0;

    __delay_ms(15);
    lcdData = init_value;
    lcdStrobe();
    __delay_ms(5);
    lcdStrobe();
    __delay_us(200);
    lcdStrobe();
    lcdData = 2;
    lcdStrobe();

    lcdWrite(0x28);
    lcdWrite(0x0F);
    lcdClear();
    lcdWrite(0x6);

}

/* write a byte to the LCD in 4 bit mode */

void lcdWrite(unsigned char c)
{
	__delay_us(40);
	lcdData = ( ( c >> 4 ) & 0x0F );
	lcdStrobe();
        lcdData = ( c & 0x0F );
	lcdStrobe();
}

/*
 * 	Clear and home the LCD
 */

void lcdClear(void)
{
	RS = 0;
	lcdWrite(0x1);
	__delay_ms(2);
}

/* write a string of chars to the LCD */

void lcdPuts(const char * s)
{
	RS = 1;	// write characters
	while(*s)
		lcdWrite(*s++);
}

/* write one character to the LCD */

void lcdPutch(char c)
{
	RS = 1;	// write characters
	lcdWrite( c );
}


/*
 * Go to the specified position
 */

void lcdGoto(unsigned char pos)
{
	RS = 0;
	lcdWrite(0x80+pos);
}