using GameProjectDemo.Abstract;
using GameProjectDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    public class GamerCheckManager : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            if ((gamer.FirstName == "Eda") && (gamer.LastName == "Arabacı") && (gamer.DayOfBirth.Year == 1000) && (gamer.NationalId == "12345678901"))
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
