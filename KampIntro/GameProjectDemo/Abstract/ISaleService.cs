using GameProjectDemo.Concrete;
using GameProjectDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstract
{
    public interface ISaleService
    {
        void AddBasket(Game game, Gamer gamer, SpecialOffer offer);
        void DeleteBasket(Game game, Gamer gamer);
        void Buy(Game game, Gamer gamer);

    }
}
