using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInhritanceDemo
{
    internal class Test : Sports
    {
        int[] marks = new int[] { 10, 23, 45, 67, 88 };
        protected int total;
        public void CalculateTotalMarks()
        {
            total = marks.ToList().Sum();
        }
        public void DisplayDetails()
        {
            base.GetDetails();
            base.DisplayDetails();
            Console.WriteLine("total marjs are " + total);
        }
    }
}
