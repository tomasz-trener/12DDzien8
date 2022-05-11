using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02ZadanieDziedziczenie
{
    internal class PlikHTML : Plik
    {
        public PlikHTML()
        {
            Rozszerzenie = ".html";
        }

        public override void Zapisz()
        {
            string szablon = "<HTML><BODY><P>{0}</P></BODY></HTML>";
            Tresc = string.Format(szablon, Tresc);
            base.Zapisz();
        }
    }
}
