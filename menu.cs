using System;

namespace Utazásszervezés
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] menupontok = { "1. Új utazás hozzáadása", "2. Utas lista módosítása", "3. Előleg módosítása", "Esc: Kilépés" };
            while (true)
            {
                Console.Clear();
                for (int i = 0; i < menupontok.Length; i++)
                {
                    Console.WriteLine(menupontok[i]);
                }
                char valasz = Console.ReadKey().KeyChar;
                Console.Clear();
                switch (valasz)
                {
                    case '1':
                        Console.WriteLine("szia");
                        break;
                    case '2':
                        Console.WriteLine("szia");
                        break;
                    case '3':
                        Console.WriteLine("szia");
                        break;
                    case ((char)ConsoleKey.Escape):
                        System.Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Nincs Ilyen menüpont!");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
