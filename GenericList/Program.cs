using System;
using System.Collections.Generic;

namespace GenericList
{
    class Program
    {
        class Product
        {
            public string Name { get; set; }

            public Product(string ctorName)
            {
                this.Name = ctorName;
            }
        }
        static void Main(string[] args)
        {
            List<Product> products1 = new List<Product>() { 
                
                new Product("IPhone6"),
                new Product("IPhone7"),
                new Product("IPhone8"),
                new Product("IPhoneX")
            };

            

            List<Product> products2 = new List<Product>() {

                new Product("Samsung S6"),
                new Product("Samsung S7"),
                new Product("Samsung S8"),
                new Product("Samsung S9")
            };

            products1.AddRange(products2);
            products1.ForEach(p => Console.WriteLine(p.Name));
            Console.WriteLine("**************************");
            products1.InsertRange(2, products2);
            products1.ForEach(p => Console.WriteLine(p.Name));
        }

        
    }
}
