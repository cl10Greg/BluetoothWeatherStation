#include "Bluetooth.h"
#include "userMacro.h"
#include <htc.h>
#include <string.h>

/************************************************************************
 * Function:    initUSART                                               *
 * Type:        Void                                                    *
 * Arguments:   None                                                    *
 * Return:      None                                                    *
 * Purpose:     This function is used to setup the UART communication   *
 *              used for bluetooth communication.  This currently does  *
 *              not user interrupts.                                    *
 ***********************************************************************/
void initUSART()
{
        // TX Pin - output
	TRISC6 = 0;

	// RX Pin - input
	TRISC7 = 1;

        
        
	// RX Setting, 8bit, enable receive,
        /* RCSTA:   Receive status and control register
         * 7:SPEN   Serial port enable
         * 6:RX9    9 bit receive enable
         * 5:SREN   Single receive enable bit
         * 4:CREN   Continuous receive enable bit
         * 3:ADDEN  Address detect enable bit
         * 2:FERR   Framing error bit
         * 1:OERR   Overrun error bit
         * 0:RX9D   9th bit of received data
         * 1001 0000:   0x90                                    */
	RCSTA = 0x90;


	// TX Setting, 8bit, Asinchronius mode, High speed
	/* TXSTA:   Transmit status and control register
         * 7:CSRC   Clock source select bit
         * 6:TX9    9 bit transmit enable bit
         * 5:TXEN   Transmit enable bit
         * 4:SYNC   USART mode select bit
         * 3:Unimplemented
         * 2:BRGH   High baud rate select bit
         * 1:TRMT   Transmit shift register status bit
         * 0:TX9D   9th bit of transmit data
         * 0010 0100:   0x24                                    */
        TXSTA = 0x24;

        // Set Baudrade - 9600 (from datasheet baudrade table)
        /* ASYNC baud rates:
         * BRGH = 0:    FOSC/(64(X+1))
         * BRGH = 1:    FOSC/(16(X+1))
         * 20000000/(16(9600+1)) = 130
         * ~129 on the datasheet                                */
	SPBRG = 129; //20MHz
        //SPBRG = 25; //4MHz

	
        //Turn on global interrupts
        GIE = 1;
        //Turn on the peripheral interrupts
        PEIE = 1;
        //Turn on the RX interrupt
        RCIE = 1;
        
}
/************************************************************************
 * Function:    writeByte                                               *
 * Type:        void                                                    *
 * Arguements:  Byte (unsigned char)                                    *
 * Return:      None                                                    *
 * Purpose:     This function takes a char and waits until the buffer   *
 *              is empty.  Once empty, the byte is transmitted.         *
 ***********************************************************************/
void writeByte(unsigned char Byte)
{
    /* TXIF:    USART transmit interrupt flag bit
     * 1:       Buffer is empty
     * 0:       Buffer is full                     */
    while(!TXIF);

    //Put the character into the transmit data register
    TXREG = Byte;
}
/************************************************************************
 * Function:    readByte                                                *
 * Type:        unsigned char                                           *
 * Arguments:   None                                                    *
 * Return:      RCREG (Receive data register)                           *
 * Purpose:     Waits until the receive buffer is full.  Once full,     *
 *              the data in the register is returned.                   *
 ***********************************************************************/
unsigned char readByte()
{
    if(OERR){
            CREN = 0;
            CREN = 1;
        }
    /* RCIF:    USART receive interrupt flag bit
     * 1:       Buffer is full
     * 0:       Buffer is empty                     */
    while(!RCIF);
        
    // || timeoutCounter < 100){
        //timeoutCounter++;
        //__delay_ms(10);
    //}

    //if(timeoutCounter == 100){
    //    return timeoutByte;
    //}else{
       //Returns the data that is in the receive register
        return RCREG;
    //}
    
}

/************************************************************************
 * Function:    echoBack                                                *
 * Type:        void                                                    *
 * Arguments:   None                                                    *
 * Return:      None                                                    *
 * Purpose:     This function is designed for debugging.  The micro     *
 *              echos back and data is received.                        *
 ***********************************************************************/
void echoBack()
{
    //Create variable to read the data in
    unsigned char ch;
    //Get the RX data
    ch = readByte();
    //Write the RX data to TX
    writeByte(ch);
    //Add a star to verify that it is echoing
    writeByte('*');
}

/************************************************************************
 * Function:    writeString                                             *
 * Type:        void                                                    *
 * Arguments:   userString (unsigned char pointer                       *
 * Return:      None                                                    *
 * Purpose:     Takes a char array and writes each byte to TX.  Writes  *
 *              the length of the data to UART.                         *
 ***********************************************************************/
void writeString(unsigned char* userString)
{
    //Create an int to hold the length
    unsigned int i;
    //Loops through the length of the char array and writes each byte
    for(i = 0;i<strlen(userString);i++){
        writeByte(userString[i]);
    }
    //Write the length counter to UART
    writeByte((unsigned char)i);
    
}
/************************************************************************
 * Function:    readString                                              *
 * Type:        void                                                    *
 * Arguments:   readStorage (unsigned char pointer)                     *
 *              endByte (char)                                          *
 * Return:      None                                                    *
 * Purpose:     Read all the data that is on the RX before the defined  *
 *              end byte (which is adjustable).  Save the length to     *
 *              memory.                                                 *
 ***********************************************************************/
void readString(unsigned char* readStorage)
{
    //i set as a counter for input read
    unsigned int i = 0;
    //Char to hold each byte
    unsigned char ch;
    //Get the first byte
    ch = readByte();
    //Loop through all the data until a end byte is detected
    while(ch != userEndByte)
    {
        //Store each byte into the char array
        readStorage[i] = ch;
        //Increment counter
        i++;
        //Get the next byte
        ch = readByte();
    }
        eeprom_write(RXLenAddr,i);
      
}

/********************************************************************
 * Function:    makeNibble                                          *
 * Type:        unsigned char                                       *
 * Arguments:   tempByte (unsigned char)                            *
 * Return:      Hex value of nibble                                 *
 * Purpose:     Takes a ASCII character and converts it to a hex    *
 *              value.                                              *
 *******************************************************************/
unsigned char makeNibble(unsigned char tempNib)
{
        if(tempNib>='A'){
            return ((tempNib - (unsigned char)'A')+10);
        }
        return (tempNib - '0');
}

/********************************************************************
 * Function:    g2x                                                 *
 * Type:        unsigned char                                       *
 * Arguments:   nibOne (unsigned char)                              *
 *              nibTwo  (unsigned char)                             *
 * Return:      Hex value of byte                                   *
 * Purpose:     To combine two nibbles and make a hex byte out of it*
 *******************************************************************/
unsigned char makeHexByte(unsigned char nibOne, unsigned char nibTwo)
{
    unsigned char input_byte;
    input_byte = (makeNibble(nibOne)<<4);
    input_byte|= makeNibble(nibTwo);
    return input_byte;
}