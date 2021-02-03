﻿using KahveDukkaniUygulamasi.Abstract;
using System;

namespace KahveDukkaniUygulamasi.Entity
{
    public class Customer:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalityId { get; set; }
    }
}
