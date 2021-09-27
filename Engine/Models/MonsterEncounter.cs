using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Models
{
    class MonsterEncounter
    {
        public int MonsterID { get; set; }
        public int ChanceOfEncountering { get; set; }

        public MonsterEncounter(int monsterID, int chanceOfEncountering)
        {
            MonsterID = monsterID;
            ChanceOfEncountering = chanceOfEncountering;
        }
    }
}
