namespace SealedClassMethod.Entities;

public class AccountTryOverrideMethod : AccountMethodSealed
{
    // the autocompletion don't reaches the method Deposit because it is sealed
    override public void Deposit(double amount) { }
}
