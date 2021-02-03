using GameProjectDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstract
{
    public interface ISpecialOfferService
    {
        void OfferAdd(SpecialOffer offer);
        void OfferDelete(SpecialOffer offer);
        void OfferUpdate(SpecialOffer offer);

    
    }
}
