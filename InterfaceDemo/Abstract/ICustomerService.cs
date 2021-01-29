using InterfaceDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
