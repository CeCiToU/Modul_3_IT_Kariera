using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp288
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Engine> engines = new Dictionary<string, Engine>();
            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            for(int i = 0; i < n; i++)
            {
                Engine currentEngine = new Engine();
                string[] engineProperties = Console.ReadLine().Split().ToArray();
                currentEngine.Model = engineProperties[0];
                currentEngine.Power = double.Parse(engineProperties[1]);
                try
                {
                    currentEngine.Displacement = double.Parse(engineProperties[2]);
                }
                catch
                {
                    currentEngine.Displacement = -1;
                }
                if (currentEngine.Displacement == -1)
                {
                    try
                    {
                        currentEngine.Efficiency = engineProperties[2];
                    }
                    catch
                    {
                        currentEngine.Efficiency = "n/a";
                    }
                }
                else
                {
                    try
                    {
                        currentEngine.Efficiency = engineProperties[3];
                    }
                    catch
                    {
                        currentEngine.Efficiency = "n/a";
                    }
                }
                    engines.Add(engineProperties[0], new Engine(currentEngine.Model, currentEngine.Power, currentEngine.Displacement, currentEngine.Efficiency));
            }
            n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Car currentCar = new Car();
                string[] carProperties = Console.ReadLine().Split().ToArray();
                currentCar.Model = carProperties[0];
                currentCar.Engine = carProperties[1];
                try
                {
                    currentCar.Weigth = double.Parse(carProperties[2]);
                }
                catch
                {
                   
                    currentCar.Weigth = -1;
                }
                if (currentCar.Weigth == -1)
                {
                    try
                    {
                        currentCar.Color = carProperties[2];
                    }
                    catch
                    {
                        currentCar.Color = "n/a";
                    }
                }
                else
                {
                    try
                    {
                        currentCar.Color = carProperties[3];
                    }
                    catch
                    {
                        currentCar.Color = "n/a";
                    }
                }
                cars.Add(carProperties[0], new Car(currentCar.Model, currentCar.Engine, currentCar.Weigth, currentCar.Color));
            }
            Console.WriteLine();
            Print(cars, engines);
        }

        private static void Print(Dictionary<string, Car> cars, Dictionary<string, Engine> engines)
        {
           foreach(var car in cars)
            {
                Console.WriteLine($"{car.Key}:");
                Console.WriteLine($"   {car.Value.Engine}:");
                double power = 0;
                double displacement = 0;
                string eff = "n/a";
                foreach(var engine in engines)
                {
                    if(engine.Key == car.Value.Engine)
                    {
                        power = engine.Value.Power;
                        displacement = engine.Value.Displacement;
                        eff = engine.Value.Efficiency;
                        //break;
                    }
                }
                Console.WriteLine($"    Power: {power}");
                if (displacement == -1)
                {
                    Console.WriteLine("   Displacement: n/a");
                }
                else
                {
                    Console.WriteLine($"    Displacement: {displacement}");
                }
                    Console.WriteLine($"    Efficiency: {eff}");
                if (car.Value.Weigth == -1)
                {
                    Console.WriteLine($"    Weigth: n/a");
                }
                else
                {
                    Console.WriteLine($"  Weigth: {car.Value.Weigth}");
                }
                Console.WriteLine($"  Color: {car.Value.Color}");
            }
        }
    }
}
