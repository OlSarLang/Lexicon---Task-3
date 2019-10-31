using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Inheritance
{
    //Q1 If all birds need a new property then it will have to be implemented in the base Bird.class.
    //Q2 in the Animal.class

    class Bird : Animal
    {
        private bool canFly;
        public Bird(bool canFly = true) : base("Bird", 10, 2)
        {
            this.canFly = canFly;
        }
        
        public bool CanFly
        {
            get { return canFly; }
            set { canFly = value; }
        }

        public override string Stats()
        {
            return $"Name: {Name}\n" +
                $"Weight: {Weight}\n" +
                $"Age: {Age}\n" +
                $"Can fly?: {CanFly}\n";
        }
    }

    class Pelican : Bird
    {
        private int eyes;
        public Pelican(int eyes = 2) : base(true)
        {
            Name = "Pelican";
            this.eyes = eyes;
        }
        public int Eyes
        {
            get { return eyes; }
            set { eyes = value; }
        }

        public override string Stats()
        {
            return $"Name: {Name}\n" +
                $"Weight: {Weight}\n" +
                $"Age: {Age}\n" +
                $"Can fly?: {CanFly}\n" +
                $"Eyes: {Eyes}\n";
        }
    }

    class Flamingo : Bird
    {
        private bool bigBeak;
        public Flamingo(bool bigBeak = true) : base(false)
        {
            Name = "Flamingo";
            this.bigBeak = bigBeak;
        }
        public bool BigBeak
        {
            get { return bigBeak; }
            set { bigBeak = value; }
        }
        public override string Stats()
        {
            return $"Name: {Name}\n" +
                $"Weight: {Weight}\n" +
                $"Age: {Age}\n" +
                $"Can fly?: {CanFly}\n" +
                $"Big beak?: {BigBeak}\n";
        }

    }

    class Swan : Bird
    {
        private string color;
        public Swan(string color = "white") : base(true)
        {
            Name = "Swan";
            this.color = color;
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public override string Stats()
        {
            return $"Name: {Name}\n" +
                $"Weight: {Weight}\n" +
                $"Age: {Age}\n" +
                $"Can fly?: {CanFly}\n" +
                $"Color: {Color}\n";
        }
    }
}
