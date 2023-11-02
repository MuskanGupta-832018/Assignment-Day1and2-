/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class BasicFunction_Switch
    {
        int num1;
        int num2;
        int add;
        int diff;
        int quo;
        int pro;
        string fun;

        public void GetDetailOfFunction()
        {
            Console.WriteLine("Enter num1");
            num1 = Int16.Parse(Console.ReadLine());

            Console.WriteLine("Enter num2");
            num2 = Int16.Parse(Console.ReadLine());

            Console.WriteLine("Function to perform");
            fun = (Console.ReadLine());

            switch (fun)
            {

                case "1":
                    add = num1 + num2;
                    Console.WriteLine(add);

                    break;
                case "2":
                    diff = num1 - num2;
                    Console.WriteLine(diff);
                    break;
                case "3":
                    pro = num1 * num2;
                    Console.WriteLine(pro);
                    break;
                case "4":
                    quo = num1 % num2;
                    Console.WriteLine(quo);
                    break;
                case "5":
                    Console.WriteLine("No function performed");
                    break;

            }
        }

       

       



static void Main(string[] args)
        {


            BasicFunction_Switch basicFunction = new BasicFunction_Switch();
            basicFunction.GetDetailOfFunction();
           
        }
    }
}*/
