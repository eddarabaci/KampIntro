using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class ProductDetailDto : IDto
    {
        //DTO : Data Transformation Object
        //Joint
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public short UnitsInStock { get; set; }

    }
}
