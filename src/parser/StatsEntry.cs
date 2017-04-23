using System;

namespace ConsoleApplication3
{
    public class StatsEntry
    {
        public StatsEntry()
        {
            bodyHits = new uint[9];
        }

        public String name;
        public String unique;
        public uint tks;
        public uint damage;
        public uint deaths;
        public int kills;
        public uint shots;
        public uint hits;
        public uint hs;
        public uint bDefusions;
        public uint bDefused;
        public uint bPlants;
        public uint bExplosions;
        public uint[] bodyHits;

        public override string ToString()
        {
            return name + " " + damage + " " + kills + " " + deaths + " " + shots;
        }
    }
}