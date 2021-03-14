using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        //sabit olacağı için static verdik, new'lemek yok
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz!";
        public static string MaintenanceTime = "Sistem bakımda..";
        public static string ProductsListed =" Ürünler listelendi";
        public static string Listed = "Listelendi.";
    }
}
