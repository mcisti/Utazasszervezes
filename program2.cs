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
        static void Jelentkezes()
        {
            Console.WriteLine("Kérem adja meg a nevét:");
            string nev1 = Console.ReadLine();
            Console.WriteLine("Kérem adja meg az Uticélt:");
            string cel2 = Console.ReadLine();
            Console.WriteLine("Kérem adja meg az előleg összegét:");
            int eloleg = int.Parse(Console.ReadLine());
            string[] utas = File.ReadAllLines("utas.txt");
            string[] utas1 = new string[utas.Length];
            for (int i = 0; i < utas.Length; i++)
            {
                utas1[i] = utas[i].Split("\t")[0];
            }
            string[] ut = File.ReadAllLines("uticél.txt");
            string[] ut1 = new string[ut.Length];
            StreamWriter uj = new StreamWriter("Jelentkezes.txt");
            for (int i = 0; i < ut.Length; i++)
            {
                ut1[i] = ut[i].Split("\t")[0];
            }
            
                if (utas1.Contains(nev1))
                {
                    uj.Write($"{nev1}\t");
                
                }
                else
                {
                    Console.WriteLine("Nincs ilyen utas, kérem adja hozzá az 1. menüpontban!");
                }
                if (ut1.Contains(cel2))
                {
                    uj.Write($"{cel2}\t");

                }
                else
                {
                    Console.WriteLine("Nincs ilyen utazás, kérem adja hozzá az 2. menüpontban!");
                }
                uj.WriteLine($"{eloleg}\t");
            Console.WriteLine("Sikeresen jelentkeztél!");
            uj.Close();
        }

        static void Utaslista()
        {
            StreamWriter utaslista = new StreamWriter("Utaslista.txt");
            Console.WriteLine("Melyi utazás utaslistályát szeretné nyomtatni");
            string utazas = Console.ReadLine();
            List<string> utasok = new List<string>();
            string[] allomany = File.ReadAllLines("Jelentkezes.txt");
            string[] jelenkezettNev = new string[allomany.Length];
            string[] jelenkezettOrszag = new string[allomany.Length];
            for (int i = 0; i < allomany.Length; i++)
            {
                jelenkezettNev[i] = allomany[i].Split('\t')[0];
                jelenkezettOrszag[i] = allomany[i].Split('\t')[1];
            }
            for (int i = 0; i < jelenkezettOrszag.Length; i++)
            {
                if (utazas == jelenkezettOrszag[i])
                {
                    utasok.Add(jelenkezettNev[i]);
                }
            }
            for (int i = 0; i < jelenkezettNev.Length; i++)
            {
                utaslista.Write($"{utazas}\t");
                utaslista.WriteLine($"{utasok[i]}");
            }
            utaslista.Close();
            Console.WriteLine("Sikeres nyomtatás");


        }
        static void Main(string[] args)
        {
            string[] menupontok = { "1. Új utas hozzáadása", "2. Új utazás hozzáadása","3. Jeletkezés az utazásra", "4. Utaslista nyomtatás", "Esc: Kilépés" };
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
                        Jelentkezes();
                        break;
                    case '4':
                        Utaslista();
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
