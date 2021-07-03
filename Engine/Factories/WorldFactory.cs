using System;
using System.Collections.Generic;
using System.Text;
using Engine.Models;

namespace Engine.Factories
{
    internal static class WorldFactory
    {
        internal static World CreateWorld()
        {
            World newWorld = new World();
            
            newWorld.AddLocation(0, -1, "Home", "Thunder Dragon Sage's Home", "pack://application:,,,/Engine;component/Images/Locations/Home.png");

            newWorld.AddLocation(-2, -1, "Farmer's Field", "There are rows of corn growing here, that orc packs are eying.",
                "pack://application:,,,/Engine;component/Images/Locations/FarmFields.png");

            newWorld.AddLocation(-1, -1, "Farmer's House", "House of the farmer who lives at the summit of Dragon Sage Mountain",
                "pack://application:,,,/Engine;component/Images/Locations/Farmhouse.png");

            newWorld.AddLocation(-1, 0, "Trading Shop", "The shop of Susan, the trader.",
                "pack://application:,,,/Engine;component/Images/Locations/Trader.png");

            newWorld.AddLocation(0, 0, "Town square", "You see a fountain here.",
                "pack://application:,,,/Engine;component/Images/Locations/TownSquare.png");

            newWorld.AddLocation(1, 0, "Town Gate", "There is a gate here, protecting the town from giant spiders.",
                "pack://application:,,,/Engine;component/Images/Locations/TownGate.png");

            newWorld.AddLocation(2, 0, "Spider Forest", "The trees in this forest are covered with spider webs.",
                "pack://application:,,,/Engine;component/Images/Locations/SpiderForest.png");

            newWorld.AddLocation(0, 1, "Herbalist's hut", "You see a small hut, with plants drying from the roof.",
                "pack://application:,,,/Engine;component/Images/Locations/HerbalistsHut.png");

            newWorld.AddLocation(0, 2, "Herbalist's garden", "There are many plants here, with snakes hiding behind them.",
                "pack://application:,,,/Engine;component/Images/Locations/HerbalistsGarden.png");

            return newWorld;
        }
    }
}
