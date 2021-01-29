using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{   
    //CRUD - Create-Read-Update-Delete
    class ProductManager
    {
        //void
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }
        public void Update(Product product) 
        {
            Console.WriteLine(product.ProductName + " guncellendi.");
        }
        
    }
}
