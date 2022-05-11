using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02ZadanieDziedziczenie
{
    internal class PlikSQL : Plik
    {
        public PlikSQL()
        {
            Rozszerzenie = ".sql";
        }

        public override void Zapisz()
        {
            Tresc = "SELECT " + Tresc + " FROM dane";
            base.Zapisz();
           
        }
    }
}
