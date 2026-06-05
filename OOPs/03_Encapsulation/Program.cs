using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Encapsulation
{
    /*
     
    class Program
    {
        private int atmPin;

        public int getValue()
        {
            return atmPin;
        }

        public void setValue(int pin)
        {
            atmPin = pin;
        }
    }

    class Emp
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.setValue(4321);

            Console.WriteLine($"{p.getValue()}");

            Console.ReadLine();
        }
    }

    */

    class BankAccount
    {
        private string ownerName;
        private double balance;
        private string password;

        public BankAccount(string ownerName, int balance, string password)
        {
            this.ownerName = ownerName;
            this.balance = balance;
            this.password = password;
        }

        public void Deposit(double amount)
        {
            if(amount <= 0)
            {
                Console.WriteLine("Deposit amount must be greater than 0");
            }
            else
            {
                balance = balance + amount;
            }
        }
        public void WithDraw(double amount, string enterPassword)
        {
            if(enterPassword != password)
            {
                Console.Write("Wrong password - Access Denied");
                Console.WriteLine();
            }
            else if(amount > balance)
            {
                Console.WriteLine("Insufficient balance");
            }
            else if(amount <= 0)
            {
                Console.WriteLine("Withdrawl amount must be greater than 0");
            }
            else
            {
                balance = balance - amount;
                Console.WriteLine($"Withdrawl amount: {amount} - remaining balance: {balance}");
            }
        }
        public void CheckBalance(string enterPassword)
        {
            if(enterPassword != password)
            {
                Console.WriteLine("Wrong password - Acces denied");
            }
            else
            {
                Console.WriteLine($"Account Owner: {ownerName}");
                Console.WriteLine($"Current balance: {balance}");
            }
        }
    }

    class Person
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("Blade", 5000, "blade123");

            Console.WriteLine("---Deposit---");
            account.Deposit(2000);

            Console.WriteLine();

            Console.WriteLine("---Check Balance---");
            account.CheckBalance("blade123");

            Console.WriteLine();

            Console.WriteLine("--- Withdraw with wrong password---");
            account.WithDraw(2000, "worngPassword");

            Console.WriteLine();

            Console.WriteLine("--- Withdraw with correct password---");
            account.WithDraw(2000, "blade123");

            Console.WriteLine();

            Console.WriteLine("---Final Balance---");
            account.CheckBalance("blade123");

            Console.ReadLine();
        }
    }
}
