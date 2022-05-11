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
    public partial class DateTimePickerNullable : UserControl
    {
        public DateTime? Value 
        { 
            get
            {
                if (txtData.Visible)
                    return null;
                else
                    return dtpData.Value;
            }
            set
            {
                if (value == null)
                {
                    txtData.Visible = true;
                    dtpData.Visible = false;
                }
                else
                {
                    txtData.Visible = false;
                    dtpData.Visible = true;
                    dtpData.Value = (DateTime)value;
                }
            }
        }
        public DateTimePickerNullable()
        {
            InitializeComponent();
        }

        private void txtData_Click(object sender, EventArgs e)
        {
            txtData.Visible = false;
            dtpData.Visible = true;

        }

        private void dtpData_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void dtpData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 46)
            {
                txtData.Visible = true;
                dtpData.Visible = false;
            }
        }
    }
}
