using System;
using System.Collections.Generic;

namespace _2_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Q4 - The List must be Animal if I want to be able to add every single type.
            var li = new List<Animal>();
            var dogs = new List<Dog>();

            li.Add(new Animal());
            li.Add(new Horse());
            li.Add(new Dog());
            li.Add(new Hedgehog());
            li.Add(new Pelican());
            li.Add(new Swan());
            li.Add(new Flamingo());
            li.Add(new Bird());

            //Q3 - It is impossible to add a Horse.class to a list that requires Dog.class, as they both inherit from Animal and not eachother.
            //dogs.Add(new Horse());

            
            //Q5 ?? I get the results because I printed it out?
            foreach (var i in li)
            {
                Console.WriteLine(i.Stats());
                //Q6 i.Speak() does not work as the parent class Animal does not have Speak()
            }


        }
    }
}
