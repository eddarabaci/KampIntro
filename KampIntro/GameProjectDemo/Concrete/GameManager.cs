using GameProjectDemo.Abstract;
using GameProjectDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    public class GameManager : IGameService
    {
        public void AddGame(Game game)
        {
            Console.WriteLine(game.GameName + " was saved to DB");
        }

        public void DeleteGame(Game game)
        {
            Console.WriteLine(game.GameName + " was deleted from DB");
        }

        public void UpdateGame(Game game)
        {
            Console.WriteLine(game.GameName + " updated in DB");
        }
    }
}
