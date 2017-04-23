open StatsEntry
open StatsParser
open System

[<EntryPoint>]
let main argv = 
    let filename = "csstats.dat"
    let entries = StatsParser.Parse(filename)

    for entry in entries do
        Console.WriteLine("{0} {1} {2}", entry.Name, entry.Unique, entry.Kills)

    Console.ReadLine()
    0
