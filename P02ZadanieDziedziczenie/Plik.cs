using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02ZadanieDziedziczenie
{
    internal abstract class Plik 
    {
        public string Tresc;
        public int Rozmiar;
        public string Autor;
        public string Sciezka;
        public string Rozszerzenie;

        public virtual void Zapisz()
        {
            File.WriteAllText(Sciezka + Rozszerzenie, Tresc);
        }
    }
}
