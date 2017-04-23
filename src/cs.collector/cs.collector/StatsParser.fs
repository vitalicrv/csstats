module StatsParser

open System
open System.Text
open System.IO
open StatsEntry

type StatsParser() =

    static member Parse(filename) = 
        let rankVersion = 11

        use reader = new BinaryReader(File.Open(filename, FileMode.Open, FileAccess.Read, FileShare.Read))
        let version = reader.ReadInt16()
        
        //if version <> rankVersion

        let mutable num = int(reader.ReadUInt16());
        let list = new ResizeArray<StatsEntry>()

        while (num <> 0) do
            let entry = new StatsEntry();

            let name = reader.ReadBytes(num);
            num <- int(reader.ReadUInt16())
            let unique = reader.ReadBytes(num);

            entry.Name <- Encoding.ASCII.GetString(name, 0, name.Length - 1);
            entry.Unique <- Encoding.ASCII.GetString(unique, 0, unique.Length - 1);
            entry.TeamKills <- int(reader.ReadUInt32())
            entry.Damage <- int(reader.ReadUInt32())
            entry.Deaths <- int(reader.ReadUInt32())
            entry.Kills <- int(reader.ReadInt32())
            entry.Shots <- int(reader.ReadUInt32())
            entry.Hits <- int(reader.ReadUInt32())
            entry.HeadShots <- int(reader.ReadUInt32())
            entry.BombsDefusions <- int(reader.ReadUInt32())
            entry.BombsDefused <- int(reader.ReadUInt32())
            entry.BombsPlants <- int(reader.ReadUInt32())
            entry.BombsExplosions <- int(reader.ReadUInt32())

            for i = 0 to 8 do
                entry.BodyHits.Add(int(reader.ReadUInt32()))

            num <- int(reader.ReadUInt16());
            list.Add(entry);

        list