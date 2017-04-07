using System;
using System.Collections.Generic;
using System.IO;
using GameData;

namespace Importer
{
    internal class Program
    {
        /*/*Race	realm	STR	CON	DEX	QUI	INT	PIE	EMP	CHA	Body	Cold	Crush	Energy	Heat	Matter	Slash	Spirit	Thrust*/
        /*Race;     realm;  STR;CON;DEX;QUI;INT;PIE;EMP;CHA;Body;   Cold;   Crush;  Energy; Heat;   Matter; Slash;  Spirit; Thrust
         * 0        1       2   3   4   5   6   7   8   9   10      11      12      13      14      15      16      17      18
        Avalonian;  Albion; 45; 45; 60; 70; 80; 60; 60; 60; 0;      0;      2;      0;      0;      0;      3;      5;      0*/


        private static void Main(string[] args)
        {
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
                    Console.WriteLine(line);
                    if(!string.IsNullOrEmpty(line))
                    {
                        var split = line.Split(';');

                        var stats = new Stats(ReadDecimal(split, 3), ReadDecimal(split, 4), ReadDecimal(split, 5), ReadDecimal(split, 6), ReadDecimal(split, 7), ReadDecimal(split, 8), ReadDecimal(split, 9), ReadDecimal(split, 10));

                        var resistance = new Resistance(ReadDecimal(split, 11), ReadDecimal(split, 12), ReadDecimal(split, 13), ReadDecimal(split, 14), ReadDecimal(split, 15), ReadDecimal(split, 16), ReadDecimal(split, 17), ReadDecimal(split, 18), ReadDecimal(split, 19));

                        list.Add(new Race(split[0], split[1], ReadRealm(split[2]), resistance, stats));
                    }
                }
            }
            return list;
        }

        private static Realm ReadRealm(string value)
        {
            return (Realm)Enum.Parse(typeof(Realm), value);
        }

        private static decimal ReadDecimal(string[] line, int i)
        {
            return Convert.ToDecimal(line[i]);
        }
    }
}
