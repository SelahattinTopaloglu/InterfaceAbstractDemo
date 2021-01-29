using InterfaceDemo.Abstract;
using System;
using InterfaceDemo.Entities;
using System.Collections.Generic;
using System.Text;
using MernisServiceReference;
using System.Threading.Tasks;

namespace InterfaceDemo.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
        {
        public static async Task<bool> TaskAsync(Customer customer)
        { 
             KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
             var result = await(client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalityId),
            customer.FirstName, customer.LastName, customer.DateOfBirth.Year));
            return result.Body.TCKimlikNoDogrulaResult;
        }
    public bool CheckIfRealPerson(Customer customer)
    {
        return TaskAsync(customer).Result;


    }
}
}
