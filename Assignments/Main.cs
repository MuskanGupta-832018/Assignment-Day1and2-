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

        string sentence = "A man a plan a canal Panama";
        bool isPalindrome = StringUtils.IsPalindrome(sentence);
        Console.WriteLine("Is Palindrome: " + isPalindrome);
    }
}
