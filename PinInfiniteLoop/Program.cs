using System;

namespace PinInfiniteLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loopActive = true;
            int i = 0;
            while (loopActive)
            {
                Console.WriteLine("Sisesta PIN:");
                int userPin = Convert.ToInt32(Console.ReadLine());
                if(userPin == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    loopActive = false;
                }
                else
                {
                    i++; 
                    Console.WriteLine("Vale PIN. Proovi uuesti!");
                    Console.WriteLine($"Oled vale PIN-koodi {i} korda sisestanud.");
                }
            }
            Console.WriteLine("Kena päeva!");
        }

    }
}
