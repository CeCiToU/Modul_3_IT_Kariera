using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp308
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int numOfCars = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfCars; i++)
            {
                string[] info = Console.ReadLine().Split().ToArray();
                Car currentCar = new Car(info[0], double.Parse(info[1]), double.Parse(info[2]));
                cars.Add(currentCar);
            }
            string[] command = Console.ReadLine().Split().ToArray();
            while (command[0] != "End")
            {
                if (command[0] == "Drive")
                {
                    for (int i = 0; i < cars.Count; i++)
                    {
                        if (cars[i].Model == command[1])
                        {
                            try
                            {
                                cars[i].Drive(double.Parse(command[2]));

                            }
                            catch(ArgumentOutOfRangeException)
                            {
                                Console.WriteLine("Insufficient fuel for the drive!");
                            }
                            break;
                        }
                    }
                }
                command = Console.ReadLine().Split().ToArray();
            }

            Console.WriteLine(string.Join("\n", cars));
        } 
    }
}
