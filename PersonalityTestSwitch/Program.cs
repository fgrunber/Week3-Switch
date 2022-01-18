using System;

namespace PersonalityTestSwitch
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
            string userColor = Console.ReadLine().ToLower();

            switch (userColor)
            {
                case "punane":  //if(userColor == "punane")
                    Console.WriteLine("Oled romantiline");
                    break;
                case "sinine":
                    Console.WriteLine("Oled töökas.");
                    break;
                case "roheline":
                    Console.WriteLine("Oled looduse sõber.");
                    break;
                default:
                    Console.WriteLine($"Oled {userColor} ükssarvik");
                    break;
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
