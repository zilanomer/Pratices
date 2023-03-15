using System;

namespace Oop2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Individual individual1 = new Individual();
            individual1.Id = 1;
            individual1.CustomNumber = "1234";
            individual1.Name = "Zilan";


            Coorporate coorporate1 = new Coorporate();
            coorporate1.Id = 2;
            coorporate1.CustomNumber = "5432";
            coorporate1.CompanyName = "Ömer";

            // customer dan inheritance alınan sınıfların referasını tutabilir Customer . 
            Customer customer1 = new Individual();  // new ksmı referans Customer Individual 'ın referansını tutabilir.
            Customer customer2 = new Coorporate();

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(individual1);


        }
    }
}
