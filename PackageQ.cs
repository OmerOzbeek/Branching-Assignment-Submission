
using System;

class ShippingCalculator8
{
    static void Main()
    {
        Console.WriteLine("Welcome to Package Express - Please follow the guidelines carefully.");

        Console.Write("Input the weight of your package: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal weight))
        {
            Console.WriteLine("Invalid input. Please enter a valid number for weight.");
            return;
        }

        if (weight > 50)
        {
            Console.WriteLine("The package is too heavy to be shipped via Package Express. Have a nice day!");
            return;
        }

        Console.Write("Input the width of the package: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal width))
        {
            Console.WriteLine("Invalid input. Please enter a valid number for width.");
            return;
        }

        Console.Write("Input the height of the package: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal height))
        {
            Console.WriteLine("Invalid input. Please enter a valid number for height.");
            return;
        }

        Console.Write("Input the length of the package: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal length))
        {
            Console.WriteLine("Invalid input. Please enter a valid number for length.");
            return;
        }

        decimal dimensionSum = width + height + length;

        if (dimensionSum > 50)
        {
            Console.WriteLine("Package too large for shipping with Package Express.");
            return;
        }

        decimal shippingFee = (width * height * length * weight) / 100m;
        Console.WriteLine("Shipping cost estimate: ${0:F2}", shippingFee);
        Console.WriteLine("Thank you for using Package Express.");
    }
}
