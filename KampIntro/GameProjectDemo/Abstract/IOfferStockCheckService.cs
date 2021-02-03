using GameProjectDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstract
{
    public interface IOfferStockCheckService
    {
        bool CheckStock(Game game);
    }
}
