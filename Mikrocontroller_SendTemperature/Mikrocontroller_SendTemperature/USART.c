/*
 * USART.c
 *
 * Created: 16.06.2020 19:12:53
 *  Author: Simon
 */ 

#include <avr/io.h>

void UARTInit()
{
	UBRRL = 0x17; // 9600 Baudrate
	UCSRB = 0x18; // RXEN = 1 , TXEN = 1
	UCSRC = 0x86; // Async Mode keine Paritaet, 8Datenbit 1 Stopbit
}
void UARTPutChar(uint8_t val)
{
	while(!(UCSRA&(1<<UDRE))); // warte auf freies Senderegister
	UDR = val; // sende Daten
}
void UARTPutDecimal(uint8_t byte)
{
	UARTPutChar(0x30 + (byte / 100));
	UARTPutChar(0x30 + ((byte/10)% 10)); // Zehner
	UARTPutChar(0x30 + (byte % 10)); // Einer
}
void UARTPutBinary(uint8_t byte)
{
	uint8_t bit;
	
	for(bit = 7 ; bit < 255; bit--)
	{
		if(byte&(1<<bit))
		UARTPutChar('1');
		else
		UARTPutChar('0');
	}
}