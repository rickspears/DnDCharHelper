using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//pulls in modstats from playerstats, spits out savingthrows to playerstats

namespace DnDCharacterHelper
{
    class SavingThrows
    {
        public List<int> CalculateSavingThrows(List<int> savThro)
        {
            List<int> newSavThro = new List<int>();
            foreach (int sav in savThro)
            {
                int newSav = sav;
                newSav += 10;
                newSavThro.Add(newSav);
            }
            return newSavThro;
        }

    }
}
