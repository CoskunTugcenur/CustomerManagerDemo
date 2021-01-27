using CustomerManagerDemo.Entities;
using CustomerManagerDemo.Abstract;
using MernisServiceReference;
namespace CustomerManagerDemo.Concrete
{
    class CustomerCheckManager:ICustomerCheckService
    {

        public bool CheckIfRealPerson(Customer customer)
        {
            return true;

        }
    }
}
