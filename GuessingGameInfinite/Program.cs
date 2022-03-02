using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbri 1-10;
            //kasutaja peab selle numbri ära arvama;
            //kui kasutaja suutis selle numbri ära arvata, siis ta on mängu võitnud;
            //katsete arv on piiramatu;
            // programm genereerib juhusliku numbri ühe korra
            
            bool loopActive = true;
            
            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            while (loopActive)
            {
                Console.WriteLine("Arva number ära!");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                if(userNumber == cpuNumber)
                {
                    Console.WriteLine("Number on õige!");
                    loopActive = false;
                }
                
            }
        }
    }
}
