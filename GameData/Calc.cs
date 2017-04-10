using System;
using System.Collections.Generic;
using System.Text;

namespace GameData
{
    class Calc
    {
        //Vars
        decimal sum_qui = 210m;
        decimal hast_buff = 0.2m;  // Haste Buff
        decimal celerity_healer = 0.31m; // Cele
        decimal weapon_base_speed = 6.0m; // Base weaponspeed of the current weapon


            //Calc  Source: http://camelotherald.wikia.com/wiki/Quickness#Melee
            if (sum_qui >= 250)
            {
                decimal swing_speed = Math.Round((((weapon_base_speed * 100m)) * (1m - (250 - 50m) / 500m) * (1 - (hast_buff + celerity_healer)) / 100), 2);
            }
            else
            {
                decimal swing_speed = Math.Round((((weapon_base_speed * 100m)) * (1m - (sum_qui - 50m) / 500m) * (1 - (hast_buff + celerity_healer)) / 100), 2);

            }

    }
}