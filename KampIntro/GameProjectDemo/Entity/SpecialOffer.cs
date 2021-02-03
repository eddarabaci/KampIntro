using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Entity
{
    public class SpecialOffer
    {
        public int Id { get; set; }
        public int OfferId { get; set; }
        public string OfferName { get; set; }
        public double DiscountRate { get; set; }
    }
}
