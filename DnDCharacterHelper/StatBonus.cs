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
        public List<int> CalculateStatBonus(List<int> statBonuses)
        {
            List<int> newModStats = new List<int>();

            foreach (int moddedStat in statBonuses)
            {
                int stat = moddedStat;
                if (moddedStat >= 10)
                {
                    stat -= 10;
                    stat /= 2;
                    Math.Truncate((double)stat);
                    newModStats.Add(stat);
                }
                if (moddedStat < 10)
                {
                    stat -= 10;
                    stat /= 2;
                    Math.Round((double)stat);
                    newModStats.Add(stat);
                }
            }
            return newModStats;
        }
    }
}
