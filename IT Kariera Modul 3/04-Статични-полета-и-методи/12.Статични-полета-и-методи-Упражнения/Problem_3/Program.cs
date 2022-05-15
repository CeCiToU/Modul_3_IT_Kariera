using System;
using System.Collections.Generic;

namespace ConsoleApp291
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Converted> converted = new List<Converted>();
            for (int i = 0; i < n; i++)
            {
                Converted currentNum = new Converted();
                currentNum.Num = double.Parse(Console.ReadLine());
                converted.Add(currentNum);
            }
            Console.WriteLine();
            Console.WriteLine(string.Join("\n", converted));
        }
    }
}
