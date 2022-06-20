using System;

namespace ConsoleApp308
{
    internal class Car
    {
        private string model;
        private double fuel;
        private double usedFuel;
        private double kmInTotal;

        public Car(string models, double fuels, double usedFuels)
        {
            Model = models;
            Fuel = fuels;
            usedFuel = usedFuels;
        }

        public string Model { get => model; set => model = value; }
        public double Fuel { get => fuel; set => fuel = value; }
        public double UsedFuel { get => usedFuel; set => usedFuel = value; }
        public double KmInTotal { get => kmInTotal; set => kmInTotal = value; }

        internal void Drive(double km)
        {

            if(fuel < km * usedFuel)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                fuel -= km * usedFuel;
                KmInTotal += km;
            }
        }

        public override string ToString()
        {
            return $"{Model} {Fuel:F2} {KmInTotal}";
        }
    }
}