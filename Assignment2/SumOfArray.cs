/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class SumOfArray
    {
        int[,] matrix1 = new int[3, 3];
        int[,] matrix2 = new int[3, 3];
        int[,] sum = new int[3, 3];
        public void GetArray()
        {
            Console.WriteLine("Enter values for a 3x3 matrix1:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Enter value at position for Matrix1 ({i + 1},{j + 1}): ");
                    if (int.TryParse(Console.ReadLine(), out int value))
                    {
                        matrix1[i, j] = value;
                    }
                }
            }
            Console.WriteLine("Enter values for a 3x3 matrix2:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Enter value at position for Matrix2 ({i + 1},{j + 1}): ");
                    if (int.TryParse(Console.ReadLine(), out int value))
                    {
                        matrix2[i, j] = value;
                    }
                }
            }
        }

        public void AddArray()
        {
            Console.WriteLine("Sum of the matrices:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sum[i, j] = matrix1[i, j] + matrix2[i, j];
                    Console.Write(sum[i, j] + "\t"); // Print each element individually
                }
                Console.WriteLine(); // Move to the next row
            }
        }
        static void Main(string[] args)
        {
            SumOfArray sumOfArray = new SumOfArray();
            sumOfArray.GetArray();
            sumOfArray.AddArray();



        }
    }
}*/


