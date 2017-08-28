using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Getters & Setters for all stat types and mods

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

    }
}
