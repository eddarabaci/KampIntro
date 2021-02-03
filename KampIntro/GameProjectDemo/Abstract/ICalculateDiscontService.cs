using GameProjectDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstract
{
    public interface ICalculateDiscontService
    {
        double CalculateDiscount(Game game, SpecialOffer offer);        
    }
}
