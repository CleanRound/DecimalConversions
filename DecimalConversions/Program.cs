public struct DecimalNumber
{
    public int Number { get; }

    public DecimalNumber(int number)
    {
        Number = number;
    }

    public string ToBinary()
    {
        return Convert.ToString(Number, 2);
    }

    public string ToOctal()
    {
        return Convert.ToString(Number, 8);
    }

    public string ToHexadecimal()
    {
        return Convert.ToString(Number, 16).ToUpper();
    }

    public override string ToString()
    {
        return Number.ToString();
    }
}

public class Program
{
    public static void Main()
    {
        DecimalNumber decimalNumber = new DecimalNumber(255);

        string binary = decimalNumber.ToBinary();
        Console.WriteLine($"Decimal {decimalNumber} in binary: {binary}");

        string octal = decimalNumber.ToOctal();
        Console.WriteLine($"Decimal {decimalNumber} in octal: {octal}");

        string hexadecimal = decimalNumber.ToHexadecimal();
        Console.WriteLine($"Decimal {decimalNumber} in hexadecimal: {hexadecimal}");
    }
}
