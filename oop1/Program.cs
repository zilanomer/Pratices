using System;

namespace oop1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Product product1 = new Product(); 
            product1.Id = 1;
            product1.ProductName = "Phone";
            product1.CategoryId = 1;
            product1.UnitPrice = 500;
            product1.UnitInStock = 2;


            Product product2 = new Product
            {
                Id = 2,
                ProductName = "Laptop",
                CategoryId = 2,
                UnitInStock = 5,
                UnitPrice = 5000
            };

            // PascalCase 
            //                camelCase
            ProductManager productManager = new ProductManager();

            productManager.Add(product1);



        }
    }
}
