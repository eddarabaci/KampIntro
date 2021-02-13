using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> catgories = new List<Category>
            {
                new Category{CategoryId = 1, CategoryName = "Bilgisayar"},
                new Category{CategoryId = 1, CategoryName = "Telefon"}

            };
            List<Product> products = new List<Product> 
            {
                new Product{ProductId = 1, CategoryId =1, ProductName = "Acer", QuantityPerUnit="32 GB Ram",UnitPrice = 10000,UnitsInStock = 5 },
                new Product{ProductId = 2, CategoryId =1, ProductName = "Asus", QuantityPerUnit="12 GB Ram",UnitPrice = 8000,UnitsInStock = 3 },
                new Product{ProductId = 3, CategoryId =1, ProductName = "HP", QuantityPerUnit="8 GB Ram",UnitPrice = 6000,UnitsInStock = 2 },
                new Product{ProductId = 4, CategoryId =2, ProductName = "Samsung", QuantityPerUnit="4 GB Ram",UnitPrice = 5000,UnitsInStock = 15 },
                new Product{ProductId = 5, CategoryId =2, ProductName = "Apple", QuantityPerUnit="4 GB Ram",UnitPrice = 8000,UnitsInStock = 0 },
            };

            var result = products.Where(product => product.UnitPrice > 5000 && product.UnitsInStock > 3);

            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName);
            }
        }
        
    }
    class Product 
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }

    class Category 
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
