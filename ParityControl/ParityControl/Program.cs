using System;

namespace lab1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Podaj slowo");
            string dane = Console.ReadLine();
            int suma = 0;
            int temp = 0;
            Console.Write("Podales slowo:" + dane + "\nKody ASCII:" );
            foreach (int element in dane)
            {
                Console.Write("\n" + element);
            }
            foreach(int element in dane)
            {
                Console.Write("\n");
                for(int i=7;i>=0;i--)
                {
                    temp = (element>>i)&1;
                    Console.Write(temp);
                    suma = suma ^ temp;
                }
            }
            Console.Write("\nBit parzystosci:" + suma + "\n");
                 
        }
    }
}