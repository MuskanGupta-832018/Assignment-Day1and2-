using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class ForLoop
    {
        public void EvenFuction()
        {
            for (int num = 0; num <= 20; num += 2)
            {
                Console.WriteLine(num);
            }

        }


        public void OddFuction()
        {
            for (int num = 1; num <= 20; num += 2)
            {
                Console.WriteLine(num);
            }

        }

        static void Main(string[] args)
        {
            ForLoop forLoop = new ForLoop();
            forLoop.EvenFuction();
            forLoop.OddFuction();
        }
    }
}
