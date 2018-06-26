using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace BaitapCsah
{
    public class Controller
    {
        List<Product> list = new List<Product>();

        public bool Add()
        {


            Console.WriteLine("Please enter product ID");
            string id = Console.ReadLine();
            Console.WriteLine("Please enter product name");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter price");
            string price = Console.ReadLine();
            Product product = new Product(id, name, price);
            list.Add(product);
            return true;
        }

        public void Display()
        {
            Console.WriteLine("ok");

            foreach (var product in list)
            {
                Console.WriteLine("{0, -20} {1,-20} {2, -20} ", "Product Id", "Product Name", "Price");
                Console.WriteLine("----------------------------------------------------------------------");
                Console.WriteLine("{0, -20} {1, -20} {2, -20}", product.Id, product.Name, product.Price);
            }


        }

        public void Delete()
        {
            Console.WriteLine("ID need to delete.");
            
            string id = Console.ReadLine();
            Product idDelete = list.Find(a => a.Id == id);
            list.Remove(idDelete);


        }
    }
}