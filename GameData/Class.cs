using System.Collections.Generic;

namespace GameData
{ /*#class_ID;   realm;  class_name; magic;  stat1;  stat2;  stat3;  skillfactor;    basehp; hpfac;  races;  race1;  race2;  race3;  race4;  race5;  styles; style1; style2; style3; style4; style5; style6; style7; spells; spell1; spell2; spell3;
    0           1       2           3       4       5       6       7               8       9       10      11      12      13      14      15      16      17      18      19      20      21      22      23      24      25      26      27
    1;alb;Infiltrator;0; dex; qui; str; 2.5;740; 3.6;3;2;13;4;;;5; 27*;1;2;22;33;;;1;4;;;*/
    public class Class
    {
        public string ClassId { get; set; }

        public Realm Realm { get; set; }

        public string Name { get; set; }

        public StatsEnum MagicStat { get; set; }

        public StatsEnum PrimaryStat { get; set; }

        public StatsEnum SecondaryStat { get; set; }

        public StatsEnum TertiaryStat { get; set; }

        public decimal SkillFaktor { get; set; }

        public decimal BaseHp { get; set; }

        public decimal HpFactor { get; set; }

        public IList<Race> Races { get; set; }

        public IList<Style> Styles { get; set; }

        public IList<Spell> Spells { get; set; }
    }
}
