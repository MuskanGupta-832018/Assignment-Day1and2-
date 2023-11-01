using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class ProductDetail
    {
        readonly int pCode;
        string pName;
        int qty_in_stock;
        int discount_allowed;
        static string brand;
        public ProductDetail() { }
        public ProductDetail(int pCode,
        string pName,
        int qty_in_stock,
        int discount_allowed)
        {
            this.pCode = pCode;
            this.pName = pName;
            this.qty_in_stock = qty_in_stock;
            this.discount_allowed = discount_allowed;
        }
        public void GetProduct()
        {
            Console.WriteLine("Enter Product Name");
            pName = Console.ReadLine();
            Console.WriteLine("ENter Discoubt");
            discount_allowed = Int16.Parse(Console.ReadLine());
            Console.WriteLine("ENter qty_in_stock");
            qty_in_stock = Byte.Parse(Console.ReadLine());

        }
        public ProductDetail(string Pcode, ProductDetail product)
        {
            this.pCode = pCode;
            this.pName = product.pName;
            this.discount_allowed = product.discount_allowed;
            this.qty_in_stock = product.qty_in_stock;
        }

        public void DisplayProducts()
        {
            Console.WriteLine("Product code " + pCode);
            Console.WriteLine(pName);
            Console.WriteLine(qty_in_stock);
            Console.WriteLine(discount_allowed);

        }

        static ProductDetail()
        {

            brand = "Polo";
        }
    }

}

