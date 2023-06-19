using System;

namespace UebungMitarbeiter;

public class Boss : Mitarbeiter
{

    public string Firmenwagen { get; }


    public Boss(string firmenwagen, string name, string vorname, int gehalt) : base(name, vorname, gehalt)
    {
        this.Firmenwagen = firmenwagen;

    }

    public void Fuehren()
    {
        Console.WriteLine(Vorname + ":Ich führe!");
    }
}