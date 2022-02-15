using System;

namespace CatsAndDogs_Iseseisev2
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("Are you more like a cat or a dog?");
                string userChoice = Console.ReadLine().ToUpper();

                    //String puhul pole tarvis "char" kasutada
                    //Lisatud sulud ReadLine lõpus
                    //Lisatud ToUpper funktsioon

                if (userChoice == "CAT")
               
                    Console.WriteLine("You are a home-lover.");
                
                else if (userChoice == "DOG")

                     //sõna Dog asendatud suurte tähtedega - DOG
                     //Lisatud topelt võrdusmärk "=="
                     //jooksvalt koodis kasutan "else if"

                    Console.WriteLine("You are a partygoer.");

                else

                      //kõige viimasena kasutan "else", mitte "else if"

                    Console.WriteLine($"You are a {userChoice}s friend.");

                       //eemaldatud üleliigsed sulud
                       //asendatud valed sulud "userChoice" ümber

            Console.WriteLine("Have a lovely day!");
        }
    }
}










