using System;
using System.Collections.Generic;
using System.Text;
using CustomerManagerDemo.Abstract;
using CustomerManagerDemo.Entities;
using MernisServiceReference;
namespace CustomerManagerDemo.Adapters
{
    class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(
                Convert.ToInt64(customer.NationalityId), customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year)
                .Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
