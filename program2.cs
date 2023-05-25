using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Utazásszervezés
{
    class Program
    {
        struct uticel
        {
            public string cel;
            public string ar;
            public string letszam;

        }
        struct ugyfel
        {
            public string nev;
            public string cim;
            public string tel;

        }
        static List<ugyfel> ugyfelek = new List<ugyfel>();
        static List<uticel> uticelok = new List<uticel>();
        static void UjUgyfel()
        {
            Console.WriteLine("Kérem adja meg az utas nevét:");
            string nev = Console.ReadLine();
            Console.WriteLine("Kérem adja meg az utas telefonszámát:");
            string tel = Console.ReadLine();
            Console.WriteLine("Kérem adja meg az utas címét:");
            string cim = Console.ReadLine();
            StreamWriter ugyfelek = new StreamWriter("utas.txt", true);
            ugyfelek.WriteLine($"{nev}\t{tel}\t{cim}");
            ugyfelek.Close();
            Console.WriteLine("Az utas sikeresen hozzáadva!");
        }
        static void UjUticel()
        {
            Console.WriteLine("Kérem adja meg az uticélt:");
            string cel = Console.ReadLine();
            Console.WriteLine("Kérem adja meg az utazás árát:");
            string ar = Console.ReadLine();
            Console.WriteLine("Kérem adja meg a maximális létszámot:");
            int letszam = Convert.ToInt32(Console.ReadLine());
            StreamWriter utazasok = new StreamWriter("uticél.txt", true);
            utazasok.WriteLine($"{cel}\t{ar}\t{letszam}");
            utazasok.Close();
            Console.WriteLine("Az új utazás sikeresen hozzáadva.");
        }

        static void Main(string[] args)
        {
            string[] menupontok = { "1. Új utas hozzáadása", "2. Új utazás hozzáadása", "3. Utas lista nyomtatás", "3. Előleg módosítása", "Esc: Kilépés" };
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
                        UjUgyfel();
                        break;
                    case '2':
                        UjUticel();
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
