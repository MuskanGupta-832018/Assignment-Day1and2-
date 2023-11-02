/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Table
    {
        int num;
        int table;
        public void CalculateTable()
        {
            Console.WriteLine("Enter num");
            num = Int16.Parse(Console.ReadLine());
            for (int i = 1; i < 11; i++)
            {
                table = num * i;
                Console.WriteLine(table);

            }
            Console.WriteLine(table);
        }

        static void Main(string[] args)
        {
            Table table = new Table();
            table.CalculateTable();
        }
    }
}
*/