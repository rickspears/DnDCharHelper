using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// this takes in OrigStats and returns ModStats (ability bonuses)
// after calculation

namespace DnDCharacterHelper
{
    class StatBonus
    {
        public int[] CalculateStatBonus()
        {
            PlayerStats modStats = new PlayerStats();
            modStats.ModStats = modStats.OrigStats;

            foreach (int stat in modStats.ModStats)
            {
                while (stat >= 10)
                {
                    // stat -10 / 2, return int 
                    int posStat = stat;
                    posStat -= 10;
                    posStat /= 2;
                    Math.Truncate((double)posStat);
                    modStats.ModStats[stat] = posStat;
                }
                while (stat < 10)
                {
                    int negStat = stat;
                    negStat -= 10;
                    negStat /= 2;
                    Math.Round((double)negStat);
                    modStats.ModStats[stat] = negStat;
                }
                
            }
        }

    }
}
