namespace SealedClassMethod.Entities
{
    public class AccountMethodSealed : Account
    {
        /* Sealed method */
        public sealed override void Deposit(double amount)
        {
            base.Deposit(amount);
        }
    }
}
