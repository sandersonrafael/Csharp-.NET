namespace Override.Entities;

public class Account
{
    public int Number { get; private set; }
    public string? Holder { get; private set; }
    public double Balance { get; protected set; }

    public Account() { }

    public Account(int number, string holder, double balance)
    {
        Number = number;
        Holder = holder;
        Balance = balance;
    }

    /* Virtual Modifier */

    // Allows the method to be overridden by a child class
    public virtual void Withdraw(double amount)
    {
        Balance -= amount + 5;
    }

    public virtual void Deposit(double amount)
    {
        Balance += amount;
    }
}
