using P05AplikacjaZawodnicy.Core.Domains;
using P05AplikacjaZawodnicy.Core.Operations;
using P05AplikacjaZawodnicy.Core.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05AplikacjaZawodnicy
{
    public partial class FrmStartowy : Form
    {
        public FrmStartowy()
        {
            InitializeComponent();

            ZawodnicyRepository zr = new ZawodnicyRepository();

            string[] kraje = zr.PodajKraje();
            cbKraje.Items.Add("-- Wszystkie --");
            foreach (var k in kraje)
                cbKraje.Items.Add(k);

            Kolumna[] kolumny = new Kolumna[] 
            { 
                new Kolumna() { NazwaWidoczna="Id", KolumnaWBazie="id_zawodnika"},
                new Kolumna() { NazwaWidoczna="Imie", KolumnaWBazie="imie"},
                new Kolumna() { NazwaWidoczna="Nazwisko", KolumnaWBazie="nazwisko"},
                new Kolumna() { NazwaWidoczna="Kraj", KolumnaWBazie="kraj"},
            };
            cbSortowanie.DataSource = kolumny;
            cbSortowanie.DisplayMember = "NazwaWidoczna";

        }

        public void Odswiez()
        {
            ZawodnicyRepository zr = new ZawodnicyRepository();

            string wybranyKraj = cbKraje.SelectedIndex == 0 ? null : cbKraje.Text;


            int strona = Convert.ToInt32(txtStrona.Text);
            int ile = Convert.ToInt32(txtIleWyswietlac.Text);
            string kolumnaSorotwania = ((Kolumna)cbSortowanie.SelectedItem).KolumnaWBazie;

            Zawodnik[] zawodnicy = zr.PodajZawodnikowPoKraju(wybranyKraj,strona,ile, kolumnaSorotwania);

            //foreach (var z in zawodnicy)
            //    lvDane.Items.Add(z.Imie + " " + z.Nazwisko);

            ImageList listaObrazow = new ImageList();

            // var napisy = Directory.GetFiles("flagi", "pol.*").First();

            //foreach (var k   in zr.PodajKraje())
            //    if(File.Exists($@"flagi\{k.ToLower()}.jpg"))
            //        listaObrazow.Images.Add(k.ToLower(), Image.FromFile($@"flagi\{k.ToLower()}.jpg"));

            foreach (var k in zr.PodajKraje())
            {
                var p = Directory.GetFiles("flagi", $"{k}.*");
                if (p.Length > 0)
                    listaObrazow.Images.Add(k.ToLower(), Image.FromFile(p.First()));
            }
            // przerwa 13:10 

            lvDane.LargeImageList = listaObrazow;
            lvDane.Items.Clear();

            foreach (var z in zawodnicy)
                lvDane.Items.Add(new ListViewItem()
                {
                    Text = z.Imie + " " + z.Nazwisko,
                    Tag = z,
                    ImageKey = z.Kraj.ToLower()
                });
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            Odswiez();
            btnNowy.Enabled = true;
            btnSzczegoly.Enabled = true;
        }

        private void lvDane_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSzczegoly_Click(object sender, EventArgs e)
        {
            Zawodnik zaznaczony = (Zawodnik)lvDane.SelectedItems[0].Tag;

            FrmSzczegoly fs = new FrmSzczegoly(this, zaznaczony);
            fs.Show();
        }

        private void btnNowy_Click(object sender, EventArgs e)
        {
            FrmSzczegoly fs = new FrmSzczegoly(this);
            fs.Show();
        }

        private void lvDane_DoubleClick(object sender, EventArgs e)
        {
            Zawodnik zaznaczony = (Zawodnik)lvDane.SelectedItems[0].Tag;

            FrmSzczegoly fs = new FrmSzczegoly(this, zaznaczony);
            fs.Show();
        }

        private void btnRaport_Click(object sender, EventArgs e)
        {
            Zawodnik[] zawodnicy = new Zawodnik[lvDane.Items.Count];
            for (int i = 0; i < zawodnicy.Length; i++)
                zawodnicy[i] = (Zawodnik)lvDane.Items[i].Tag;

            GenerowanieRaportuOperation gro = new GenerowanieRaportuOperation();

            string filename = $"{DateTime.Now.ToString("yyyyMMddHHmmss")}_Raport.pdf";
            gro.GenerujRaport(zawodnicy, filename);
            
             string directory = AppDomain.CurrentDomain.BaseDirectory;
            wbRaport.Navigate(directory +filename);
        }

        private void btnPrawo_Click(object sender, EventArgs e)
        {
            txtStrona.Text = Convert.ToString(Convert.ToInt32(txtStrona.Text) + 1);
            Odswiez();
        }

        private void btnLewo_Click(object sender, EventArgs e)
        {
            txtStrona.Text = Convert.ToString(Convert.ToInt32(txtStrona.Text) - 1);
            Odswiez();
        }
    }
}
