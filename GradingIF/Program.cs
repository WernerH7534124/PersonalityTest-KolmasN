using System;

namespace GradingIF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tere!");

            //Programm küsib, mis hinde kasutaja sai
            //Hinde A korral kuvab konsool "Suuerpärane!"
            //Hinde B korral kuvab konsool "Väga Hea!"
            //Hinde C korral kuvab konsool "Hea!"
            //Hinde D korral kuvab konsool "Rahuldav"
            //Hinde E korral kuvab konsool "Kasin"
            //Hinde F korral kuvab konsool "Puudulik"
            //Kui kasutaja sisetab midagi muud, kuvab konsool "Vale väärtus"

            //Kasutame IF funktsiooni

            Console.WriteLine("Sisestage oma hinne:");
            char userResult = Convert.ToChar(Console.ReadLine().ToUpper());            
       
            {
                if (userResult == 'A')
                    Console.WriteLine("Suuerpärane!");

                else if (userResult == 'B')
                    Console.WriteLine("Väga Hea!");

                else if (userResult == 'C')
                    Console.WriteLine("Hea!");

                else if (userResult == 'D')
                    Console.WriteLine("Rahuldav");

                else if (userResult == 'E')
                    Console.WriteLine("Kasin");

                else if (userResult == 'F')
                    Console.WriteLine("Puudulik");

                else Console.WriteLine("Vale väärtus!");

                Console.WriteLine("Kena päeva!");
            }

        }
    }
}
