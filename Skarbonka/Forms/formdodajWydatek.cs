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
    public partial class formdodajWydatek : Form
    {

        string txtwyd = "wydatek.txt";
        public formdodajWydatek()
        {
            InitializeComponent();
        }

        private void formdodajWydatek_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodajPrzychod_Click(object sender, EventArgs e)
        {
            File.AppendAllText(txtwyd, txtId1.Text + ";");
            File.AppendAllText(txtwyd, txtDla1.Text + ";");
            File.AppendAllText(txtwyd, txtOpis1.Text + ";");
            File.AppendAllText(txtwyd, txtKategoria1.selectedValue.Trim() + ";");
            File.AppendAllText(txtwyd, txtKonto1.selectedValue.Trim() + ";");
            File.AppendAllText(txtwyd, txtIlosc1.Text + Environment.NewLine);
            this.Close();
        }
    }
}
