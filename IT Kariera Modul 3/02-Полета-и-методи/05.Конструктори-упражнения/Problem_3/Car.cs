using System;
using System.Collections.Generic;

namespace ConsoleApp287
{
    internal class Car
    {
        private string model;
        private int endineSpeed;
        private int hp;
        private int weight;
        private string type;
        private double KpAFirstTyre;
        private int firstTyreOld;
        private double KpASecondTyre;
        private int secondTyreOld;
        private double KpAThirdTyre;
        private int thirdTyreOld;
        private double KpALastTyre;
        private int lastTyreOld;

        public string Model { get => model; set => model = value; }
        public int EndineSpeed { get => endineSpeed; set => endineSpeed = value; }
        public int Hp { get => hp; set => hp = value; }
        public int Weight { get => weight; set => weight = value; }
        public string Type { get => type; set => type = value; }
        public double KPAFirstTyre1 { get => KpAFirstTyre; set => KpAFirstTyre = value; }
        public int FirstTyreOld { get => firstTyreOld; set => firstTyreOld = value; }
        public double KPASecondTyre1 { get => KpASecondTyre; set => KpASecondTyre = value; }
        public int SecondTyreOld { get => secondTyreOld; set => secondTyreOld = value; }
        public double KPAThirdTyre1 { get => KpAThirdTyre; set => KpAThirdTyre = value; }
        public int ThirdTyreOld { get => thirdTyreOld; set => thirdTyreOld = value; }
        public double KPALastTyre1 { get => KpALastTyre; set => KpALastTyre = value; }
        public int LastTyreOld { get => lastTyreOld; set => lastTyreOld = value; }
        static  void Fragile(List<Car> cars)
        {
            for(int i = 0; i < cars.Count; i++)
            {
                if (cars[0].Type == "fragile")
                {
                    Print(cars[0].Model);
                }
            }
        }

        private static void Print(string model)
        {
            Console.WriteLine(model);
        }
    }
}