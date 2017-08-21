using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//class player stats; methods adding stats, modifying stats for race, 
//calculating bonuses per stat

namespace DnDCharacterHelper
{
    class PlayerStats
    {

        List<int> playerStatLine = new List<int>();

        public void AddStat(int stat)
        {
            playerStatLine.Add(stat);
        }

       

        public List<int> GetPlayerStatLine()
        {
            return playerStatLine;
        }

    }
}
