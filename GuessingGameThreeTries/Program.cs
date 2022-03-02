using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            int i = 0;
            while (i < 3)
            {
                Console.WriteLine("Arva number ära!");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                if (userNumber == cpuNumber)
                {
                    Console.WriteLine("Arvasid Õigesti!");
                    break;

                }
                else
                {
                    i++;
                    Console.WriteLine($"Arvasid valesti! {3 - i} katset on jäänud!");
                }
            }
        }
    }
}
