using System.Collections.Generic;
using System;

namespace ConsoleApp297
{
    internal class Person
    {
        private string name;
        private double money;
        private List<string> bag = new List<string>();

        public string Name
        {
            get { return name; }
            set
            {
                if (value == "" || value == " ")
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }
        }

        public double Money
        {
            get { return money; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value;
            }
        }

        public List<string> Bag
        {
            get { return bag; } 
            set { bag = value; }
        }


        public Person(string name, double money)
        {
            Name = name;
            Money = money;
        }
    }
}