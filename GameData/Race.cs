namespace GameData
{
    /*Race	realm	STR	CON	DEX	QUI	INT	PIE	EMP	CHA	Body	Cold	Crush	Energy	Heat	Matter	Slash	Spirit	Thrust*/
    /*Race;     realm;  STR;CON;DEX;QUI;INT;PIE;EMP;CHA;Body;   Cold;   Crush;  Energy; Heat;   Matter; Slash;  Spirit; Thrust
    Avalonian;  Albion; 45; 45; 60; 70; 80; 60; 60; 60; 0;      0;      2;      0;      0;      0;      3;      5;      0*/
    public class Race
    {
        public Race()
        {
        }

        public Race(string id, string name, Realm realm, Resistance resistance, Stats stats)
        {
            this.Id = id;
            this.Name = name;
            this.Realm = realm;
            this.Resistance = resistance;
            this.Stats = stats;
        }

        public string Id { get; set; }

        public string Name { get; set; }

        public Realm Realm { get; set; }

        public Resistance Resistance { get; set; }

        public Stats Stats { get; set; }
    }
}
