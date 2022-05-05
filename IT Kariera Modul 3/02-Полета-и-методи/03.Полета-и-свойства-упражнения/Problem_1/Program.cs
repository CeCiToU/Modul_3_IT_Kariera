using System;

namespace ConsoleApp274
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccaount bancAcc = new BankAccaount();
            bancAcc.Deposit(100);
            bancAcc.Withdraw(-10);
            Console.WriteLine(bancAcc.Balance);
        }
    }
}
