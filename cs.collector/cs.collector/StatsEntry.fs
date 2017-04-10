module StatsEntry
open System

type StatsEntry() =
    member val Name = null with get, set
    member val Unique = null with get,set
    member val TeamKills = 0 with get,set
    member val Damage = 0 with get,set
    member val Deaths = 0 with get,set
    member val Kills = 0 with get,set
    member val Shots = 0  with get,set
    member val Hits = 0 with get,set
    member val HeadShots = 0 with get,set
    member val BombsDefusions = 0 with get,set
    member val BombsDefused = 0 with get,set
    member val BombsPlants = 0 with get,set
    member val BombsExplosions = 0 with get,set
    member val BodyHits = new ResizeArray<int>() with get,set
