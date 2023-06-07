namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte geben Sie eine Farbe ein: ");
            string farbe = Console.ReadLine();
            switch (farbe.ToLower())
            {
                case "rot":
                    Console.WriteLine("Die Farbe rot steht für Liebe");
                    break;

                case "blau":
                    Console.WriteLine("Die Farbe blau steht für Ruhe, Vertrauen und Tiefe");
                    break;
                case "grün":
                case "gruen":
                    Console.WriteLine("Die Farbe grün steht für Hoffnung und Natur");
                    break;
                case "gelb":
                    Console.WriteLine("Die Farbe gelb steht für due Eifersucht");
                    break;
                default:
                    Console.WriteLine("Kommt nicht im Regenbogen vor!!!");
                    break;
            }
        }
    }
}
