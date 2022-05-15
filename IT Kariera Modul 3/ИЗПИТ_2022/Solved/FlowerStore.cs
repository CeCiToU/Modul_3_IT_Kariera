using System;
using System.Collections.Generic;

namespace RegularExam
{
    internal class FlowerStore
    {
        private string name;
        private List<Flower> flowers = new List<Flower>();
        public FlowerStore(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length < 6)
                {
                    throw new ArgumentException("Invalid flower store name!");
                }
                name = value;
            }
        }

        public void AddFlower(Flower flower)
        {
            flowers.Add(flower);
        }

        public bool SellFlower(Flower flower)
        {
            bool check = false;
            for (int i = 0; i < flowers.Count; i++)
            {
                if (flowers[i].ToString() == flower.ToString())
                {
                    flowers.RemoveAt(i);
                    check = true;
                    break;
                }
            }
            return check;

        }

        public double CalculateTotalPrice()
        {
            double sum = 0;
            for (int i = 0; i < flowers.Count; i++)
            {
                sum += flowers[i].Price;
            }
            return sum;
        }

        public Flower GetFlowerWithHighestPrice()
        {
            Flower flowerWithHighestPrice = new Flower();
            double highestPrice = double.MinValue;
            for(int i = 0; i < flowers.Count; i++)
            {
                if(flowers[i].Price > highestPrice)
                {
                    highestPrice = flowers[i].Price;
                    flowerWithHighestPrice = new Flower(flowers[i].Type, flowers[i].Color, highestPrice);
                }
            }
            return flowerWithHighestPrice;
        }

        public Flower GetFlowerWithLowestPrice()
        {
            Flower flowerWithLowestPrice = new Flower();
            double lowestPrice = double.MaxValue;
            for (int i = 0; i < flowers.Count; i++)
            {
                if (flowers[i].Price < lowestPrice)
                {
                    lowestPrice = flowers[i].Price;
                    flowerWithLowestPrice  = new Flower(flowers[i].Type, flowers[i].Color, lowestPrice);
                }
            }
            return flowerWithLowestPrice;
        }

        public void RenameFlowerStore(string newName)
        {
            Name = newName;
        }

        public void SellAllFlowers()
        {
            flowers.Clear();
        }

        public override string ToString()
        {
            if(flowers.Count == 0)
            {
                return $"Flower store {Name} has no available flowers";
            } 
            else
            {
                return $"Flower store {Name} has {flowers.Count} flower/s:\n{string.Join("\n", flowers)}";
            }
            
        }
    }
}