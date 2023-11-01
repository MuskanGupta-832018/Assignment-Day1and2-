using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInhritanceDemo
{
    internal class Result : Test
    {
        int totalScore;
        public void CalulateTotalScore()
        {
            base.CalculateTotalMarks();
            totalScore = total + score;

        }
        public void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Final Score is " + totalScore);

        }

    }
}
