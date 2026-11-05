using Rollerkolcsonzo;
using System.Runtime.CompilerServices;

List<RollerUtazas> utazasok = new List<RollerUtazas>();

Console.WriteLine("Adatok beolvasása a rollerek.txt fájlból...");

string[] sorok = File.ReadAllLines("rollerek.txt");

Console.WriteLine("Utazások részletei: ");

foreach (string sor in sorok)
{
    utazasok.Add(new RollerUtazas(sor));
}

foreach(RollerUtazas aktualis in utazasok)
{
    Console.WriteLine(aktualis);
}
Console.WriteLine("Statisztika: ");

int teljes = utazasok.Sum(x => x.FizetendoDij());

Console.WriteLine($"Kölcsönző teljes napi bevétele: {teljes} Ft");

RollerUtazas leg = utazasok.MaxBy(x => x.UtazasiIdoPerc);

Console.WriteLine($"Leghosszabb utazás: {leg.FelhasznaloNev} ({leg.UtazasiIdoPerc} percc)");