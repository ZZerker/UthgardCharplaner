namespace GameData
{
    public class Stats
    {
        public Stats()
        {
        }

        public Stats(decimal strengh, decimal constituion, decimal dexterity, decimal quickness, decimal intelligence, decimal piety, decimal empathy, decimal charisma)
        {
            this.Strengh = strengh;
            this.Constituion = constituion;
            this.Dexterity = dexterity;
            this.Quickness = quickness;
            this.Intelligence = intelligence;
            this.Piety = piety;
            this.Empathy = empathy;
            this.Charisma = charisma;
        }

        public decimal Strengh { get; set; }

        public decimal Constituion { get; set; }

        public decimal Dexterity { get; set; }

        public decimal Quickness { get; set; }

        public decimal Intelligence { get; set; }

        public decimal Piety { get; set; }

        public decimal Empathy { get; set; }

        public decimal Charisma { get; set; }
    }
}
