
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp276
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            Employee adder = new Employee();
            var accounts = new Dictionary<string, List<Employee>>();
            for (int i = 0; i < peopleCount; i++)
            {
                string[] currentProfil = Console.ReadLine().Split().ToArray();
                string name = currentProfil[0];
                double payment = double.Parse(currentProfil[1]);
                string position = currentProfil[2];
                string department = currentProfil[3];
                string email = "n/a";
                int age = -1;
                if (currentProfil.Length > 4)
                {
                    try
                    {
                        age = int.Parse(currentProfil[4]);
                    }
                    catch
                    {
                        email = currentProfil[4];
                    }
                    try
                    {
                        age = int.Parse(currentProfil[5]);
                    }
                    catch
                    {
                        age = -1;
                    }
                }
                if (!accounts.ContainsKey(department))
                {
                    accounts.Add(department, new List<Employee>());
                }
                Employee currentEmployee = new Employee();
                currentEmployee.Name = name;
                currentEmployee.Payment = payment;
                currentEmployee.Position = position;
                currentEmployee.Department = department; 
                currentEmployee.Email = email;
                currentEmployee.Age = age;


                accounts[department].Add(currentEmployee);

            }
            Console.WriteLine();
            PrintResult(accounts);

        }

        private static void PrintResult(Dictionary<string, List<Employee>> accounts)
        {
            Dictionary<string, List<Employee>> keyValuePair = accounts
                .OrderByDescending(x => x.Value
                .Average(acc => acc.Payment))
                .Take(1)
                .ToDictionary(x => x.Key, x => x.Value);
            Console.WriteLine($"Highest Average Salary: {keyValuePair.First().Key}");
            Console.WriteLine(string.Join("\n", keyValuePair.First().Value.OrderByDescending(x => x.Payment)));
        }
    }
}
