using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car : IEntity
    {
        public int Id { get; set; } //primary key
        public int BrandId { get; set; } //foreign key
        public int ColorId { get; set; } //foreign key
        public string ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Descriptions { get; set; }
    }
}
