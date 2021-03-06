using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine.Factories
{
    static class ItemFactory
    {
        private static List<GameItem> _standardGameItems;

        static ItemFactory()
        {
            _standardGameItems = new List<GameItem>();

            _standardGameItems.Add(new Weapon(1001, "Heavy Rusty Sword", 1, 3, 5));
            _standardGameItems.Add(new Weapon(1002, "Aged Wooden Sword", 1, 2, 3));
            _standardGameItems.Add(new GameItem(9001, "Snake fang", 1));
            _standardGameItems.Add(new GameItem(9002, "Snakeskin", 2));
            _standardGameItems.Add(new GameItem(9003, "Spider Stinger", 2));
            _standardGameItems.Add(new GameItem(9004, "Spider Legs", 1));
            _standardGameItems.Add(new GameItem(9005, "Orc Medallion", 5));
            _standardGameItems.Add(new GameItem(9006, "Orc Tusk", 2));
        }

        public static GameItem CreateGameItem(int itemTypeID)
        {
            GameItem standardItem = _standardGameItems.FirstOrDefault(item => item.ItemTypeID == itemTypeID);

            if (standardItem != null)
                return standardItem.Clone();

            return null;
        }
    }
}
