using System;

namespace _6.UshastyiDog
{
    class Program
    {

        static void Main(string[] args)
        {
            UshastijDog dog = null;
            try
            {
                dog.BeHappy();
                Console.Write("I`m happy!");
            }
            catch (Exception err) {
                Console.Write("I`m sad");
            }

            Console.ReadLine();
        }
    }

    public class UshastijDog
    {

    }

    public static class DogExtension
    {
        public static void BeHappy(this UshastijDog dog)
        {
            //Console.WriteLine("Happy Extension");
        }
    }
}
