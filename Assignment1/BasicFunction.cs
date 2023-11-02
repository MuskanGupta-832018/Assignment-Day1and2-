/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class BasicFunction
    {
        int num1;
        int num2;
        int add;
        int diff;
        int quo;
        int pro;

        public void SumFunction()
        {
            add=num1 + num2;
            Console.WriteLine(add);
        }
        public void DiffFunction()
        {
            diff = num1 - num2;
            Console.WriteLine(diff);
        }
        public void ProductFunction()
        {
            pro = num1 * num2;
            Console.WriteLine(pro);
        }
        public void QuotientFunction()
        {
            quo = num1 % num2;
            Console.WriteLine(quo);
        }
        public void CalculateFunction()
        {
            Console.WriteLine("Enter num1");
            num1 = Int16.Parse(Console.ReadLine());

            Console.WriteLine("Enter num2");
            num2= Int16.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {


            BasicFunction basicFunction = new BasicFunction();
            basicFunction.CalculateFunction();
            basicFunction.SumFunction();
            basicFunction.DiffFunction();
            basicFunction.ProductFunction();
            basicFunction.QuotientFunction();
        }

        }
}*/
