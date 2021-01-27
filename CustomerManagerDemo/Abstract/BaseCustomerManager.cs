using System;
using System.Collections.Generic;
using System.Text;
using CustomerManagerDemo.Entities;

namespace CustomerManagerDemo.Abstract
{
    public abstract class BaseCustomerManager:ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Save to db :"+customer.FirstName+" "+ customer.LastName);
        }

    }
}
