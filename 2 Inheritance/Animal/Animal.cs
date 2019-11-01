using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Inheritance
{

    //Q2 in the Animal.class
    class Animal
    {
        //FIELDS
        private string name;
        private double weight;
        private int age;
        //FIELDS END

        //CONSTRUCTORS
       
        public Animal(string n = "Animal", double w = 0, int a = 0)
        {
            this.name = n;
            this.weight = w;
            this.age = a;
        }
        //CONSTRUCTORS END
        
        //PROPERTIES
        public string Name
        {
            get { return this.GetType().Name; }
            set { name = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        //PROPERTIES END

        //METHODS
        public virtual string Stats()
        {
            return $"Name: {name}\n" +
                $"Weight: {weight}\n" +
                $"Age: {age}\n";
        }

        public virtual string Speak()
        {
            return "Animal spoke";
        }
        //METHODS END

    }
}
