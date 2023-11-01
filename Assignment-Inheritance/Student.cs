using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInhritanceDemo
{
    internal class Student
    {
        int rn;
        string name;
        public void GetDetails()
        {
            Console.WriteLine("Enter rn");
            rn = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
        }
        public void DisplayDetails()
        {
            Console.WriteLine(rn + " " + name);
        }
    }

}

