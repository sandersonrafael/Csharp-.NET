using System.Globalization;

namespace Interfaces.Entities;

public class Invoice(double BasicPayment, double Tax)
{
    public double BasicPayment { get; set; } = BasicPayment;
    public double Tax { get; set; } = Tax;
    public double TotalPayment
    {
        get { return BasicPayment + Tax; }
    }

    public override string ToString() => "{\n" +
        $"  \"basicPayment\": {BasicPayment.ToString("F2", CultureInfo.InvariantCulture)},\n" +
        $"  \"tax\": {Tax.ToString("F2", CultureInfo.InvariantCulture)},\n" +
        $"  \"totalPayment\": {TotalPayment.ToString("F2", CultureInfo.InvariantCulture)}\n" +
        "}";
}
