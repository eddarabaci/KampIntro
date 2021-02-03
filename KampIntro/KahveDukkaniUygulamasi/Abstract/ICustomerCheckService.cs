using KahveDukkaniUygulamasi.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace KahveDukkaniUygulamasi.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
       
    }
}
