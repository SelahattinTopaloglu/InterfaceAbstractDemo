using InterfaceDemo.Abstract;
using InterfaceDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
