using GameProjectDemo.Abstract;
using GameProjectDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    public class GamerManager : IGamerService
    {
        private readonly IGamerCheckService _gamerCheckService;
        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }
        public void Add(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine("Successfully save to DB : "+ gamer.FirstName);
                Console.WriteLine("Hey "+ gamer.FirstName +". Welcome to game world!");
            }
            else 
            {
                Console.WriteLine("Verification failed!!");
                Console.WriteLine("Please check ID information");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Customer deleted successfully!!");
            Console.WriteLine("We hope you come again :)");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Checking...");

            if (_gamerCheckService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine("Successfully save to DB : " + gamer.FirstName);
                Console.WriteLine("Update succesfull");
            }
            else
            {
                Console.WriteLine("Verification failed!!");
                Console.WriteLine("Please check ID information");
            }
        }
    }
}
