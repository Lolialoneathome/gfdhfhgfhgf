using System;

namespace SampleOOP
{
    public class EarthPony : ILittlePony
    {
        public string Color { get; set; }
        public string Name { get; set; }
        //Other common props

        public virtual void RunFromEnemies()
        {
            Console.WriteLine("I running on the ground using my hooves");
        }

        public virtual void TellAboutYourself()
        {
            Console.WriteLine("Hi! I am earth pony! ");
        }
    }
}
