using System;
using System.Collections.Generic;

namespace _3_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {

            //Q1 - Polymorphism is important because it allows us to share a lot of functionality between subclasses that inherit from a parent. 
            //     Instead of creating two different, almost identical classes, we can create on class that holds everything that they share and then create 2 subclasses.
            //Q2 - See Q1.
            //Q3 - An Abstract class can have its own fields and methods, while an Interface acts more like a blueprint for what methods needs to be in the classes that implements it.

            List<UserError> uE = new List<UserError>();
            uE.Add(new NumericInputError());
            uE.Add(new TextInputError());
            uE.Add(new NumericInputError());
            uE.Add(new TextInputError());
            uE.Add(new NumericInputError());
            uE.Add(new TextInputError());
            uE.Add(new NumericInputError());
            uE.Add(new TextInputError());

            foreach (var error in uE)
            {
                error.UEMessage();
            }

        }
    }
}
