using System;
using System.Linq;

namespace _2.PhoneParse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me phone number");
            var phone = Console.ReadLine();

            var clearedPhone =  string.Join("", phone.Where(c => Char.IsDigit(c)).ToArray());

            Console.WriteLine(clearedPhone);
            Console.ReadLine();
        }
    }
}
