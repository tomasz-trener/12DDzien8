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

namespace P03AplikacjaOkienkowa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Button b = new Button();
            //b.Name = "btnNowy";
            //b.Text = "hej";
            //b.Left = 20;
            //b.Top = 100;
            ZawodnicyRepository zr = new ZawodnicyRepository();
            var zaw = zr.PodajZawodnikow();
            for (int i = 0; i < zaw.Length; i++)
            {
                Button b = new Button();
                b.Name = "btnZawodnik" + i;
                b.Text = zaw[i].Imie + " " + zaw[i].Nazwisko;
                b.Left = 20;
                b.Top = 70 + i*30;
                b.Width = 150;
                b.Tag = zaw[i];
                b.Click += btnPrzycisk_Click;
                this.Controls.Add(b);
            }
        }

        private void btnPrzycisk_Click(object sender, EventArgs e)
        {
            string napis= ((Button)sender).Text;
            Zawodnik z = (Zawodnik)((Button)sender).Tag;
         
            Zawodnik z2 = ((Button)sender).Tag as Zawodnik;
            Zawodnik z3= (sender as Button).Tag as Zawodnik;

            MessageBox.Show(z.Imie + " " + z.Nazwisko + " " + z.Kraj);
        }
    }
}
