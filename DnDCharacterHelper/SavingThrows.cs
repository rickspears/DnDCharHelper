using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//class saving throws; methods calculate saving throws, 

namespace DnDCharacterHelper
{
    class SavingThrows
    {
        public int[] CalculateSavingThrows()
        {
            PlayerStats savingThrows = new PlayerStats();
            savingThrows.SavingThrows = savingThrows.ModStats;

            foreach (int stat in savingThrows.SavingThrows)
            {
                int savThro = stat + 10;
                savingThrows.SavingThrows[stat] = savThro;

                



            }


        }

    }
}
