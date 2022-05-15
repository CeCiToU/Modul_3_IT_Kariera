using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp297
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();
            //Products product = new Products();
            List<Person> people = new List<Person>();
            List<Products> products = new List<Products>();
            string[] peopleForAdding = Console.ReadLine().Split('=', ';').ToArray();
            string[] productsForAdding = Console.ReadLine().Split('=', ';').ToArray();


            for (int i = 0; i <= peopleForAdding.Length / 2; i += 2)
            {
                try
                {
                    Person currentPerson = new Person(peopleForAdding[i], double.Parse(peopleForAdding[i + 1]));
                    people.Add(currentPerson);
                }
                catch (ArgumentException argEx)
                {
                    Console.WriteLine(argEx.Message);
                }
                   
            }


            for (int i = 0; i <= productsForAdding.Length / 2; i += 2)
            {
                try
                {
                    Products currentProduct = new Products(productsForAdding[i], double.Parse(productsForAdding[i + 1]));
                    products.Add(currentProduct);
                }
                catch (ArgumentException argEx)
                {
                    Console.WriteLine(argEx.Message);
                }
            }

            while (true)
            {
                string[] buying = Console.ReadLine().Split().ToArray();
                if (buying[0] == "END")
                {
                    break;
                }
                for (int i = 0; i < people.Count; i++)
                {
                    double price = 0;
                    double money = 0;
                    if (people[i].Name == buying[0])
                    {
                        for (int j = 0; j < products.Count; j++)
                        {
                            if (products[i].Name == buying[1])
                            {
                                price = products[j].Cost;
                                money = people[i].Money;
                                if (money < price)
                                {
                                    Console.WriteLine($"{people[i].Name} can't afford {products[j].Name}");
                                }
                                else
                                {
                                    Console.WriteLine($"{people[i].Name} bought {products[j].Name}");
                                    money = money - price;
                                    people[i].Money = money;
                                    people[i].Bag.Add(products[j].Name);
                                    break;
                                }
                            }
                        }
                        break;

                    }
                }
            }
            for (int i = 0; i < people.Count; i++)
            {
                if (people[i].Bag.Count == 0)
                {
                    Console.WriteLine($"{people[i].Name} - Nothing bought");
                }
                else
                {
                    Console.WriteLine($"{people[i].Name} - " + string.Join(", ", people[i].Bag));
                }
                }
            }
    }
}
