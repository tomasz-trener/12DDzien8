using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02ZadanieDziedziczenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Plik[] pliki = new Plik[3];
            pliki[0] = new PlikCSV() { Tresc = "ala ma kota", Sciezka=@"c:\dane\pliki\p1" };
            pliki[1] = new PlikHTML() { Tresc = "ala ma kota", Sciezka = @"c:\dane\pliki\p2" };
            pliki[2] = new PlikSQL() { Tresc = "ala ma kota", Sciezka = @"c:\dane\pliki\p3" };

            foreach (var p in pliki)
                p.Zapisz();

           // ((PlikSQL)pliki[2]).Zapisz();

    //        Plik plik = new Plik();

            Plik p2 = new PlikHTML();
            p2.Zapisz();

            PlikHTML p3 = new PlikHTML();
            p3.Zapisz();

            ManagerPlikow mp = new ManagerPlikow();
            mp.SortujPliki(pliki);


           // PlikHTML p4 = new Plik();
        }
    }
}
