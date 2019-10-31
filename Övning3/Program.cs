using System;
using System.Collections.Generic;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonHandler personHandler = new PersonHandler();

            personHandler.CreatePerson(20, "Oliver", "Sarholm", 1.83, 83.0);
            personHandler.SetAge(personHandler.GetList()[0], 22);
            Console.WriteLine($"{personHandler.GetList()[0].Age}");
        }
    }
}
