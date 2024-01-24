namespace Interfaces.Services;

public class BrazilTaxService : ITaxService
{
    public double Tax(double amount)
    {
        if (amount <= 100.0) return amount * .2;
        return amount * .15;
    }
}
