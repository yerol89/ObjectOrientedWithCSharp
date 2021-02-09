using System;

namespace ClassUygulama
{
    class Product
    {
        public string ProductName  { get; set; }
        public int ProductPrice { get; set; }
        public string ProductDescription { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Input number of products you want to enter to database: ");
            int numberofproducts = int.Parse(Console.ReadLine());
            Product[] ProductList = new Product[numberofproducts];
            int j = 0;
            Product ListElement;
            for (int i = 0; i < numberofproducts; i++)
            {
                ListElement = new Product();
                Console.WriteLine("Input name of the product: ");
                ListElement.ProductName = Console.ReadLine();
                Console.WriteLine("Input price of the product: ");
                ListElement.ProductPrice = int.Parse(Console.ReadLine());
                Console.WriteLine("Input description of the product: ");
                ListElement.ProductDescription = Console.ReadLine();
                ProductList[i] = ListElement;
            }

            foreach (var item in ProductList)
            {
                Console.WriteLine($"NAME : {ProductList[j].ProductName} PRICE: {ProductList[j].ProductPrice}    DESCRIPTION: {ProductList[j].ProductDescription}");
                j++;
            }


        }
    }
}
