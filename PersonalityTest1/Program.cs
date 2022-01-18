using System;

namespace PersonalityTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm palub kasutajal sisestada tema lemmikvärvi;
            //Kui kasutaja sisestab "punane", siis konsool kuvab "oled romantiline";
            //Kui kasutaja sisestab "sinine", siis konsool kuvab "oled töökas"; 
            //Kui kasutaja sisestab "roheline", siis konsool kuvab "oled looduse sõber";
            //Kui kasutaja sisestab midagi muud, siis konsool kuvab "oled {userColor} ükssarvik";

            Console.WriteLine("Sisesta oma lemmikvärv");
            string userColor = Console.ReadLine();

            if (userColor == "punane")
            {
                Console.WriteLine("Oled romantiline.");
            }
            else if (userColor == "sinine")
            {
                Console.WriteLine("Oled töökas.");
            }
            else if (userColor == "roheline")
            {
                Console.WriteLine("Oled looduse sõber.");
            }
            else
            {
                Console.WriteLine($"Oled {userColor} ükssarvik.");
            }

            Console.WriteLine("Kena päeva jätku!")
        }
    }
}
