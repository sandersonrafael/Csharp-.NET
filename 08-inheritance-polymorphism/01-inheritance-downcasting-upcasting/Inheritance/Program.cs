using System;
using Inheritance.Entities;

namespace Inheritance;

class Program
{
    static void Main(string[] args)
    {
        Account acc = new(1001, "Alex", 0.0);
        BusinessAccount accB = new(1002, "Maria", 0.0, 500.0);

        /* Upcasting */

        Account acc1 = accB;
        Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
        Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

        /* Downcasting */
        // This is an "unsafe" operation. It is recommended to avoid use due to the possibility of incompatibility

        // BusinessAccount accB2 = acc2; // Error because isn't compatible the conversion
        BusinessAccount acc4 = (BusinessAccount)acc2; // Casting
        acc4.Loan(100.0);

        // An exception will occur due to the account types being previously different
        // BusinessAccount acc5 = (BusinessAccount)acc3;

        /* Type or Class Verification */

        // is -> check if the variable are an instance of informed Type / Class
        if (acc3 is BusinessAccount)
        {
            BusinessAccount acc5 = (BusinessAccount)acc3;
            acc5.Loan(200.0);
            Console.WriteLine("Loan Successful");
        }

        if (acc3 is SavingsAccount)
        {
            SavingsAccount acc5 = (SavingsAccount)acc3;
            acc5.UpdateBalance();
            Console.WriteLine("Updating Balance");
        }
    }
}
