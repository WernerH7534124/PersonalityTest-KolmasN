using System;

namespace PersonalityTestSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tere");

            //Programm küsib kasutaja lemmikvärvi;
            //vastus "punane" kuvab konsoolis: "Oled Võrratu ja Romantiline!";
            //vastus "sinine" kuvab konsoolis: "Oled Töökas ja Tubli!";
            //vastus "roheline" kuvab konsoolis: "Oled Looduse Parim Sõber!";
            //muud vastused kuvavad konsoolis: "Oled unikaalne {userColor} ükssarvik!"

            Console.WriteLine("Sisestage oma lemmikvärv: ");
            string userColor = Console.ReadLine().ToLower();

            switch (userColor)
            {

                case "punane":
                    Console.WriteLine("Oled Võrratu ja Romantiline!");
                    break;
                case "sinine":
                    Console.WriteLine("Oled Töökas ja Tubli!");
                    break;
                case "roheline":
                    Console.WriteLine("Oled Looduse Parim Sõber!");
                    break;
                default:
                    Console.WriteLine($"Oled unikaalne {userColor} ükssarvik!");
                    break;

               
                        }

            Console.WriteLine("Kena päeva taaskord!");

        }
    }

}
