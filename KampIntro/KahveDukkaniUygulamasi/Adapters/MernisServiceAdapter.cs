using KahveDukkaniUygulamasi.Abstract;
using KahveDukkaniUygulamasi.Entity;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace KahveDukkaniUygulamasi.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            MernisServiceReference.KPSPublicSoapClient client = new MernisServiceReference.KPSPublicSoapClient();
            return client.TCKimlikNoDogrulaAsync(customer.NationalityId, customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year);
            
        }
    }
}
