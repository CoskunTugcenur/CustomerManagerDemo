using CustomerManagerDemo.Abstract;
using CustomerManagerDemo.Concrete;
using CustomerManagerDemo.Entities;
using CustomerManagerDemo.Adapters;
using System;

namespace CustomerManagerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new OtherBrandCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1995, 2, 13), FirstName = "Tuğçenur", LastName = "", NationalityId = "" });
            Console.ReadLine();
        }
    }
}
