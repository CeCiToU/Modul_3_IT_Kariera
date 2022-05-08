using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp283
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < n; i++)
            {
                Person person = new Person();
                string[] input = Console.ReadLine().Split(' ').ToArray();
                person.Name = input[0];
                person.Age = int.Parse(input[1]);
                family.AddMember(person);
            }
            List<string> peoples = family.TakeGreaterThan30();
            Console.WriteLine();
            Console.WriteLine(string.Join("\n", peoples));
        }
    }
}
