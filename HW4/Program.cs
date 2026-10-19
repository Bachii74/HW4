using System;

class Program
{
    static decimal PlatinumToUSD(decimal ounces)
    {
        return ounces * 1634.00m; 
    }

    static void Main()
    {
        decimal platinumOunces = 0.0m;
        Console.WriteLine("Please enter the platinum ounces");
        platinumOunces = Convert.ToDecimal(Console.ReadLine());

        decimal totalUSD = 0.0m;
        totalUSD = PlatinumToUSD(platinumOunces);
        Console.WriteLine($"Platinum value in USD today: {totalUSD:C2}");
    }
}