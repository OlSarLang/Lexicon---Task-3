using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Inheritance
{
    class Hedgehog : Animal
    {
        private int spikes;
        public Hedgehog(int spikes = 100) : base("Hedgehog", 3, 1)
        {
            this.spikes = spikes;
        }

        public int Spikes
        {
            get { return spikes; }
            set { spikes = value; }
        }

        public override string Stats()
        {
            return $"Name: {Name}\n" +
                $"Weight: {Weight}\n" +
                $"Age: {Age}\n" +
                $"Spikes: {Spikes}\n";
        }

    }
}
