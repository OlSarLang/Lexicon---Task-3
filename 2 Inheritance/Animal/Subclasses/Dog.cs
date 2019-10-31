using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Inheritance
{
    class Dog : Animal
    {
        private string race;
        public Dog(string race = "Labrador") : base("Dog", 60, 5)
        {
            this.race = race;
        }
        public string Race
        {
            get { return race; }
            set { race = value; }
        }

        public override string Stats()
        {
            return $"Name: {Name}\n" +
                $"Weight: {Weight}\n" +
                $"Age: {Age}\n" +
                $"Race: {Race}\n" +
                $"{Speak()}\n";
        }

        public override string Speak()
        {
            return "Woff!";
        }
    }
}
