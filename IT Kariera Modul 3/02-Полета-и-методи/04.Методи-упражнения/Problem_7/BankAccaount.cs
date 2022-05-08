using System;
using System.Collections.Generic;

namespace ConsoleApp284
{
    internal class BankAccaount
    {
        private Dictionary<int, int> ID;
        public Dictionary<int, int> accaounts = new Dictionary<int, int>();
        
        public Dictionary<int, int> IDs
        {
            get { return ID; }
            set { ID = value; }
        }
        internal void Create(int id)
        {
            if (!accaounts.ContainsKey(id))
            {
                accaounts.Add(id, 0);
            }
            else
            {
                Console.WriteLine("Accaount already exist!");
            }
        }

        internal void Deposit(int id, int balance)
        {
            if (accaounts.ContainsKey(id))
            {
                accaounts[id] += balance;
            }
            else
            {
                Console.WriteLine("Account does not exist!");
                
            }
        }

        internal void Withdraw(int id, int balance)
        {
            if (!accaounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist!");
            }
            else
            {
                if(accaounts[id] < balance)
                {
                    Console.WriteLine("Insifficient balance!");
                }
                else
                {
                    accaounts[id] -= balance;
                }
                
            }
        }

        internal void Print(int id)
        {
            Console.WriteLine($"Account ID: {id}, balance: {accaounts[id]}.");
        }
    }
}