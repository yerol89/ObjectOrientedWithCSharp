using System;
using System.ComponentModel.DataAnnotations;

namespace ConstructorsAndMethods
{
    class Program
    {
       class Comment
        {
            public int CommentID { get; set; }
            public string  Text { get; set; }
        }
        class Product
        {
            public Product()
            {
                
                this.ProductID =(new Random()).Next(1,1000);
            }

            public Product(int pID)
            {
                this.ProductID = pID;
            }
            public Product(int ProId, string NameOfPro,double PriceofPro,bool Onsale)
            {
                this.Name = NameOfPro;
                this.ProductID = ProId;
                this.IsApproved = Onsale;
                this.Price = PriceofPro;
                this.Comments = new Comment[3];
            }
            public string Name { get; set; }
            public double Price { get; set; }
            public int ProductID { get; set; }
            public bool IsApproved { get; set; }
            public Comment[] Comments { get; set; } // Bir ürüne birden fazla yorum
        }
        static void Main(string[] args)
        {
            Comment c1 = new Comment() { CommentID=100, Text="Nice Phone" };


            Console.WriteLine("First constructor is on process!");
            Product p1 = new Product();
            Console.WriteLine($"ID: {p1.ProductID}");
            Console.WriteLine("********************");

            Console.WriteLine("Second constructor is on process");
            Product p2 = new Product(41);
            Console.WriteLine($"ID: {p2.ProductID}");
            Console.WriteLine("********************");

            Console.WriteLine("Third constructor is on process");
            Product p3 = new Product(100, "Phone", 3000, true);
            p3.Comments[0] = c1;
            Console.WriteLine($"ID: {p3.ProductID}");
            Console.WriteLine($"NAME : {p3.Name}");
            Console.WriteLine($"PRICE: {p3.Price}");
            Console.WriteLine($"ONSALE: {p3.IsApproved} ");
            Console.WriteLine($"COMMENT: {p3.Comments[0].Text} ");






        }
    }
}
