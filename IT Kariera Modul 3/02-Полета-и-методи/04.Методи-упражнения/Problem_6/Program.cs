using System;
using System.Linq;

namespace ConsoleApp282
{
    class Program
    {
        static void Main(string[] args)
        {
            DateModifier dates = new DateModifier();
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();
            dates.FirstDate = DateTime.ParseExact(firstDate, "yyyy MM dd", null);
            dates.SecondDate = DateTime.ParseExact(secondDate, "yyyy MM dd", null);
            dates.Substract();
            
        }
    }
}
