using System;
using System.Collections.Generic;
using System.Text;
using InterfaceDemo.Entities;

namespace InterfaceDemo.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
