using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
    we need a DnD character helper to read the stats of a player, modify the stats due to your race, 
    calculate stat bonuses per stat, and calculate saving throws based on the new stat bonuses.

    the stats are entered as ints from 3-18 (but can be raised to over 18 due to race), and the saving throws are 10 + stat bonus.    

    1. Set OrigStats
    1.5 set new orig  stats based  on race (cutting for now?)
    2. CalculateStatBonus (ModStats) (-10; /2)
    3. CalculateSavingThrows from ModStats (10+ModStats stat)
    4. print everything


 */

namespace DnDCharacterHelper
{
    class Program
    {


        static void Main(string[] args)
        {



            PlayerStats origStats = new PlayerStats();
            //
            //PlayerStats savingThrows = new PlayerStats();

            origStats.OrigStats = new int[] { 16, 13, 11, 10, 7, 6 };

            Console.WriteLine(origStats.OrigStats);
            Console.WriteLine(origStats.ModStats);
            Console.WriteLine(origStats.SavingThrows);

        }
    }
}
