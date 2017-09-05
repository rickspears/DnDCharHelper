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
        int[] inputStats;
        public int[] CalculateStatBonus(int[] statBonuses)
        {
            inputStats = statBonuses;

            for (int index = 0; index < inputStats.Length; index++)
            {
                if (inputStats[index] >= 10)
                {
                    inputStats[index] -= 10;
                    inputStats[index] /= 2;
                    Math.Truncate((double)inputStats[index]);

                }
                if (inputStats[index] < 10)
                {
                    inputStats[index] -= 10;
                    inputStats[index] /= 2;
                    Math.Round((double)inputStats[index]);
                }
            }
            return inputStats;
        }
    }
}
