using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1. Getters & Setters for all stat types and mods
// 2. method  to print everything to console

namespace DnDCharacterHelper
{
    class PlayerStats
    {


        private int[] _origStats; 
        public int[] OrigStats
        {
            get { return _origStats; }
            set { _origStats = value; }
        }

        private int[] _modStats;
        public int[] ModStats
        {
            get { return _modStats; }
            set { _modStats = value; }
        }

        private int[] _savingThrows;
        public int[] SavingThrows
        {
            get { return _savingThrows; }
            set { _savingThrows = value; }
        }



        public void WriteStats(int[] original, int[] modded, int[] saving)
        {
            Console.WriteLine("STATS");

                Console.WriteLine("STR: {0}", original[0]);
                Console.WriteLine("DEX: {0}", original[1]);
                Console.WriteLine("CON: {0}", original[2]);
                Console.WriteLine("WIS: {0}", original[3]);
                Console.WriteLine("INT: {0}", original[4]);
                Console.WriteLine("CHA: {0}", original[5]);

            Console.WriteLine("BONUSES");

                Console.WriteLine("STR: {0}", modded[0]);
                Console.WriteLine("DEX: {0}", modded[1]);
                Console.WriteLine("CON: {0}", modded[2]);
                Console.WriteLine("WIS: {0}", modded[3]);
                Console.WriteLine("INT: {0}", modded[4]);
                Console.WriteLine("CHA: {0}", modded[5]);

            Console.WriteLine("SAVING THROWS");

                Console.WriteLine("REFLEX: {0}", saving[1]);
                Console.WriteLine("FORT: {0}",   saving[2]);
                Console.WriteLine("WISDOM: {0}", saving[3]);

        }
    }
}
