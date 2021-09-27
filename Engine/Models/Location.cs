using Engine.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine.Models
{
    public class Location
    {
        public int XCoordinate { get; set; }

        public int YCoordinate { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageName { get; set; }

        public List<Quest> QuestsAvailableHere { get; set; } = new List<Quest>();
        public List<MonsterEncounter> Monsters { get; set; } = new List<MonsterEncounter>();



        public void AddMonster(int monsterID, int chanceOfEncountering)
        {
            if (Monsters.Exists(mon => mon.MonsterID == monsterID))
                Monsters.First(mon => mon.MonsterID == monsterID).ChanceOfEncountering = chanceOfEncountering;

            else
                Monsters.Add(new MonsterEncounter(monsterID, chanceOfEncountering));
        }



        public Monster GetMonster()
        {
            if (!Monsters.Any())
                return null;

            int totalChances = Monsters.Sum(mon => mon.ChanceOfEncountering);

            int randomNumber = RandomNumberGenerator.SimpleNumberBetween(1, totalChances);

            int runningTotal = 0;

            foreach (MonsterEncounter monsterEncounter in Monsters)
            {
                runningTotal += monsterEncounter.ChanceOfEncountering;

                if (randomNumber <= runningTotal)
                    return MonsterFactory.GetMonster(monsterEncounter.MonsterID); 
            }

            // Just return the the last monster in the monsters list if there was a problem with using the random number generator
            return MonsterFactory.GetMonster(Monsters.Last().MonsterID);
        }
    }
}
