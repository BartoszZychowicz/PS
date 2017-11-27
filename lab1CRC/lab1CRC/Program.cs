using System;
using System.Collections.Generic;

namespace lab1CRC
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int dane = 0xAF;      //binarnie 11010011101110
            int wielomian = 0xB;    //binarnia 1011
            int rozmiar_danych = 8;
            int stopien_CRC = 3;
            int dlugosc_wielomianu = stopien_CRC + 1;
            wielomian = wielomian << (rozmiar_danych - (stopien_CRC + 1));
            int crc = 0;
            int temp;
            Console.Write("Wartosc:" + dane + "\nBinarnie:" );
            for(int i=(rozmiar_danych-1);i>=0;i--)
            {
                temp = (dane>>i)&1;
                Console.Write(temp);
            }
            crc = dane;
            for (int i = 0; i < rozmiar_danych; i++)
            {
                if ((crc & (1<<(rozmiar_danych-1))) != 0)
                {
                    crc = crc ^ wielomian;
                }
                crc = crc << 1;
            }
            Console.Write("\nSuma kontrolna:");
            Console.Write(crc>>(rozmiar_danych-stopien_CRC));

        }
    }
}