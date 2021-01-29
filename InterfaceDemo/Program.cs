using InterfaceDemo.Abstract;
using InterfaceDemo.Adapters;
using InterfaceDemo.Concrete;
using InterfaceDemo.Entities;
using System;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager (new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1998,5,1), FirstName = "Selahattin", LastName = "Topaloğlu", NationalityId = "12345678901" });
            Console.ReadLine();
        }
    }
}
