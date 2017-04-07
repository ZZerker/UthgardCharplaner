namespace GameData
{
    public class Resistance
    {
        public Resistance(decimal body, decimal cold, decimal crush, decimal energy, decimal heat, decimal matter, decimal slash, decimal spirit, decimal thrust)
        {
            this.Body = body;
            this.Cold = cold;
            this.Crush = crush;
            this.Energy = energy;
            this.Heat = heat;
            this.Matter = matter;
            this.Slash = slash;
            this.Spirit = spirit;
            this.Thrust = thrust;
        }

        public Resistance()
        {
        }

        public decimal Body { get; set; }
        public decimal Cold { get; set; }
        public decimal Crush { get; set; }
        public decimal Energy { get; set; }
        public decimal Heat { get; set; }
        public decimal Matter { get; set; }
        public decimal Slash { get; set; }
        public decimal Spirit { get; set; }
        public decimal Thrust { get; set; }
    }
}