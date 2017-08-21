using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
    we need a DnD character helper to read the stats of a player, modify the stats due to your race, 
    calculate stat bonuses per stat, and calculate saving throws based on the new stat bonuses.

    the stats are entered as ints from 3-18 (but can be raised to over 18 due to race), and the saving throws are 10 + stat bonus.    

 */

namespace DnDCharacterHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerStats charSheet = new PlayerStats();

            charSheet.AddStat(16);
            charSheet.AddStat(13);
            charSheet.AddStat(11);
            charSheet.AddStat(10);
            charSheet.AddStat(7);
            charSheet.AddStat(6);


            StatBonus bonuses = PlayerStatLine ();
            bonuses.CalculateStatBonus(PlayerStatLine);

            SavingThrows savingThrows = new SavingThrows();

            
        }
    }
}
