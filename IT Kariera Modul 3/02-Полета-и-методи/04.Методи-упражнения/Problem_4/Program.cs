

using System;
using System.Linq;

namespace ConsoleApp281
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
                string[] currentProfil = Console.ReadLine().Split().ToArray();
                person.Name = currentProfil[0];
                person.Age = int.Parse(currentProfil[1]);
                family.AddFamily(person);
            }
            Console.WriteLine();
            Console.WriteLine(family.GetOldestMember());
        }
    }
}
