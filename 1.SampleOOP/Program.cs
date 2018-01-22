using SampleOOP;
using System;

namespace _1.SampleOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var appleJack = new EarthPony();
            var twilight = new UnicornPony(3); //create unicorn with 3 points of magic energy

            //Ponies want greet you!

            appleJack.TellAboutYourself();
            twilight.TellAboutYourself();

            Console.WriteLine();
            Console.WriteLine("Oh no! I see enemies! We must run!");
            Console.WriteLine();

            Run(appleJack);
            Run(twilight);

            Console.ReadLine();
        }

        //Polymorphism
        static void Run(ILittlePony pony)
        {
            pony.RunFromEnemies();
        }
    }
}
