using System;

namespace ConsoleApp286
{
    class Program
    {
        static void Main(string[] args)
        {
            Person empty = new Person();
            Person onlyAge = new Person();
            Person full = new Person();
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            empty.Name = "No name";
            empty.Age = 1;
            onlyAge.Name = "No name";
            onlyAge.Age = age;
            full.Name = name;
            full.Age = age;
            Console.WriteLine($"{empty.Name} {empty.Age}");
            Console.WriteLine($"{onlyAge.Name} { onlyAge.Age}");
            Console.WriteLine($"{full.Name} {full.Age}");
            
        }
    }
}
