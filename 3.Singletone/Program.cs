using System;

namespace _3.Singletone
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Singleton
    {
        private static readonly Singleton _instance = new Singleton();


        static Singleton() { }
        private Singleton()
        { }

        public static Singleton GetInstance()
        {
            return _instance;
        }
    }
}
