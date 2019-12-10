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
            File.AppendAllText("wydatek.txt", txtId1.Text + ";");
            File.AppendAllText("wydatek.txt", txtDla1.Text + ";");
            File.AppendAllText("wydatek.txt", txtOpis1.Text + ";");
            File.AppendAllText("wydatek.txt", txtKategoria1.selectedValue.Trim() + ";");
            File.AppendAllText("wydatek.txt", txtKonto1.selectedValue.Trim() + ";");
            File.AppendAllText("wydatek.txt", txtIlosc1.Text + Environment.NewLine);
            this.Close();
        }
    }
}
