using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MultiLevelInhritanceDemo
{
    internal class Sports : Student
    {
        string sportsname;
        protected int score;
        public void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine("Enter sportsname");
            sportsname = Console.ReadLine();
            Console.WriteLine("Enter score");
            score = int.Parse(Console.ReadLine());

        }
        public void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine(sportsname + " " + score);
        }
    }
}
