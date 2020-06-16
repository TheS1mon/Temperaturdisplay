/*
 * I2C.c
 *
 * Created: 16.06.2020 19:03:49
 *  Author: Simon
 */

#include <avr/io.h>

uint8_t TWI_Start()
{
	TWCR =0b10100100; // TWINT=1, TWSTA=1, TWEN=1
	while(!(TWCR&(1<<TWINT))); // warte auf TWINT=1
	return(TWSR&0xf8); // Status zurueckgeben
}

uint8_t TWI_SLA_R()
{
	TWDR = 0b10010001; // Slave-Adresse 0x90+W
	TWCR = 0b10000100; // TWINT = 1, TWEN = 1
	while(!(TWCR & (1<<TWINT))); // warte auf TWINT = 1
	return (TWSR & 0xF8); // Status zurueckgeben
}

uint8_t TWI_SLA_W()
{
	TWDR = 0b00000010; // Slave-Adresse 0x01+W
	TWCR = 0b10000100; // TWINT=1,TWEN=1
	while(!(TWCR&(1<<TWINT))); // warte auf TWINT=1
	return(TWSR&0xF8); // Status zurueckgeben
}

uint8_t TWI_SEND_DATA(uint8_t data)
{
	TWDR = data;
	TWCR = 0b10000100; // TWINT = 1, TWEN = 1
	while(!(TWCR&(1<<TWINT))); // warte auf TWINT = 1
	return (TWSR&0xF8); // Status zurueckgeben
}

uint8_t TWI_RECV_ACK()
{
	TWCR = 0b11000100; // TWINT = 1, TWEA = 1 , TWENT = 1
	while(!(TWCR&(1<<TWINT)));
	return (TWDR); // Daten zurueckgeben
}

uint8_t TWI_RECV_NACK()
{
	TWCR = 0b10000100; // TWINT = 1, TWEN = 1
	while(!(TWCR & (1<<TWINT))); // warte auf TWINT = 1
	return (TWDR); // Daten zurueckgeben
}