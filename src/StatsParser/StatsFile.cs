using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StatsParser
{
    public class StatsFile
    {
        public const short RankVersion = 11;

        public static IEnumerable<StatsEntry> ReadEntries(string file)
        {
            if (!File.Exists(file))
            {
                throw new FileNotFoundException();
            }

            using (FileStream stream = File.Open(file, FileMode.Open))
            {
                using (BinaryReader br = new BinaryReader(stream))
                {
                    var list = new List<StatsEntry>();

                    try
                    {
                        short vers = br.ReadInt16();

                        if (vers != RankVersion)
                        {
                            throw new Exception("Bad stats version");
                        }

                        ushort num = br.ReadUInt16();

                        while (num != 0)
                        {
                            StatsEntry entry = new StatsEntry();

                            byte[] name = br.ReadBytes(num);
                            num = br.ReadUInt16();
                            byte[] unique = br.ReadBytes(num);

                            entry.name = Encoding.ASCII.GetString(name, 0, name.Length - 1);
                            entry.unique = Encoding.ASCII.GetString(unique, 0, unique.Length - 1);

                            entry.tks = br.ReadUInt32();
                            entry.damage = br.ReadUInt32();
                            entry.deaths = br.ReadUInt32();
                            entry.kills = br.ReadInt32();
                            entry.shots = br.ReadUInt32();
                            entry.hits = br.ReadUInt32();
                            entry.hs = br.ReadUInt32();
                            entry.bDefusions = br.ReadUInt32();
                            entry.bDefused = br.ReadUInt32();
                            entry.bPlants = br.ReadUInt32();
                            entry.bExplosions = br.ReadUInt32();

                            for (int i = 0; i < entry.bodyHits.Length; i++)
                            {
                                entry.bodyHits[i] = br.ReadUInt32();
                            }

                            num = br.ReadUInt16();

                            list.Add(entry);
                        }
                    }
                    catch
                    {
                        throw new FileLoadException("Error reading file");
                    }

                    return list;
                }
            }
        }
    }
}
