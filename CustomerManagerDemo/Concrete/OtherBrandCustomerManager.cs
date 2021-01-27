using System;
using System.Collections.Generic;
using System.Text;
using CustomerManagerDemo.Abstract;
using CustomerManagerDemo.Entities;

namespace CustomerManagerDemo.Concrete
{
    class OtherBrandCustomerManager:BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public OtherBrandCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }

            else
            {
                throw new Exception("Not a valid person");
            }

            
        }

       
    }
}
