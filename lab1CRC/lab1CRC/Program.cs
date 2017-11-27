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
            wielomian = wielomian << (rozmiar_danych - (stopien_CRC + 1));    //przesuniecie wielomianu
            int crc;    //inicjalizacja sumy kontrolnej
            int temp;    //zmienna tymczasowa
            
            Console.Write("Wartosc:" + dane + "\nBinarnie:" );
            for(int i=(rozmiar_danych-1);i>=0;i--)        //wypisanie postaci binarnej danych
            {
                temp = (dane>>i)&1;
                Console.Write(temp);
            }
            crc = dane;    //pierwsza wartosc crc rowna danym wejsciowym
            for (int i = 0; i < rozmiar_danych; i++)
            {
                if ((crc & (1<<(rozmiar_danych-1))) != 0)    //jezeli MSB danych to 1
                {
                    crc = crc ^ wielomian;    //XOR wielomianu i danych
                }
                crc = crc << 1;    //przesuniecie w celu XORowanie kolejnego bitu
            }
            Console.Write("\nSuma kontrolna:");
            Console.Write(crc>>(rozmiar_danych-stopien_CRC));    //tylko pozycje znaczace sumy kontrolnej

        }
    }
}