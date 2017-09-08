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
        private List<string> StatTypes = new List<string>
        {
            "STR", "DEX", "CON", "WIS", "INT", "CHA"
        };
        private List<string> SavingThrowTypes = new List<string>
        {
            "Reflex", "FORT", "WISDOM"
        };
        public List<int> OrigStats { get; set; }
        public List<int> ModStats { get; set; }
        public List<int> SavingThrows { get; set; }


        public override string ToString()
        {
            var origStats = string.Join(Environment.NewLine, StatTypes.Zip(OrigStats, (type, stat) => $"{type}: {stat}"));
            var modStats = string.Join(Environment.NewLine, StatTypes.Zip(ModStats, (type, stat) => $"{type}: {stat}"));            
            var savingThrows = string.Join(Environment.NewLine, SavingThrowTypes.Zip(SavingThrows, (type, stat) => $"{type}: {stat}"));
            return $"STATS{Environment.NewLine}{origStats}{Environment.NewLine}BONUSES{Environment.NewLine}{modStats}{Environment.NewLine}SAVING THROWS{Environment.NewLine}{savingThrows}";
        }

        public void WriteStats()
        {
            Console.WriteLine(ToString());
        }
    }
}
