using GameProjectDemo.Abstract;
using GameProjectDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    public class CalculateDiscountManager : ICalculateDiscontService
    {
        public double CalculateDiscount(Game game, SpecialOffer offer)
        {
            double _gamePrice = game.GamePrice;
            double _discountRate = offer.DiscountRate;

            double _discount = (_gamePrice - ((_gamePrice * _discountRate) / 100));
            return _discount;


        }
    }
}
