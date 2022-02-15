using System;

namespace GradingSwitch
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

            //Kasutame Switch funktsiooni


            Console.WriteLine("Sisestage oma hinne:");
            char userResult = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (userResult)
            {
                case 'A':
                    Console.WriteLine("Suuerpärane!");
                    break;
                case 'B':
                    Console.WriteLine("Väga Hea!");
                    break;
                case 'C':
                    Console.WriteLine("Hea!");
                    break;
                case 'D':
                    Console.WriteLine("Rahuldav");
                    break;
                case 'E':
                    Console.WriteLine("Kasin");
                    break;
                case 'F':
                    Console.WriteLine("Puudulik");
                    break;

                default:
                    Console.WriteLine("Vale väärtus!");
                    break;
            }
            Console.WriteLine("Kena päeva!");

        }
    }
}




            


