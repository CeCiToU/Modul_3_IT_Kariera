using System;
using System.Collections.Generic;

namespace ConsoleApp273
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var group = new SortedDictionary<string, int>();
            Person guy = new Person();
            for(int i = 0; i < num; i++)
            {
                guy.Name = Console.ReadLine();
                guy.Age = int.Parse(Console.ReadLine());
                if (guy.Age > 30)
                {
                    group.Add(guy.Name, guy.Age);
                }
            }
            Console.WriteLine();
            foreach(var name in group)
            {
                Console.Write(name.Key + " - ");
                Console.WriteLine(name.Value);
            }
        }
    }
}
 