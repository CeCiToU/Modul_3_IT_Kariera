using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp287
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                Car car = new Car();
                car.Model = input[0];
                car.EndineSpeed = int.Parse(input[1]);
                car.Hp = int.Parse(input[2]);
                car.Weight = int.Parse(input[3]);
                car.Type = input[4];
                car.KPAFirstTyre1 = double.Parse(input[5]);
                car.FirstTyreOld = int.Parse(input[6]);
                car.KPASecondTyre1 = double.Parse(input[7]);
                car.SecondTyreOld = int.Parse(input[8]);
                car.KPAThirdTyre1 = double.Parse(input[9]);
                car.ThirdTyreOld = int.Parse(input[10]);
                car.KPALastTyre1 = double.Parse(input[11]);
                car.LastTyreOld = int.Parse(input[12]);
                cars.Add(car);
            }
            string command = Console.ReadLine();
            Console.WriteLine();
            if (command == "fragile")
            {
                Fragile(cars);
            }
            else if (command == "flamable")
            {
                Flamable(cars);
            }
        }

        private static void Flamable(List<Car> cars)
        {
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].Type == "flamable")
                {
                   if(cars[i].Hp > 250)
                    {
                        Print(cars[i].Model);
                    }
                }
            }
        }
        static void Fragile(List<Car> cars)
        {
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].Type == "fragile")
                {
                    if(cars[i].KPAFirstTyre1 < 1.0 || cars[i].KPASecondTyre1 < 1.0 || cars[i].KPAThirdTyre1 < 1.0 || cars[i].KPALastTyre1 < 1.0)
                    {
                        Print(cars[i].Model);
                    }
                }
            }
        }

        private static void Print(string model)
        {
            Console.WriteLine(model);
        }
    }
}
