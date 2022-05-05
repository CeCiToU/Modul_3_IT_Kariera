using System;
using System.Collections.Generic;

namespace ConsoleApp272
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var family = new SortedDictionary<string, int>();
            for (int i = 0; i < num; i++)
            {
                Person current = new Person();
                current.Name = Console.ReadLine();
                current.Age = int.Parse(Console.ReadLine());
                family.Add(current.Name, current.Age);
            }
            foreach (var name in family)
            {
                Console.Write(name.Key + " ");
                Console.WriteLine(name.Value);
            }
            //Family family = new Family();

        }
    }
}
