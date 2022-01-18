using System;

namespace GradingSwitch
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
            //Kasutame Switch

            Console.WriteLine("Sisesta oma tulemus:");
            //char - character
            char userResult = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (userResult)
            {
                case 'A':
                    Console.WriteLine("Suurepärane!");
                    break;
                case 'B':
                    Console.WriteLine("Väga hea!");
                    break;
                case 'C':
                    Console.WriteLine("Hea!");
                    break;
                case 'D':
                    Console.WriteLine("Rahuldav!");
                    break;
                case 'E':
                    Console.WriteLine("Kasin!");
                    break;
                case 'F':
                    Console.WriteLine("Puudulik");
                    break;
                default:
                    Console.WriteLine("Vale väärtus");
                    break;
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
