using System;
using System.Collections.Generic;
using System.Text;
using CustomerManagerDemo.Entities;

namespace CustomerManagerDemo.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
