using P05AplikacjaZawodnicy.Core.Domains;
using P05AplikacjaZawodnicy.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06SkladniaLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // skladania linq pozwala na odpytwanie zbioru danych (kolekcji) 

            string[] napisy = { "ala", "ma", "kota" };

            string[] tylkoDlugie = napisy.Where(dowolnaNazwa => dowolnaNazwa.Length > 2).ToArray();

            foreach (var e in tylkoDlugie)
                Console.WriteLine(e);




            string[] wynik1 = napisy.Where(x => x.Substring(0, 1).ToLower() == "a").ToArray();
            int[] liczby = { 1, 5, 7, 3, 2, 8 };
            int[] wynik2 = liczby.Where(x => x > 3).ToArray();


            //ciekawie sie zaczyna dziac gdy mamy doczynienia z kolejcka obiektow np zawodnikow 

            ZawodnicyRepository zr = new ZawodnicyRepository();
            Zawodnik[] zawodnicy = zr.PodajZawodnikow(); // najpierw z bazy pobralem WSZSTKICH zawodnikow 

            // jak wyszukac tylko polakow ?  // potem przeszukalem LOKLANIE ten caly zbior danych 
            Zawodnik[] wynik3 = zawodnicy.Where(x => x.Kraj == "POL").ToArray();

            Zawodnik[] wynik4 = zawodnicy.Where(x => x.Kraj == "POL" || x.Kraj == "GER").ToArray();

            Zawodnik[] wynik5 = zawodnicy.OrderBy(x => x.Kraj).ToArray();

            Zawodnik[] wynik6 = zawodnicy.OrderByDescending(x => x.Kraj).ThenBy(x => x.Wzrost).ToArray();

            Zawodnik[] wynik7 = zawodnicy.Where(x => x.Kraj == "POL").OrderBy(x => x.Wzrost).ToArray();

            string[] wynik8 = zawodnicy.Select(x => x.Imie).ToArray();

            int[] wynik9 = zawodnicy.Select(x => x.Wzrost).ToArray();


            string[] wynik10 = zawodnicy.Select(x => x.Imie + " " + x.Nazwisko).ToArray();

            int[] wynik11 = napisy.Select(x => x.Length).ToArray(); // 3 ,2 4

            int[] wynik12 = liczby.Select(x => x.GetHashCode()).ToArray();

            char[] wynik13 = liczby.Select(x => Convert.ToChar(x)).ToArray();

            //foreach (var e in wynik13)
            //    Console.WriteLine(e);


            var wynik14 = zawodnicy.Select(x => new { MojeImie = x.Imie, MojeNazwisko = x.Nazwisko }).ToArray();
            dynamic wynik15 = zawodnicy.Select(x => new { MojeImie = x.Imie, MojeNazwisko = x.Nazwisko }).ToArray();

            ZawodnikMini[] wynik16 = zawodnicy.Select(x => new ZawodnikMini() { Imie = x.Imie, Nazwisko = x.Nazwisko }).ToArray();

            dynamic a = 5;
            a = "ala";


            string[] wynik17 = zawodnicy.GroupBy(x => x.Kraj).Select(x => x.Key).ToArray();

            string[] wynik18 = zawodnicy.Select(x => x.Kraj).Distinct().ToArray();

            var wynik19= zawodnicy.GroupBy(x => x.Kraj).Select(x => new { Nazwa = x.Key, SredniWzrost = x.Average(y => y.Wzrost) }).ToArray();

            foreach (var e in wynik19)
                Console.WriteLine(e.Nazwa + " " + e.SredniWzrost);

            


            Console.ReadKey();

        }
    }
}
