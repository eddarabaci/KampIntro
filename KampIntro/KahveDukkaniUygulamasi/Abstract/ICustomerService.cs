using KahveDukkaniUygulamasi.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace KahveDukkaniUygulamasi.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
