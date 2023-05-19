using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace _Utazási_iroda__program
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
            StreamWriter ugyfelek = new StreamWriter(".txt", true);
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
        StreamWriter utazasok = new StreamWriter(".txt", true);
            utazasok.WriteLine($"{cel}\t{ar}\t{letszam}");
            utazasok.Close();
            Console.WriteLine("Az új utazás sikeresen hozzáadva.");
        }

    static void Main(string[] args)
        {
            
        }
    }
}
