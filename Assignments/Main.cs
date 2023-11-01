using NumericFunctions;
using StringFunctions;
using System;

class Program
{
    static void Main()
    {
        int result = NumericCalculator.Add(5, 10, 20);
        Console.WriteLine("Addition: " + result);

        int min = NumericCalculator.FindMin(5, 10, 20);
        Console.WriteLine("Minimum: " + min);

        
    }
}
