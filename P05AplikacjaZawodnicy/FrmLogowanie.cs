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
    public partial class FrmLogowanie : Form
    {
        public FrmLogowanie()
        {
            InitializeComponent();
        }

        private void btnZaloguj_Click(object sender, EventArgs e)
        {
            UzytkownicyRepository zr = new UzytkownicyRepository();
            var u=zr.Zaloguj(txtLogin.Text, txtHaslo.Text);

            if (u == null)
                MessageBox.Show("Niepoprawne dane logowania", "Logowanie niepoprawne", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else
            {
                var f = new FrmStartowy(u);
                f.Show();
                this.Hide();
            }
                
                
        }
    }
}
