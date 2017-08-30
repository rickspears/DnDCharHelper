using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// pulls in origstats from playerstats, spits out savingthrows to playerstats
//names = names.Select(x => x.Replace("pdf", "txt")).ToArray();
namespace DnDCharacterHelper
{
    class StatBonus
    {
        int[] quickStats;
        
        public int[] CalculateStatBonus(int[] statBonuses)
        {
            //JUST CHANGED THIS 8/30 to see if copying it over before modifying it works....
            //using quickStats to change shit instead of statBonuses
            quickStats = statBonuses;
            

            for (int index = 0; index < quickStats.Length; ++index)
            {
                foreach (int stat in quickStats)
                {
                    if (stat >= 10)
                    {

                        int posStat = stat;
                        posStat -= 10;
                        posStat /= 2;
                        Math.Truncate((double)posStat);
                        quickStats[index] = posStat;

                    }
                    if (stat < 10)
                    {
                        int negStat = stat;
                        negStat -= 10;
                        negStat /= 2;
                        Math.Round((double)negStat);
                        quickStats[index] = negStat;

                    }
                }

            }
            return quickStats;
        }

    }
}
