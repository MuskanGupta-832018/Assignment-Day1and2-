using System.ComponentModel;
using System.Xml.Linq;

namespace Assignment6
{
    class Product
    {
        readonly int pcode=1000;
        string pname;
        int qty_in_stock;
        string discount_allowedbrand;
        static string brand;


       static Product()
        {
            brand = "PUMA";
        }
        public Product(int pcode, string pname, int qty_in_stock, string discount_allowedbrand)
        {
         
            Console.WriteLine("enter pname");
            pname = Console.ReadLine();
            
            Console.WriteLine("Enter   discount_allowedbrand");
            discount_allowedbrand = Console.ReadLine();

            Console.WriteLine("Enter qty_in_stock");
            qty_in_stock =byte.Parse( Console.ReadLine());


        }
        public void GetProductDetails()
        {

        }

    }
}