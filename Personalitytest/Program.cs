using System;

namespace Personalitytest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            //Programm küsib kasutaja lemmikvärvi;
            //vastus "punane" kuvab konsoolis: "Oled Võrratu ja Romantiline!";
            //vastus "sinine" kuvab konsoolis: "Oled Töökas ja Tubli!";
            //vastus "roheline" kuvab konsoolis: "Oled Looduse Parim Sõber!";
            //muud vastused kuvavad konsoolis: "Oled unikaalne {userColor} ükssarvik"

            Console.WriteLine("Sisestage oma lemmikvärv: ");
            string userColor = Console.ReadLine();

            if (userColor == "punane")
                Console.WriteLine("Oled Võrratu ja Romantiline!");

            else if (userColor == "sinine")
                Console.WriteLine("Oled Töökas ja Tubli!");

            else if (userColor == "roheline")
                Console.WriteLine("Oled Looduse Parim S6ber!");

            else
                Console.WriteLine($"Oled unikaalne {userColor} ükssarvik");

            Console.WriteLine("Kena päeva!");

        }
    }
}
