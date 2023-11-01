using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class Main
    {
        public static void main(string[] args)
        {
            List<Product> products = new List<Product>();   
            Console.WriteLine("Admin/nonadmin");
            String usertype=Console.ReadLine();
            switch(usertype)
            {
                case "admin":
                Console.WriteLine("What to do");

            int ch= byte.Parse(Console.ReadLine()); 
            switch(ch)
                    {
                        case 1:

                            {
                                Console.WriteLine("Enterpcode");
                                String pcode= Console.ReadLine();
                                Product product = new Product();
                                product.GetProductDetails();
                                Product temp=new Product(pcode,)

                            }


            }break;


                
           
        }
        
    }
}
