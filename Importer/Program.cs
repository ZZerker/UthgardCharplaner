using System;
using System.Collections.Generic;
using System.IO;
using GameData;

namespace Importer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var calculation = new Calculation();

            var celerityHealer = 0.31m; // Cele
            var hastBuff = 0.2m; // Haste Buff
            var sumQui = 210m;
            var weaponBaseSpeed = 6.0m; // Base weaponspeed of the current weapon

            Console.WriteLine("Attack Speed: " + calculation.CalculateWeaponAttackSpeed(sumQui, weaponBaseSpeed, celerityHealer, hastBuff));


            var races = ParseRaces(@"..\..\..\RawData\races.csv");

            Console.WriteLine("Press Key to quit.");
            Console.ReadKey();
        }

        private static List<Race> ParseRaces(string path)
        {
            var list = new List<Race>();
            using(var sw = new StreamReader(path))
            {
                while(!sw.EndOfStream)
                {
                    var line = sw.ReadLine();
                    if(line.StartsWith("#"))
                    {
                        continue;
                    }

                    Console.WriteLine(line);
                    if(!string.IsNullOrEmpty(line))
                    {
                        var split = line.Split(';');

                        var stats = new Stats(ReadDecimal(split, 3), ReadDecimal(split, 4), ReadDecimal(split, 5), ReadDecimal(split, 6), ReadDecimal(split, 7), ReadDecimal(split, 8), ReadDecimal(split, 9), ReadDecimal(split, 10));

                        var resistance = new Resistance(ReadDecimal(split, 11),
                                                        ReadDecimal(split, 12),
                                                        ReadDecimal(split, 13),
                                                        ReadDecimal(split, 14),
                                                        ReadDecimal(split, 15),
                                                        ReadDecimal(split, 16),
                                                        ReadDecimal(split, 17),
                                                        ReadDecimal(split, 18),
                                                        ReadDecimal(split, 19));

                        list.Add(new Race(split[0], split[1], ReadRealm(split[2]), resistance, stats));
                    }
                }
            }
            return list;
        }

        private static decimal ReadDecimal(string[] line, int i)
        {
            return Convert.ToDecimal(line[i]);
        }

        private static Realm ReadRealm(string value)
        {
            return (Realm)Enum.Parse(typeof(Realm), value);
        }
    }
}
