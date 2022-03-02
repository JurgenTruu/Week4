using System;

namespace LoopsAndRandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada Pin-koodi
            //programm võrdleb sisestatud pin koodi arvuga 1234
            //kui sisestatud PIN on 1234, siis konsool kuvab "Tere tulemast!"
            //kui sisestatud PIN on midagi muud, siis konsool kuvab "Vale PIN. Proovi uuesti";

            int i = 0;
            while (i < 3)
            {
                Console.WriteLine("Sisesta PIN:");
                int userPin = Convert.ToInt32(Console.ReadLine());
                if (userPin == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine($"Vale PIN. {3 - i} katset on jäänud.");
                }
                
            }
            Console.WriteLine("Kena päeva");


        

        }
    }
}
