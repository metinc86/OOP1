using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Let's add an Individual Customer Metin Canimoglu
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1; 
            customer1.CustomerNumber = "12345";
            customer1.Name = "Metin";
            customer1.Surname = "Canımoğlu";
            customer1.IdNumber = "12345678901";

            // Let's add a Corporate Customer Kodlama.io 
            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = "54321";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNumber = "1234567890";

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);

        }
    }
}
