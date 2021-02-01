using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer customer1 = new Customer
            {
                CustomerID = 1,
                CustomerName = "Gizem",
                CustomerLastName = "Çınar"
            };

            Customer customer2 = new Customer
            {
                CustomerID = 2,
                CustomerName = "Emine",
                CustomerLastName = "Çınar"
            };

            Customer customer3 = new Customer
            {
                CustomerID = 3,
                CustomerName = "Gamze",
                CustomerLastName = "Kalkan"
            };

            Customer customer4 = new Customer
            {
                CustomerID = 4,
                CustomerName = "Berk",
                CustomerLastName = "Kaldar"
            };


            CustomerManager customerManager = new CustomerManager();

            List<Customer> customerList = new List<Customer>() { customer1, customer2, customer3, customer4 };

            customerManager.Update("CustomerName", "Emine", "Gözde", customerList);
            Console.WriteLine("-------");
            customerManager.Delete(customer1, customerList);


        }
    }
}
