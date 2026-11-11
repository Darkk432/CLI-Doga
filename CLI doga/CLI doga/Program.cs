using System.Text.RegularExpressions;

List<Games> games = [];

const string FilePath = "..\\..\\..\\bin\\debug\\videogames.csv";
using StreamReader sr = new(FilePath);
_ = sr.ReadLine();
while (!sr.EndOfStream)
{
    var tmp = sr.ReadLine().Split(',');
    games.Add(new()
    {
        Cim =tmp[0],
        Mufaj = tmp[1],
        KiadasDatum = Convert.ToDateTime(tmp[2]),
        AktivJatekosok = int.Parse(tmp[3]),
        Ertekeles = float.Parse(tmp[4].Replace('.', ','))
    });
}

// 1. feladat
var mennyi = games.Count(p => p.Ertekeles > 4.5);
Console.WriteLine($"Ennyi 4.5-nél nagyobb játék van: {mennyi}\n");

// 2. feladat
var legtobb = games.MaxBy(p => p.AktivJatekosok);
Console.WriteLine($"Legtöbbet aktív játékossal rendelkező játék: {legtobb}\n");

// 3. feladat
var van = games.Any(p => p.KiadasDatum < new DateTime(2020, 1, 1));
Console.WriteLine($"{(van ? "van" : "nincs")} ilyen kiadású játék a listában\n");

// 4. feladat
var atlag = games.Average(p => p.Ertekeles);
Console.WriteLine($"A játékok átlag értékelései: {atlag}\n");

// 5. feladat
var kivalasz = games.Single(p => p.Cim == "Cyber City 2077");
Console.WriteLine($"Itt van az a játék a listából: {kivalasz}\n");

// 6. feladat
var csokken = games.Where(p => p.Mufaj == "RPG").OrderByDescending(p => p.KiadasDatum);
foreach(var game in csokken)
{
    Console.WriteLine($"{game.Cim}  {game.KiadasDatum}\n");
}

// 7. feladat
var legnagyobb = games.OrderByDescending(p => p.Ertekeles).Take(3);
foreach (var nagy in legnagyobb)
{
    Console.WriteLine($"{nagy.Cim}\n");
}

// 8. feladat
//var atlagok = games.Average(p => p.AktivJatekosok && p => p.KiadasDatum);
//Console.WriteLine($"A játékok átlag értékelései: {atlag}\n");

// 9. feladat
var csoport = games.GroupBy(p => p.Mufaj);
foreach (var grp in csoport)
{
    Console.WriteLine($"\t{grp.Key} ({grp.Count()} db):");
}

// 10. feladat
//var csoportos = games.GroupBy(p => p.Mufaj).OrderByDescending(p => p.Ertekeles);
//foreach (var group in csoportos)
//{
//    Console.WriteLine($"\t{group.Key}");
//}