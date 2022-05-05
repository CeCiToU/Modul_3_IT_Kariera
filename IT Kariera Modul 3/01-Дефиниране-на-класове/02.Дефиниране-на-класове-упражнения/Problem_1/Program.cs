
using System;

namespace ConsoleApp271
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Person firstGuy = new Person();
            Person secondGuy = new Person();
            person.Name = "Pesho";
            firstGuy.Name = "Gosho";
            secondGuy.Name = "Stamat";
            person.Age = 20;
            firstGuy.Age = 18;
            secondGuy.Age = 43;
            Console.WriteLine(person.Name + " " + person.Age);
            Console.WriteLine(firstGuy.Name + " " + firstGuy.Age);
            Console.WriteLine(secondGuy.Name + " " + secondGuy.Age);
        }
    }
}
