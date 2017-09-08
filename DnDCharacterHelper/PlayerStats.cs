using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1. Getters & Setters for all stat types and mods
// 2. method  to print everything to console

namespace DnDCharacterHelper
{
    public class PlayerStats
    {
        public List<int> OrigStats { get; set; }
        public List<int> ModStats { get; set; }
        public List<int> SavingThrows { get; set; }
        

        public void WriteStats()
        {
            Console.WriteLine("STATS");

                Console.WriteLine("STR: {0}", OrigStats[0]);
                Console.WriteLine("DEX: {0}", OrigStats[1]);
                Console.WriteLine("CON: {0}", OrigStats[2]);
                Console.WriteLine("WIS: {0}", OrigStats[3]);
                Console.WriteLine("INT: {0}", OrigStats[4]);
                Console.WriteLine("CHA: {0}", OrigStats[5]);

            Console.WriteLine("BONUSES");

                Console.WriteLine("STR: {0}", ModStats[0]);
                Console.WriteLine("DEX: {0}", ModStats[1]);
                Console.WriteLine("CON: {0}", ModStats[2]);
                Console.WriteLine("WIS: {0}", ModStats[3]);
                Console.WriteLine("INT: {0}", ModStats[4]);
                Console.WriteLine("CHA: {0}", ModStats[5]);

            Console.WriteLine("SAVING THROWS");

                Console.WriteLine("REFLEX: {0}", SavingThrows[1]);
                Console.WriteLine("FORT: {0}", SavingThrows[2]);
                Console.WriteLine("WISDOM: {0}", SavingThrows[3]);

        }
    }
}
