using System;
using System.Collections.Generic;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();

            BankAccount acc = new BankAccount();

            string command = "";
            while ((command = Console.ReadLine()) != "End")
            {
                var cmdArgs = command.Split();
                var cmdType = cmdArgs[0];
                switch (cmdType)
                {
                    case "Create":
                        Create(cmdArgs, accounts);
                        break;

                    case "Deposit":
                        Deposit(cmdArgs, accounts);
                        break;

                    case "Withdraw":
                        Withdraw(cmdArgs, accounts);
                        break;

                    case "Print":
                        Print(cmdArgs, accounts);
                        break;
                    default:
                        Console.WriteLine("INCC");
                        break;
                }
            }

        }

        private static void Print(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
        {
            int id = int.Parse(cmdArgs[1]);
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                BankAccount acc = accounts[id];
                Console.WriteLine($"Account ID{acc.Id}, balance {acc.Balance:f2}");
            }
        }

        private static void Withdraw(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
        {
            int id = int.Parse(cmdArgs[1]);
            decimal amount = decimal.Parse(cmdArgs[2]);
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            else if (amount > accounts[id].Balance)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                accounts[id].Balance -= amount;
            }
        }

        private static void Deposit(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
        {
            int id = int.Parse(cmdArgs[1]);
            decimal amount = decimal.Parse(cmdArgs[2]);
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                accounts[id].Balance += amount;
            }
        }

        private static void Create(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
        {
            int id = int.Parse(cmdArgs[1]);

            if (accounts.ContainsKey(id))
            {
                Console.WriteLine("Account already exists");
            }
            else
            {
                BankAccount acc = new BankAccount
                {
                    Id = id
                };
                accounts.Add(id, acc);
            }

        }
    }
}
