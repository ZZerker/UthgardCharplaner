using System;

namespace GameData
{
    public class Calculation
    {
        private decimal celerity_healer = 0.31m; // Cele
        private decimal hast_buff = 0.2m; // Haste Buff
        private decimal sum_qui = 210m;
        private decimal weapon_base_speed = 6.0m; // Base weaponspeed of the current weapon


        /// <summary>
        ///     Calculation  Source: http://camelotherald.wikia.com/wiki/Quickness#Melee
        /// </summary>
        /// <param name="totalQuickness"></param>
        /// <param name="weaponBaseSpeed"></param>
        /// <param name="attackSpeedPulse"></param>
        /// <param name="hasteBuff"></param>
        /// <returns></returns>
        public decimal CalculateWeaponAttackSpeed(decimal totalQuickness, decimal weaponBaseSpeed, decimal attackSpeedPulse, decimal hasteBuff)
        {

            if(totalQuickness >= 250m)
            {
                totalQuickness = 250m;
            }

            return Math.Round(weaponBaseSpeed * 100m * (1m - (totalQuickness - 50m) / 500m) * (1 - (hasteBuff + attackSpeedPulse)) / 100m, 2);
        }
    }
}
