using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop1
{
    public class ProductManager
    {
        public void Add(Product product)
        {

            Console.WriteLine(product.ProductName + "Added");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "Updated");
        }
         public void Delete(Product product)
        {
            Console.WriteLine(product.ProductName + "Deleted");

        }



    }
}
