using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02ZadanieDziedziczenie
{
    internal class PlikCSV : Plik
    {
        public PlikCSV()
        {
            Rozszerzenie = ".csv";
        }
        public override void Zapisz()
        {
            Tresc = Tresc.Replace(" ", ";");
            base.Zapisz();
        }
    }
}
