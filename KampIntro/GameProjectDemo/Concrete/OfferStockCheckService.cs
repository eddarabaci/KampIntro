using GameProjectDemo.Abstract;
using GameProjectDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    public class OfferStockCheckService : IOfferStockCheckService
    {
        public bool CheckStock(Game game)
        {
            if (game.UnitStock > 0)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
