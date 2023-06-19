using System;

namespace UebungMitarbeiter;

public class Mitarbeiter
{
    public string Name { get; }
    public string Vorname { get; }
    public int Gehalt { get; }


    public Mitarbeiter(string name, string vorname, int gehalt)
    {
        this.Name = name;
        this.Vorname = vorname;
        this.Gehalt = gehalt;
    }

    public virtual void Arbeiten()
    {
        Console.WriteLine(Vorname + ":Ich arbeite!");
    }

    public void Pausieren()
    {
        Console.WriteLine(Vorname + ":Ich chille!");
    }
}