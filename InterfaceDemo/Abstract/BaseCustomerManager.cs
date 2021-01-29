using System;
using System.Collections.Generic;
using System.Text;
using InterfaceDemo.Entities;

namespace InterfaceDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Save to db : " + customer.FirstName);
        }
    }
}