using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Inheritance
{
    class Horse : Animal
    {
        private int legs;

        public Horse(int legs = 4) : base("Horse", 400, 13)
        {
            this.legs = legs;
            
        }

        public int Legs
        {
            get { return legs; }
            set { legs = value; }
        }

        public override string Stats()
        {
            return $"Name: {Name}\n" +
                $"Weight: {Weight}\n" +
                $"Age: {Age}\n" +
                $"Legs: {Legs}\n";
        }

    }
}
