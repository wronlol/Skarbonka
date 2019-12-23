using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiteDB;
using Skarbonka.Modele;
using System.IO;
namespace Skarbonka.Forms
{

    public partial class formdodajPrzychod : Form
    {
        string txtprzych = "przychod.txt";

        public formdodajPrzychod(DateTime date)
        {

            
            formMain f = new formMain();
            string curs = "";

            foreach (string line in File.ReadLines(@"current.txt"))
            {
                curs = line.ToString();
            }

            txtprzych = curs + "przychod.txt";

            InitializeComponent();




        }





        private void formdodajPrzychod_Load(object sender, EventArgs e)
        {

        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodajPrzychod_Click(object sender, EventArgs e)
        {
            File.AppendAllText(txtprzych, txtKod.Text + ";");
            File.AppendAllText(txtprzych, txtOd.Text + ";");
            File.AppendAllText(txtprzych, txtOpis.Text + ";");
            File.AppendAllText(txtprzych, txtKategoria.selectedValue.Trim() + ";");
            File.AppendAllText(txtprzych, txtKonto.selectedValue.Trim() + ";");
            File.AppendAllText(txtprzych, txtIlosc.Text + Environment.NewLine);
            
            this.Close();
            
            


        }



        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bunifuSeparator11_Load(object sender, EventArgs e)
        {

        }

        private void closeForm_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtOpis_OnValueChanged(object sender, EventArgs e)
        {
            txtIlosc.Text = "";
        }

        private void txtIlosc_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
