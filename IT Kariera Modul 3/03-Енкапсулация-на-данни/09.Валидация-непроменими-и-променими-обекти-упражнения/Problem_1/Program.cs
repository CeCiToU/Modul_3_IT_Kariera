using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp294
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int bonusSalary = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                try
                {
                    Person currentPerson = new Person(input[0], input[1], int.Parse(input[2]), double.Parse(input[3]), bonusSalary);
                    people.Add(currentPerson);
                }
                catch(ArgumentException argEx)
                {
                    Console.WriteLine();
                    Console.WriteLine(argEx.Message);
                }
                    
            }
            Console.WriteLine();
            for (int i = 0; i < people.Count; i++)
            {
                Console.WriteLine(people[i]);
            }
        }
    }
}
