/*
 * Mikrocontroller_SendTemperature.c
 *
 * Created: 16.06.2020 18:46:22
 * Author : Simon
 */ 

#define F_CPU 3686400UL
#include <avr/io.h>
#include <util/delay.h>


int main(void)
{
    uint8_t tempHighByte, tempLowByte;
    
    TWBR = 0x0A; // Bitratenregister laden
    TWSR = 0x00; // Vorteiler = 1
    
    DDRD |= (1<<PD2) | (1<<PD3) | (1<<PD4);
    // DDRC = 0x00;
    // PORTC |= (1<<PC4)|(1<<PC5); // Pullup fuer SDA und SCL
    
    UARTInit();
    
    while (1)
    {
	    if(TWI_Start() != 0x08)
	    {
		    PORTD |= (1<<PD2); //Start senden
	    }
	    if(TWI_SLA_W() != 0x18)
	    {
		    PORTD |= (1<<PD2); //SLA+W senden (0x90)
	    }
	    if(TWI_SEND_DATA(0x00) != 0x28)
	    {
		    PORTD |= (1<<PD2); //Send TEMP_REGISTER
	    }
	    if(TWI_Start() != 0x10)
	    {
		    PORTD |= (1<<PD2); //Restart senden
	    }
	    if(TWI_SLA_R() != 0x40)
	    {
		    PORTD |= (1<<PD2); //SLA+R senden (0x90)
	    }
	    
	    tempHighByte = TWI_RECV_ACK(); //Temperatur High-Byte
	    tempLowByte = TWI_RECV_NACK(); //Temperatur Low-Byte
	    
	    TWCR = 0x94; // TWINT = 1, TWSTO = 1 , TWEN = 1
	    
	    UARTPutDecimal(tempHighByte);
	    if(tempLowByte&0x80)
	    {
		    UARTPutChar(0x2E);
		    UARTPutChar(0x35);
	    }
	    else
	    {
		    UARTPutChar(0x2E);
		    UARTPutChar(0x30);
	    }
	    UARTPutChar(0x0D);
	    UARTPutChar(0x0A);
	    
	    _delay_ms(1000);
	    PORTD ^= (1<<PD4);
    }
}

