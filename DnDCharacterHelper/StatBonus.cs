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

        public void CalculateStatBonus(int[] statBonuses)
        {
            // i dont think this is right...
            //PlayerStats modStats = new PlayerStats();
            //modStats.ModStats = modStats.OrigStats;





            for (int index = 0; index < statBonuses.Length; ++index)
            {
                foreach (int stat in statBonuses)
                {
                    if (stat >= 10)
                    {

                        int posStat = stat;
                        posStat -= 10;
                        posStat /= 2;
                        Math.Truncate((double)posStat);
                        statBonuses[index] = posStat;

                    }
                    if (stat < 10)
                    {
                        int negStat = stat;
                        negStat -= 10;
                        negStat /= 2;
                        Math.Round((double)negStat);
                        statBonuses[index] = negStat;

                    }
                }

                PlayerStats newMods = new PlayerStats();
                newMods.ModStats = statBonuses;
            }

        }

    }
}
