using Engine.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Factories
{
    class MonsterFactory
    {
        public static Monster GetMonster(int monsterID)
        {
            switch(monsterID)
            {
                case 1:
                    Monster snake = new Monster("Snake", "Snake.png", 4, 4, 5, 1);
                    AddLootItem(snake, 9001, 60);
                    AddLootItem(snake, 9002, 40);

                    return snake;

                case 2:
                    Monster orc = new Monster("Orc", "Orc.jpg", 10, 10, 10, 3);
                    AddLootItem(orc, 9005, 35);
                    AddLootItem(orc, 9006, 65);

                    return orc;

                case 3:
                    Monster giantSpider = new Monster("Giant Spider", "GiantSpider.png", 9, 9, 9, 2);
                    AddLootItem(giantSpider, 9003, 50);
                    AddLootItem(giantSpider, 9004, 50);

                    return giantSpider;

                default:
                    throw new ArgumentException(string.Format("MonsterType '{0}' does not exist", monsterID));
            }
        }

        private static void AddLootItem(Monster monster, int itemID, int percentage)
        {
            if (RandomNumberGenerator.SimpleNumberBetween(1, 100) <= percentage)
                monster.Inventory.Add(new ItemQuantity(itemID, 1));
        }
    }
}
