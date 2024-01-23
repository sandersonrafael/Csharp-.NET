namespace Override.Entities;

public class SavingsAccount : Account
{
    public double InterestRate { get; set; }

    /* Base */

    // The base keyword represents the parent class
    public SavingsAccount(int number, string holder, double balance, double interestRate)
        : base(number, holder, balance)
    {
        InterestRate = interestRate;
    }

    public void UpdateBalance()
    {
        Balance += Balance * InterestRate;
    }

    public override void Withdraw(double amount)
    {
        // base.Withdraw int this case, represents the parent class method invocation
        // and in addition, this subclass override method subtract 2.0 of his Balance
        base.Withdraw(amount);
        Balance -= 2.0;
    }
}
