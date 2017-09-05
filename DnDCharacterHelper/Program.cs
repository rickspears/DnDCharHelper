using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
   

    1. Set OrigStats ***(later will add creating stats)***
    1.5 set new orig  stats based  on race ***(cutting until later)***
    2. CalculateStatBonus from OrigStats (OrigStats-10; /2)
    3. CalculateSavingThrows from ModStats (10+ModStats stat)
    4. print everything

 */

namespace DnDCharacterHelper
{
    class Program
    {


        static void Main(string[] args)
        {            
            PlayerStats player = new PlayerStats();
            StatBonus bonus = new StatBonus();
            SavingThrows savingThrows = new SavingThrows();


            player.OrigStats = new int[6] { 16, 13, 11, 10, 7, 6 };
            // player {s: array, ms: nothing, st: nothing}

            player.ModStats = bonus.CalculateStatBonus(player.OrigStats);
            // player {s: array, ms: array, st: nothing} 

            player.SavingThrows = savingThrows.CalculateSavingThrows(player.ModStats);
            // player {s: array, ms: array, st: array}

            player.WriteStats(player.OrigStats, player.ModStats, player.SavingThrows);

            // this is where it is messed up. how do i get separate references?
            Console.WriteLine("Orig and Mod: " + ReferenceEquals(player.OrigStats, player.ModStats));
            Console.WriteLine("Mod and ST: " + ReferenceEquals(player.ModStats, player.SavingThrows));
            Console.WriteLine("Orig and ST: " + ReferenceEquals(player.OrigStats, player.SavingThrows));
        }
    }
}
