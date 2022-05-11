using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01Dziedziczenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 4;

            object o = a;

            int b = (int)o;

            Czlowiek c = new Czlowiek();

            Zawodnik z = new Zawodnik();
            z.Imie = "Jan";
            z.Nazwisko = "Kowalski";
            z.PrzedstawSie();
            z.LiczbaMedli = 4;
            Czlowiek c2 = new Zawodnik(); // niejawne rzutowanie

            Czlowiek c3 = z; // niejawne rzutowanie 

            int a2= ((Zawodnik)c3).LiczbaMedli;

            // Trener t2 = (Trener)c3; // tu będzie błąd
            Object o2 = z;



            Console.WriteLine(c);

            object[] tablica = new object[3];
            tablica[0] = 4;
            tablica[1] = z;
            tablica[2] = new Trener();


            Czlowiek[] ludzie = new Czlowiek[3];
            ludzie[0] = z;
            ludzie[1] = new Trener();

            foreach (var k in ludzie)
            {
                Console.WriteLine(k.PrzedstawSie());
            }

            


        }
    }
}
