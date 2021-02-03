using GameProjectDemo.Abstract;
using GameProjectDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    public class SaleManager : ISaleService
    {
        private readonly ICalculateDiscontService _calculateDiscontService;
        private readonly IOfferStockCheckService _offerStockCheckService;

        public SaleManager(ICalculateDiscontService calculateDiscontService, IOfferStockCheckService offerStockCheckService) 
        {
            _calculateDiscontService = calculateDiscontService;
            _offerStockCheckService = offerStockCheckService;
        }
        public void AddBasket(Game game, Gamer gamer, SpecialOffer offer)
        {
            Console.WriteLine(game.GameName + " added to "+gamer.FirstName+"'s basket");
            if (_offerStockCheckService.CheckStock(game))
            {
                Console.WriteLine("New offer for " + game.GameName + " : " + _calculateDiscontService.CalculateDiscount(game, offer));
            }
            else 
            {
                Console.WriteLine("Out of discount stock !! Game price is still : "+ game.GamePrice);
            }
        }

        public void Buy(Game game, Gamer gamer)
        {
            Console.WriteLine(game.GameName + " added to " + gamer.FirstName + "'s library!! Play Now !!");
        }

        public void DeleteBasket(Game game, Gamer gamer)
        {
            Console.WriteLine(game.GameName + " deleted from " + gamer.FirstName + "'s basket");
        }
    }
}
