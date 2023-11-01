using System;
using System.Linq;

namespace Assignment2
{
    class MaxElement
    {
        private int[] numbers;

        public void GetArray()
        {
            Console.WriteLine("Enter the number of elements:");
            int n = int.Parse(Console.ReadLine());
            numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter element " + (i + 1) + ":");
                numbers[i] = int.Parse(Console.ReadLine());
            }
        }

        public void MaximumElement()
        {
            if (numbers != null && numbers.Length > 0)
            {
                int maxElement = numbers.Max();
                Console.WriteLine("Maximum Element: " + maxElement);
            }
            else
            {
                Console.WriteLine("No elements in the array.");
            }
        }

        static void Main(string[] args)
        {
            MaxElement maxElement = new MaxElement();
            maxElement.GetArray();
            maxElement.MaximumElement();
        }
    }
}

