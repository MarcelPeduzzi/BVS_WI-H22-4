using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UebungMitarbeiter
{
    class Program
    {
        public static void Main(string[] args)
        {
            Mitarbeiter mitarbeiter1 = new Mitarbeiter("Rüdiger", "Karl-Heinz", 40000);
            Boss boss1 = new Boss("Porsche", "Norris", "Chuck", 999999999);
            Azubi azubi1 = new Azubi(80, 30, "Murray", "Bill", 250000);

            mitarbeiter1.Arbeiten();
            boss1.Fuehren();
            azubi1.Arbeiten();
            azubi1.Lernen();

            Console.ReadKey(false);
        }


    }
   
}
