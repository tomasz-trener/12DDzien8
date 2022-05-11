using P05AplikacjaZawodnicy.Core.Domains;
using P05AplikacjaZawodnicy.Core.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05AplikacjaZawodnicy
{
    enum TrybOkienka
    {
        Edycja,
        Nowy
    }

    public partial class FrmSzczegoly : Form
    {
        Zawodnik zawodnik;
        FrmStartowy fs;
        TrybOkienka trybOkienka;
        Uzytkownik zalogowany;

        public FrmSzczegoly(FrmStartowy fs, Uzytkownik zalogowany)
        {
            this.zalogowany = zalogowany;
            InitializeComponent();
            this.fs = fs;
            trybOkienka = TrybOkienka.Nowy;
        }

        public FrmSzczegoly(FrmStartowy fs, Zawodnik zawodnik, Uzytkownik zalogowany) : this(fs, zalogowany)
        {
            //this.fs = fs;
            this.zawodnik = zawodnik;

            txtImie.Text = zawodnik.Imie;
            txtNazwisko.Text = zawodnik.Nazwisko;
            txtKraj.Text = zawodnik.Kraj;

            // stara wersja gdy recznie zmienialismy widocznosc textboxa 
            //if(zawodnik.DataUrodzenia != null)
            //{
            //    //dtpDataUrodzenia.Value = (DateTime)zawodnik.DataUrodzenia;
            //    //txtDataUrodzenia.Visible = false;
            //}
            dtpDataUrodzenia.Value =zawodnik.DataUrodzenia ;

            txtWzrost.Text = Convert.ToString(zawodnik.Wzrost);
            txtWaga.Text = Convert.ToString(zawodnik.Waga);
            trybOkienka = TrybOkienka.Edycja;
            btnUsun.Visible = true;
        }



        private void btnZapisz_Click(object sender, EventArgs e)
        {
            if (trybOkienka == TrybOkienka.Nowy)
                zawodnik = new Zawodnik();

            // szczytywanie danych z rexboxow 
            zawodnik.Imie = txtImie.Text;
            zawodnik.Nazwisko = txtNazwisko.Text;
            zawodnik.Kraj = txtKraj.Text;
            //   if(!txtDataUrodzenia.Visible)
            //       zawodnik.DataUrodzenia = dtpDataUrodzenia.Value;

            zawodnik.DataUrodzenia = dtpDataUrodzenia.Value;
            zawodnik.Wzrost = Convert.ToInt32(txtWzrost.Text);
            zawodnik.Waga = Convert.ToInt32(txtWaga.Text);

            ZawodnicyRepository zr = new ZawodnicyRepository();

            if (trybOkienka == TrybOkienka.Nowy)
                zr.DodajZawodnika(zawodnik,zalogowany);
            else if (trybOkienka == TrybOkienka.Edycja)
                zr.EdytujZawodnika(zawodnik, zalogowany);
            else
                throw new Exception("Nieznany tryb");
          
            this.Close();
            fs.Odswiez();
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            if(trybOkienka== TrybOkienka.Edycja)
            {
                ZawodnicyRepository zr = new ZawodnicyRepository();
                zr.UsunZawodnika(zawodnik, zalogowany);
                this.Close();
                fs.Odswiez();
            }
        }
    }
}
