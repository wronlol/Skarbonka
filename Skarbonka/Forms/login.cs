using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skarbonka.Forms
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnZaloguj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            
            new Helper.Popup.transparentBg(this, new Forms.rejestr());
            this.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtOpis1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtDla1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuSeparator11_Load(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
