using System;

namespace StaticMembers
{
    class Program
    {
        class Product
        {
            public int ProductId { get; set; }
            public string Name { get; set; }
            public int Price { get; set; }
            public bool IsApproved { get; set; }
        }

        static class ProductManager
        {
            static Product[] ProductsArray;

            static  ProductManager()
            {
                ProductsArray = new Product[5];

                ProductsArray[0] = new Product { ProductId = 1, Name = "Iphone5", Price = 2000, IsApproved= true };
                ProductsArray[1] = new Product { ProductId = 2, Name = "Iphone6", Price = 3000, IsApproved = true };
                ProductsArray[2] = new Product { ProductId = 3, Name = "Iphone7", Price = 4000, IsApproved = false };
                ProductsArray[3] = new Product { ProductId = 4, Name = "Iphone8", Price = 5000, IsApproved = true };
                ProductsArray[4] = new Product { ProductId = 5, Name = "IphoneX", Price = 6000, IsApproved = true };
            }

            public static Product[] GetProducts()
            {
                return ProductsArray;             
            }

            public static void GetProductByName()
            {
                Console.WriteLine("Input the name of the product you are looking for : ");
                string search = Console.ReadLine();
                Product p = new Product();
                int counter = 0;
                foreach (var item in ProductsArray)
                {
                    if (item.Name.ToLower() == search.ToLower())
                    {
                        p = item;
                        Console.WriteLine($"Product you are looking for is {item.Name} and its price is {item.Price}");
                        counter++;
                        break;
                    }
                }
                if (counter==0)
                {
                    Console.WriteLine($"We do not have a product named {search} in our database");
                }
            }
        }
        static void Main(string[] args)
        {
            //var ElementsOfProductArray=ProductManager.GetProducts();
            //foreach (var item in ElementsOfProductArray)
            //{
            //    Console.WriteLine($"NAME: {item.Name} PRICE: {item.Price}");
            //}

            ProductManager.GetProductByName();
        }
    }
}
