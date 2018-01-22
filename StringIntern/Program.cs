using System;
using System.Collections.Generic;

namespace StringIntern
{
    class Program
    {
        static void Main(string[] args)
        {
            var internalStr = "interned string";
            Console.WriteLine(ReferenceEquals(internalStr, "interned string"));

            var notInterned = string.Join(" ", new List<string>() { "interned", "string" });

            Console.WriteLine(ReferenceEquals(internalStr, notInterned));

            notInterned = String.Intern(notInterned);
            Console.WriteLine(ReferenceEquals(internalStr, notInterned));
            Console.ReadLine();

        }
    }
}
