using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class ColumnWiseSum
    {
        int[,] matrix1 = new int[3, 3];
        
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
            
        }

        public void AddArray()
        {
            Console.WriteLine("Column wise Sum of the matrices:");
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                int add = 0;
                for (int i = 0; i < matrix1.GetLength(0); i++)
                {
                    add += matrix1[i, j];
                }
                Console.WriteLine($"Sum of column {j + 1}: {sum}");
            }
        }
        static void Main(string[] args)
        {
           ColumnWiseSum columnWise = new ColumnWiseSum();
            columnWise.GetArray();
            columnWise.AddArray();



        }
    }
}


