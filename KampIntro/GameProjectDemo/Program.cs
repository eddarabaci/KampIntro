using GameProjectDemo.Abstract;
using GameProjectDemo.Concrete;
using GameProjectDemo.Entity;
using System;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GameProjectDemo V1 created by Eda Arabacı");
            //added GAMER
            Gamer gamer1 = new Gamer{ Id = 1, FirstName = "Eda", LastName = "Arabacı", DayOfBirth = new DateTime(1000, 1, 2), NationalId = "12345678901" };

            GamerManager gamerManager = new GamerManager(new GamerCheckManager());
            gamerManager.Add(gamer1);


            //Added GAMES
            Game game1 = new Game { Id = 1, GameId = 1010, GameName = "WeakCircle", GamePrice = 85.50 , GameType = "Strategy Game", UnitStock = 10 };
            Game game2 = new Game { Id = 2, GameId = 1011, GameName = "Vengeance II", GamePrice = 150, GameType = "War Game" , UnitStock = 5 };

            GameManager gameManager = new GameManager();
            gameManager.AddGame(game1);
            gameManager.UpdateGame(game2);

            //Added OFFERS
            SpecialOffer specialOffer1 = new SpecialOffer { Id = 1, OfferId = 101, OfferName = "Winter is comming",DiscountRate = 10};
            SpecialOffer specialOffer2 = new SpecialOffer { Id = 2, OfferId = 102, OfferName = "Happy Mondays", DiscountRate = 50 };

            SpecialOfferManager specialOfferManager = new SpecialOfferManager();
            specialOfferManager.OfferAdd(specialOffer1);
            specialOfferManager.OfferUpdate(specialOffer2);


            //BASKET OPERATIONS
            SaleManager saleManager = new SaleManager(new CalculateDiscountManager(), new OfferStockCheckService());
            saleManager.AddBasket(game1, gamer1,specialOffer2);
            saleManager.AddBasket(game2, gamer1,specialOffer1);
            saleManager.DeleteBasket(game1, gamer1);
            saleManager.Buy(game2, gamer1);


            

            

        }
    }
}
