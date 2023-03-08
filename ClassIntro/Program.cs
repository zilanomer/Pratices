using System;

namespace Class
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Product product1 = new Product();
            product1.Name = "Coat";
            product1.Price = 1500;
            product1.Description = "Black Coat";


            Product product2 = new Product();
            product2.Name = "Dres";
            product2.Price = 1000;
            product2.Description = "Pink Dres";

            Product[] products = new Product[] { product1, product2 };

            foreach (Product item in products)
            {
                Console.WriteLine(item.Name);
            }

            //instance - class örneğini
            BasketManager basketManager = new BasketManager();
            basketManager.Add(product1);



        }
    }

  
}
