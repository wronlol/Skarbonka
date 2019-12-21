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





            InitializeComponent();

            foreach (var item in DbContext.GetInstance().GetCollection<PrzychodKat>("przychod_kategorie").FindAll())
            {
                txtKategoria.AddItem(item.Name);
            }

            foreach (var item in DbContext.GetInstance().GetCollection<Konta>("konta").FindAll())
            {
                txtKategoria.AddItem(item.Name);
            }

            double ilosc = 0;
            ilosc = double.Parse(txtIlosc.Text.Trim());
            txtData.Value = date;

            PrzychodTransakcje przychodTransakcja = new PrzychodTransakcje()
            {
                Ilosc = ilosc,
                Data = txtData.Value,
                Opis = txtOpis.Text.Trim(),
                Od = txtOd.Text.Trim(),
                Kod = txtKod.Text.Trim()

            };

            DbContext.GetInstance().GetCollection<PrzychodTransakcje>("przychod_transakcje").Insert(przychodTransakcja);


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
