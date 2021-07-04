﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Models
{
    class Weapon : GameItem
    {
        public int MinimumDamage { get; set; }

        public int MaximumDamage { get; set; }

        public Weapon(int itemTypeID, string name, int price, int minimumDamage, int maximumDamage) : base(itemTypeID, name, price)
        {
            MinimumDamage = minimumDamage;
            MaximumDamage = maximumDamage;
        }

        public new Weapon Clone()
        {
            return new Weapon(ItemTypeID, Name, Price, MinimumDamage, MaximumDamage);
        }
    }
}
