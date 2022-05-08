using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp285
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                Car currentCar = new Car();
                string[] input = Console.ReadLine().Split().ToArray();
                currentCar.Model = input[0];
                currentCar.Fuel = double.Parse(input[1]);
                currentCar.FuelUse = double.Parse(input[2]);
                cars.Add(currentCar);

            }
            string[] command = Console.ReadLine().Split().ToArray();
            while (command[0] != "End" )
            {
                if(command[0] == "Drive")
                {
                    for(int i = 0; i < cars.Count; i++)
                    {
                        if(cars[i].Model == command[1])
                        {
                            Drive(cars, i, cars[i].Model, double.Parse(command[2]), cars[i].FuelUse);
                        }
                    }
                }
                command = Console.ReadLine().Split().ToArray();
            }
            Print(cars);
        }

        private static void Print(List<Car> cars)
        {
            for (int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine(cars[i]);
            }
        }
        private static void Drive(List<Car> cars, int i, string model, double km, double use)
        {
            double currentFuelNeed = use * km;
            if(cars[i].Fuel < currentFuelNeed)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                cars[i].Fuel -= currentFuelNeed;
                cars[i].KM += km;
            }
            
        }
    }
}
