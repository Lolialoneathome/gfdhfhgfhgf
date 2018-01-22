using System;

namespace SampleOOP
{
    //Inheritance
    public class UnicornPony : EarthPony
    {
        //Encapsulation
        protected int _magicEnergy;

        public UnicornPony(int energy)
        {
            _magicEnergy = energy;
        }

        public bool IsHasMagicEnergy => _magicEnergy > 0;

        public override void RunFromEnemies()
        {
            if (IsHasMagicEnergy)
            {
                CastMagic();
                Console.WriteLine("I use teleportation!");
            }
            else
                base.RunFromEnemies();
        }

        public override void TellAboutYourself()
        {
            Console.WriteLine("Hi! I am unicorn pony! ");
        }
         
        public void CastMagic()
        {
            if (_magicEnergy < 0)
                throw new InvalidOperationException("No mana!");

            _magicEnergy -= 1;
        }

        // One magic point restoring on one minute
        public void GetSomeRest(int minutes)
        {
            _magicEnergy += minutes;
        }

    }
}
