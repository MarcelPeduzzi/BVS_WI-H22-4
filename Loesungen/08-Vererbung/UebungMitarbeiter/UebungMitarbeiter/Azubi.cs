using System;

namespace UebungMitarbeiter;

public class Azubi : Mitarbeiter
{
    public int Arbeitsstunden { get; }
    public int Schulstunden { get; }

    public Azubi(int arbeitsstunden, int schulstunden, string name, string vorname, int gehalt) : base(name, vorname, gehalt)
    {
        this.Arbeitsstunden = arbeitsstunden;
        this.Schulstunden = schulstunden;
    }

    public void Lernen()
    {
        Console.WriteLine(Vorname + ":Ich lerne " + Schulstunden + " Stunden!");
    }

    public override void Arbeiten()
    {
        Console.WriteLine(Vorname + ":Ich arbeite " + Arbeitsstunden + " Stunden!");
    }
}