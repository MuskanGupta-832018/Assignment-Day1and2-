using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Bill
    {
        int customerId;
        string customerName;
        int unitsConsumed;
        double totalAmount = 0.0;

        public void GetCustomerDetail ()
        {
            Console.WriteLine("Enter Customer ID:");
            int customerId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Customer Name:");
            string customerName = Console.ReadLine();

            Console.WriteLine("Enter Units Consumed:");
            int unitsConsumed = int.Parse(Console.ReadLine());

        }

        public void CalculateBill()
        {
            if (unitsConsumed <= 199)
            {
                totalAmount = unitsConsumed * 1.20;
            }
            else if (unitsConsumed >= 200 && unitsConsumed < 400)
            {
                totalAmount = unitsConsumed * 1.50;
            }
            else if (unitsConsumed >= 400 && unitsConsumed < 600)
            {
                totalAmount = unitsConsumed * 1.80;
            }
            else
            {
                totalAmount = unitsConsumed * 2.00;
            }
            if (totalAmount > 400)
            {
                double surcharge = totalAmount * 0.15;
                totalAmount += surcharge;
            }

            
            if (totalAmount < 100)
            {
                totalAmount = 100;
            }

            Console.WriteLine("IDNO: " + customerId);
            Console.WriteLine("Name: " + customerName);
            Console.WriteLine("Consumed: " + unitsConsumed);
            Console.WriteLine(" Charges @Rs. " + (totalAmount / unitsConsumed).ToString("F2") + " per unit: " + totalAmount.ToString("F2"));
            if (totalAmount > 400)
            {
                Console.WriteLine("Surchage Amount: " + (totalAmount * 0.15).ToString("F2"));
            }
            Console.WriteLine("Net Amount Paid By the Customer: " + totalAmount.ToString("F2"));

        }


        static void Main(string[] args)
        {
            Bill bill=new Bill();
            bill.GetCustomerDetail();
            bill.CalculateBill();


        }
    }
}
