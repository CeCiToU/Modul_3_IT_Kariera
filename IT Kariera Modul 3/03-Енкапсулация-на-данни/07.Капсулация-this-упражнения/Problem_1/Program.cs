using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp290
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            SortedDictionary<string, Person> people = new SortedDictionary<string, Person>();
            for(int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                Person currentPerson = new Person(input[0], input[1], int.Parse(input[2]));
                people.Add(input[0] + " " + input[1], currentPerson);
            }
            Console.WriteLine();
            foreach(var name in people)
            {
                Console.WriteLine(string.Join("\n", name.Value));
            }
        }
    }
}
 