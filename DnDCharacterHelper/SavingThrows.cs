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
        public int[] CalculateSavingThrows(int[] savThro)
        {
            for (int index = 0; index < savThro.Length; index++)
            {
                int replaceStat = savThro[index];
                replaceStat += 10;
                savThro[index] = replaceStat; 


            }
            return savThro;
        }

    }
}
