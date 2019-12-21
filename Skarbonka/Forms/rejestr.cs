using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Skarbonka.Forms
{
    public partial class rejestr : Form
    {
        public rejestr()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

            if (txtHas11.Text == txtHas10.Text)
            {
                File.AppendAllText("login.txt", txtLog10.Text + ";");
                File.AppendAllText("login.txt", txtHas11.Text + Environment.NewLine);
                MessageBox.Show("Rejestracja zakończona sukcesem!", "Rejestracja",
                MessageBoxButtons.OK);

                this.Close();

            }
            else
            {
                MessageBox.Show("Hasła nie są takie same", "Rejestracja",
                MessageBoxButtons.OK);
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rejestr_Load(object sender, EventArgs e)
        {

        }

        private void txtLog10_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
