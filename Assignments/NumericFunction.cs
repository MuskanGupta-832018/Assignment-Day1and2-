using System;

namespace NumericFunctions
{
    public class NumericCalculator
    {
        public static int Add(params int[] numbers)
        {
            int result = 0;
            foreach (int num in numbers)
            {
                result += num;
            }
            return result;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static float Divide(float a, float b)
        {
            if (b != 0)
                return a / b;
            else
                throw new DivideByZeroException("Division by zero is not allowed.");
        }

        public static int FindMax(params int[] numbers)
        {
            if (numbers.Length == 0)
                throw new ArgumentException("No numbers provided.");
            int max = numbers[0];
            foreach (int num in numbers)
            {
                if (num > max)
                    max = num;
            }
            return max;
        }

        public static int FindMin(params int[] numbers)
        {
            if (numbers.Length == 0)
                throw new ArgumentException("No numbers provided.");
            int min = numbers[0];
            foreach (int num in numbers)
            {
                if (num < min)
                    min = num;
            }
            return min;
        }

        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
}
