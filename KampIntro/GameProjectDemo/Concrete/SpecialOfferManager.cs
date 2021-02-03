using GameProjectDemo.Abstract;
using GameProjectDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    class SpecialOfferManager : ISpecialOfferService
    {
        public void OfferAdd(SpecialOffer offer)
        {
            Console.WriteLine(offer.OfferName +" Offer added to DB");
        }

        public void OfferDelete(SpecialOffer offer)
        {
            Console.WriteLine(offer.OfferName + " Offer deleted from DB");
        }

        public void OfferUpdate(SpecialOffer offer)
        {
            Console.WriteLine(offer.OfferName + " Offer updated in DB");
        }
    }
}
