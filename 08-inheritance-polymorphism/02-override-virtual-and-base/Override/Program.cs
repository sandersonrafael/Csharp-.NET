using System;
using Override.Entities;

namespace Override;

class Program
{
    static void Main(string[] args)
    {
        Account acc1 = new Account(1001, "Alex", 500.0);
        Account acc2 = new SavingsAccount(1002, "Ana", 500.0, 0.01);

        acc1.Withdraw(10.0);
        acc2.Withdraw(10.0);

        Console.WriteLine($"acc1.Balance: {acc1.Balance}");
        Console.WriteLine($"acc2.Balance: {acc2.Balance}");
    }
}
