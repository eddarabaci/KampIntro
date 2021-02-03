using KahveDukkaniUygulamasi.Abstract;
using KahveDukkaniUygulamasi.Entity;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace KahveDukkaniUygulamasi.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
