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
            player.OrigStats = new int[6] { 16, 13, 11, 10, 7, 6 };
            // player {s: array, ms: nothing, st: nothing}

            // learn this... just copied it. should work with less code?
            //Array.ForEach(origStats.OrigStats, pure => Console.WriteLine(pure));

            StatBonus bonus = new StatBonus();
            player.ModStats = bonus.CalculateStatBonus(origStats.OrigStats);
            // player {s: array, ms: array, st: nothing}

            SavingThrows savingThrows = new SavingThrows();
            player.SavingThrows = savingThrows.CalculateSavingThrows(player.ModStats);
            // player {s: array, ms: array, st: array}
           
            Console.WriteLine("str:{0}; dex:{1}; con:{2}; wis:{3}; " +
                "int:{4}; cha:{5}", player.OrigStats[0], player.OrigStats[1],
                player.OrigStats[2], player.OrigStats[3], player.OrigStats[4],
                player.OrigStats[5]);


            //will write these all out when it works
            Console.WriteLine(player.ModStats[0]);
            Console.WriteLine(player.SavingThrows[0]);

        }
    }
}
