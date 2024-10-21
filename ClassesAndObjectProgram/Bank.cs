using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjectProgram
{
    public class Bank
    {
        private double balance;

        public Bank(double bbalance)
        {
            balance = bbalance;
        }

        public void Deposit(double amount)
        {
            balance = balance + amount;
        }

        public void Withdrow(double amount)
        {
            if(amount < balance)
            {
                balance = balance - amount;
            }
            else
            {
                Console.WriteLine("insufficient balance");
            }
           
        }

        public string Display()
        {
            return $"Your Balance is : {balance} ";
        }
    }
}
