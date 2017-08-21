using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//pulls in PlayerStatLine list from PlayerStats to calculate bonuses for each.

namespace DnDCharacterHelper
{
    class StatBonus
    {
        PlayerStats statBonusList = new PlayerStats();

        public void GetPlayerStats()
        {
            List<int> statList = statBonusList.GetPlayerStatLine();
        }

        public void CalculateStatBonus(List<int> bonusList) //var was "stat"
        {
            //************test for list instead of single stat***********

            

            foreach (int stat in bonusList)
            {
                while (stat >= 10)
                {
                    // stat -10 / 2, return int 
                    int posStat = stat;
                    posStat -= 10;
                    posStat /= 2;
                    Math.Truncate((double)posStat);
                    bonusList.Add((int)posStat);
                }
                while (stat < 10)
                {
                    int negStat = stat;
                    negStat -= 10;
                    negStat /= 2;
                    Math.Round((double)negStat);
                    bonusList.Add((int)negStat);
                }
                
            }
            



            //*************test for list instead of single stat**********


            /*
              
             This is the code that used to bring in ints. 
             new code brings in a list.
             keeping this for now in case things go awry.
             

             
            while (stat >= 10)
            {
                // stat -10 / 2, return int 
                stat -= 10;
                stat = stat / 2;
                Math.Truncate((double)stat);
                sThrows.Add(stat);
            }
            while (stat < 10)
            {
                stat -= 10;
                stat = stat / 2;
                Math.Round((double)stat);
                sThrows.Add(stat);
            }
            */
        }

    }
}
