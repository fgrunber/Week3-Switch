using System;

namespace GradingIf
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib, mis hinde kasutaja sai
            //Kui kasutaja sai "A", siis konsool kuvab "Suurepärane";
            //Kui kasutaja sai "B", siis konsool kuvab "Väga hea";
            //Kui kasutaja sai "C", siis konsool kuvab "Hea";
            //Kui kasutaja sai "D", siis konsool kuvab "Rahuldav";
            //Kui kasutaja sai "E", siis konsool kuvab "Kasin";
            //Kui kasutaja sai "F", siis konsool kuvab "Puudulik";
            //Kui kasutaja sisestab midagi muud, siis konsool kuvab "Vale väärtus";
            //Kasutame If

            Console.WriteLine("Sisesta oma tulemus:");
            //char - character
            char userResult = Convert.ToChar(Console.ReadLine().ToUpper());

            
            if (userResult == 'A')
            {
                Console.WriteLine("Suurepärane!");
            }
            else if (userResult == 'B')
            {
                Console.WriteLine("Väga hea!");
            }
            else if (userResult == 'C')
            {
                Console.WriteLine("Hea!");
            }
            else if (userResult == 'D')
            {
                Console.WriteLine("Rahuldav!");
            }
            else if (userResult == 'E')
            {
                Console.WriteLine("Kasin!");
            }
            else if (userResult == 'F')
            {
                Console.WriteLine("Puudulik!");
            }
            else 
            {
                Console.WriteLine("Vale väärtus!");
            }
            Console.WriteLine("Kena päeva jätku!");
        }
    }
}
