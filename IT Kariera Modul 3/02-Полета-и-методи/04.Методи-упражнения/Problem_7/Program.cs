using System;
using System.Linq;

namespace ConsoleApp284
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccaount bancAcc = new BankAccaount();
            string[] command = Console.ReadLine().Split().ToArray();
            while (command[0] != "END")
            {
                if(command[0] == "Create")
                {
                   bancAcc.Create(int.Parse(command[1])); 
                }
                else if(command[0] == "Deposit")
                {
                    bancAcc.Deposit(int.Parse(command[1]), int.Parse(command[2]));
                }
                else if(command[0] == "Withdraw")
                {
                    bancAcc.Withdraw(int.Parse(command[1]), int.Parse(command[2]));
                }
                else if (command[0] == "Print")
                {
                    bancAcc.Print(int.Parse(command[1]));
                }
                command = Console.ReadLine().Split().ToArray();
            }

        }
    }
}
