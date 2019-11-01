using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    class Person
    {
        private int age;
        private string fName;
        private string iName;
        private double height;
        private double weight;

      

        public Person(int age, string fName, string iName, double height, double weight)
        {
            this.age = age;
            this.fName = fName;
            this.iName = iName;
            this.height = height;
            this.weight = weight;
        }


        //Q1 - It is possible for me to directly access the variables

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string FName
        {
            get { return fName; }
            set { fName = value; }
        }
        public string IName
        {
            get { return iName; }
            set { iName = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
    }
}
