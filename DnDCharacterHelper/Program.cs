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
            
            PlayerStats origStats = new PlayerStats();
            origStats.OrigStats = new int[6] { 16, 13, 11, 10, 7, 6 };

            // learn this... just copied it. should work with less code?
            //Array.ForEach(origStats.OrigStats, pure => Console.WriteLine(pure));

            StatBonus modStats = new StatBonus();
            modStats.CalculateStatBonus(origStats.OrigStats);


            SavingThrows savingThrows = new SavingThrows();
            savingThrows.CalculateSavingThrows(origStats.ModStats);



            Console.WriteLine("str:{0}; dex:{1}; con:{2}; wis:{3}; " +
                "int:{4}; cha:{5}", origStats.OrigStats[0], origStats.OrigStats[1],
                origStats.OrigStats[2], origStats.OrigStats[3], origStats.OrigStats[4],
                origStats.OrigStats[5]);


            //will write these all out when it works
            Console.WriteLine(origStats.ModStats[0]);
            Console.WriteLine(origStats.SavingThrows[0]);

        }
    }
}
