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
using Skarbonka.Forms;
using iTextSharp;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Text.RegularExpressions;
using Spire.Pdf;
using Spire.Pdf.Annotations;
using Spire.Pdf.Widget;
using System.Diagnostics;
using System.Configuration;
using System.Net.Mail;
using System.Xml;
using System.Xml.Linq;
using System.Net;
using System.Globalization;

namespace Skarbonka
{

    public partial class formMain : Form
    {
        string txtprzych = "przychod.txt";
        string txtwyd = "wydatek.txt";
        string txtlog = "login.txt";





        public formMain()
        {
            //files needed to start the program
            File.AppendAllText("current.txt", "");
            File.AppendAllText("login.txt", "");
            File.AppendAllText("waluta.txt", "");


            string curs = "";

            foreach (string line in File.ReadLines(@"current.txt"))
            {
                curs = line.ToString();
            }

            txtprzych = curs + "przychod.txt";
            txtwyd = curs + "wydatek.txt";

            File.AppendAllText(txtprzych, "");
            File.AppendAllText(txtwyd, "");
            File.AppendAllText(txtlog, "");
           new Helper.Popup.transparentBg(this, new Forms.login());

            InitializeComponent();

            ////////////////////////


            /////////////////////////

            ApplyGridTheme(gridPrzychody);
            ApplyGridTheme(gridWydatki);
            ApplyGridTheme(gridWydatki);

            bunifuDataViz1.colorSet.Add(col1.BackColor);
            bunifuDataViz1.colorSet.Add(col2.BackColor);
            bunifuDataViz1.colorSet.Add(col3.BackColor);

            podajDate.Value = DateTime.Now;
            comboBox1.SelectedIndex = 0;
            //recreating files for a specific user
            foreach (string line in File.ReadLines(@"current.txt"))
            {
                curs = line.ToString();
            }

            txtprzych = curs + "przychod.txt";
            txtwyd = curs + "wydatek.txt";







            File.AppendAllText(txtprzych, "");
            File.AppendAllText(txtwyd, "");
            File.AppendAllText(txtlog, "");
            string wal1 = "";
            foreach (string line in File.ReadLines(@"waluta.txt"))
            {
                wal1 = line.ToString();
            }

            lblWaluta.Text = "[" + wal1 + "]";
            lblWaluta2.Text = "[" + wal1 + "]";
            comboBox1.Text = wal1;
            exchangerates();
            lista();
            lista2();
          //  pusty();


        }
        string euro = "";
        string gbp = "";
        string usd = "";



        public void pusty()
        {
            System.Threading.Thread.Sleep(1000);
            if (new FileInfo(txtprzych).Length == 0)
            {
                MessageBox.Show("Brak wpisów o przychodach, proszę uzłupełnić dane", "Info");
            }

   



            if (new FileInfo(txtwyd).Length == 0)
            {
                MessageBox.Show("Brak wpisów o wydatkach, proszę uzłupełnić dane", "Info");
            }
            webBrowser2.Navigate("http://free.timeanddate.com/clock/i79kkv8q/n1460/szw110/szh110/hbw0/hfc000/cf100/hgr0/fav0/fiv0/mqcfff/mql15/mqw4/mqd94/mhcfff/mhl15/mhw4/mhd94/mmv0/hhcbbb/hmcddd/hsceee/");
        }


        public void exchangerates()
        {
            WebClient client = new WebClient();
            string dnlad = client.DownloadString("http://api.nbp.pl/api/exchangerates/tables/A/");
            File.WriteAllText(@"waluty.txt", dnlad);
            string str1 = File.ReadAllText(@"waluty.txt");
            str1 = str1.Replace("{", "\n");
            File.WriteAllText("waluty.txt", str1);

            foreach (string line in File.ReadLines(@"waluty.txt"))
            {
                if (line.Contains("EUR"))
                {
                    euro = line.Split(':').Last();
                    euro = euro.Remove(euro.Length - 2);
                    lblEuro.Text = euro;
                }

                if (line.Contains("GBP"))
                {
                    gbp = line.Split(':').Last();
                    gbp = gbp.Remove(gbp.Length - 2);
                    lblGBP.Text = gbp;
                }

                if (line.Contains("USD"))
                {
                    usd = line.Split(':').Last();
                    usd = usd.Remove(usd.Length - 2);
                    lblUSD.Text = usd;
                }

            }



        }
        public void klik()
        {
            //wczytanie danych

            string[] lines1 = File.ReadAllLines(txtwyd);
            string[] values1;

            for (int i = 0; i < lines1.Length; i++)
            {
                values1 = lines1[i].ToString().Split(';');
                string[] row = new string[values1.Length];

                for (int j = 0; j < values1.Length; j++)
                {
                    row[j] = values1[j].Trim();
                }
                gridWydatki.Rows.Add(row);
            }






        }

        private void buttonImport_Click_1(object sender, EventArgs e)
        {
            //wczytanie danych

            gridPrzychody.Rows.Clear();
            string[] lines = File.ReadAllLines(@txtprzych);
            string[] values;

            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split(';');
                string[] row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                gridPrzychody.Rows.Add(row);
            }
            ReverseDGVRows(gridPrzychody);
        }





        private void buttonImport2_Click(object sender, EventArgs e)
        {
            //wczytanie danych
            gridWydatki.Rows.Clear();
            string[] lines = File.ReadAllLines(@txtwyd);
            string[] values;
            
            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split(';');
                string[] row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                gridWydatki.Rows.Add(row);
            }
            ReverseDGVRows(gridWydatki);
        }



        void ApplyGridTheme(Bunifu.UI.WinForms.BunifuDataGridView grid)
        {
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.DimGray;

            grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.DimGray;
        }

        void MoveIndicator(Control btn)
        {
            //wskaznik ktora strona
            wskaznik.Left = btn.Left;
            wskaznik.Width = btn.Width;
        }

        private void formMain_Load(object sender, EventArgs e)
        {

        }

        private void formMain_Resize(object sender, EventArgs e)
        {
            //if the form is minimized  
            //hide it from the task bar  
            //and show the system tray icon (represented by the NotifyIcon control)  
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
        }





        private void panelTytul_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void przUstawienia_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            Strony.SetPage("Ustawienia");

        }

        private void przRaporty_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            Strony.SetPage("Raporty");
        }


        private void przWydatki_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            Strony.SetPage("Wydatki");


        }

        private void przPrzychody_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            Strony.SetPage("Przychody");


        }

        private void przDashboard_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            Strony.SetPage("Dashboard");
        }

        void RenderMonthChart()
        {

            //glowny wykres
            Bunifu.DataViz.WinForms.Canvas canvas = new Bunifu.DataViz.WinForms.Canvas();

            Bunifu.DataViz.WinForms.DataPoint przychod = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_spline);
            Bunifu.DataViz.WinForms.DataPoint wydatki = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_spline);
            //Bunifu.DataViz.WinForms.DataPoint balans = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_spline);



            

            foreach (string line in File.ReadLines(@txtprzych))
            {
                string lastWord = line.Split(';').Last();
                int ix = System.Convert.ToInt32(lastWord);
                przychod.addLabely("", ix);
            }

            foreach (string line in File.ReadLines(@txtwyd))
            {
                string lastWord = line.Split(';').Last();
                int ix = System.Convert.ToInt32(lastWord);
                wydatki.addLabely("", ix);
            }

            canvas.addData(przychod);
            canvas.addData(wydatki);
          //  canvas.addData(balans);

                bunifuDataViz1.Render(canvas);
           
        }

        void RenderPrzychodChart()
        {
            Bunifu.DataViz.WinForms.Canvas canvas = new Bunifu.DataViz.WinForms.Canvas();

            Bunifu.DataViz.WinForms.DataPoint outlook = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_pie);

            //wykres kolowy przychody
            Double przelewx = 0;
            Double wyplatax = 0;


            foreach (string line in File.ReadLines(@txtprzych))
            {

                if (line.Contains("Wypłata"))
                {
                    string lastWord = line.Split(';').Last();
                    int ix = System.Convert.ToInt32(lastWord);
                    wyplatax += ix;
                }

                if (line.Contains("Przelew"))
                {
                    string lastWord = line.Split(';').Last();
                    int ixc = System.Convert.ToInt32(lastWord);
                    przelewx += ixc;
                }

            }



            outlook.addLabely("Wypłata", wyplatax);
            outlook.addLabely("Przelew", przelewx);

            canvas.addData(outlook);

            bunifuDataViz3.Render(canvas);

        }

        void RenderWydatkiChart()
        {
            //wykres kolowy wydatki
            Bunifu.DataViz.WinForms.Canvas canvas = new Bunifu.DataViz.WinForms.Canvas();

            Bunifu.DataViz.WinForms.DataPoint outlook = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_pie);


            Double zakupyx = 0;
            Double czynszx = 0;
            Double oplatyx = 0;



            foreach (string line in File.ReadLines(@txtwyd))
            {

                if (line.Contains("Zakupy"))
                {
                    string lastWord = line.Split(';').Last();
                    int ix = System.Convert.ToInt32(lastWord);
                    zakupyx += ix;
                }

                if (line.Contains("Czynsz"))
                {
                    string lastWord = line.Split(';').Last();
                    int ixc = System.Convert.ToInt32(lastWord);
                    czynszx += ixc;
                }

                if (line.Contains("Opłaty"))
                {
                    string lastWord = line.Split(';').Last();
                    int ixc = System.Convert.ToInt32(lastWord);
                    oplatyx += ixc;
                }


            }



            outlook.addLabely("Zakupy", zakupyx);
            outlook.addLabely("Czynsz", czynszx);
            outlook.addLabely("Opłaty", oplatyx);



            canvas.addData(outlook);

            bunifuDataViz2.Render(canvas);

        }






        private void Timer1_Tick(object sender, EventArgs e)
        {

            

            czas.Text = DateTime.Now.ToString("HH:mm", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            timer1.Interval = 2000;

            RenderMonthChart();
            RenderPrzychodChart();
            RenderWydatkiChart();
            File.WriteAllText("waluta.txt", comboBox1.Text);

            Point scrollPoint = new Point(150, 155);

            if (webBrowser1.Document != null)
            {
                webBrowser1.Document.Window.ScrollTo(scrollPoint);
            }
        }
    

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void bunifuSeparator3_Load(object sender, EventArgs e)
        {

        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

    

    private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Click(object sender, EventArgs e)
        {

        }

        private void btnDodajPrzychod_Click(object sender, EventArgs e)
        {
            //wlacz formularz dodawania przychodow

            new Helper.Popup.transparentBg(this, new Forms.formdodajPrzychod(podajDate.Value));

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            //wlacz formularz dodawania wydatkow
            new Helper.Popup.transparentBg(this, new Forms.formdodajWydatek());
        }

        private void gridWydatki_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        void ReverseDGVRows(DataGridView gridPrzychody)
        {
            //odwracanie tabeli
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            rows.AddRange(gridPrzychody.Rows.Cast<DataGridViewRow>());
            rows.Reverse();
            gridPrzychody.Rows.Clear();
            gridPrzychody.Rows.AddRange(rows.ToArray());
        }

        int pusto = 0;

        private void Timer2_Tick(object sender, EventArgs e)
        {
            //timer sumy
            timer2.Interval = 10000;
            //buttonImport.PerformClick();
            //buttonImport2.PerformClick();
            //button12x.PerformClick();
            

            double sum = 0;
            for (int i = 0; i < gridPrzychody.Rows.Count; ++i)
            {
                double d = 0;
                Double.TryParse(gridPrzychody.Rows[i].Cells[5].Value.ToString(), out d);
                sum += d;
            }

            lblTotoIncome.Text = sum.ToString();

            double sum1 = 0;
            for (int li = 0; li < gridWydatki.Rows.Count; ++li)
            {
                double d = 0;
                Double.TryParse(gridWydatki.Rows[li].Cells[5].Value.ToString(), out d);
                sum1 += d;
            }

            label22.Text = sum1.ToString();
            label3.Text = sum.ToString();
            label4.Text = sum1.ToString();
            label6.Text = (sum - sum1).ToString();


            if (pusto == 0)
            {
                pusty();
                pusto++;
            }




        }

        private void button69_Click(object sender, EventArgs e)
        {
            //wprowadzanie danych do dgv
            gridPrzychody.Rows.Clear();
            string[] lines = File.ReadAllLines(@txtprzych);
            string[] values;


            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split(';');
                string[] row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                gridPrzychody.Rows.Add(row);
            }
            ReverseDGVRows(gridPrzychody);

        }

        private void lblTotoIncome_Click(object sender, EventArgs e)
        {
            
        }

        private void button12x_Click(object sender, EventArgs e)
        {
            //wprowadzanie danych do dgv
            gridPrzychody.Rows.Clear();
            string[] lines = File.ReadAllLines(@txtprzych);
            string[] values;


            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split(';');
                string[] row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                gridPrzychody.Rows.Add(row);
            }


        }


        public static void DeleteLastLine(string filepath)
        {
            //usun ostatni wpis - metoda

            List<string> lines = File.ReadAllLines(filepath).ToList();

            File.WriteAllLines(filepath, lines.GetRange(0, lines.Count - 1).ToArray());

        }


        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            //usun ostatni wpis
            DeleteLastLine(txtwyd);
        }

        private void buttonUsun_Click(object sender, EventArgs e)
        {
            //usun ostatni wpis

            DeleteLastLine(txtprzych);
        }

        private void bunifuDataViz3_Load(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            //powitanie zalogowanego uzytkownika
            foreach (string line in File.ReadLines(@"current.txt"))
            {
                lblWitaj.Text = "Witaj, " +  line.ToString() + "!";
            }

            button69.PerformClick();
            klik();

            timer3.Enabled = false;


        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void podajDate_onValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuDataViz2_Load(object sender, EventArgs e)
        {
           
        }

        private string pathP = string.Empty;
        private bool markerP = false;
        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {

            //tworzenie raportu przychodow
            if (gridPrzychody.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf"; 
                sfd.FileName = "Przychody.pdf";



                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Nie można było zapisać na dysku." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {

                            PdfPTable pdfTable = new PdfPTable(gridPrzychody.Columns.Count);
                            pdfTable.DefaultCell.Padding = 10;
                            pdfTable.DefaultCell.PaddingBottom = 9;
                            pdfTable.WidthPercentage = 85;
                            pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;


                            foreach (DataGridViewColumn column in gridPrzychody.Columns)
                            {
                                BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1257, BaseFont.EMBEDDED);
                                iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 16);
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, font));
                                cell.BackgroundColor = new iTextSharp.text.BaseColor(210, 180, 140);

                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in gridPrzychody.Rows)
                            {
                                BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1257, BaseFont.EMBEDDED);
                                iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 13);

                                foreach (DataGridViewCell cell in row.Cells)
                                {

                                    PdfPCell acell = new PdfPCell(new Phrase(cell.Value.ToString(), font));
                                    acell.BackgroundColor = new iTextSharp.text.BaseColor(245, 245, 220);
;

                                    pdfTable.AddCell(acell);
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, System.IO.FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfTable.DefaultCell.BackgroundColor = BaseColor.RED;

                                pdfDoc.AddTitle("Raport przychodów programu Skarbonka");
                                var textfont = FontFactory.GetFont("Arial", 20);
                                var descriptionChunk = new Chunk("                                      Raport Przychodów", textfont);
                                pdfDoc.Add(new Paragraph("\n"));
                                pdfDoc.Add(new Paragraph("\n"));

                                pathP = sfd.ToString();
                                pathP = pathP.Split(' ').Last();
                                label24.Text = pathP;
                                pdfDoc.Add(descriptionChunk);

                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                                markerP = true;
                            }
                            System.Diagnostics.Process.Start(sfd.FileName);
                            MessageBox.Show("Raport został wygenerowany!", "Info");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Błąd :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Brak danych do wygenerowania raportu!", "Info");
            }

        }
        private string pathW = string.Empty;
        private bool markerW = false;
        private void bunifuTileButton6_Click(object sender, EventArgs e)
        {
            if (gridWydatki.Rows.Count > 0)
            {

                //tworzenie raportu wydatkow
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Wydatki.pdf";
                


                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Nie można było zapisać na dysku." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(gridWydatki.Columns.Count);
                            pdfTable.DefaultCell.Padding = 10;
                            pdfTable.WidthPercentage = 85;
                            pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;

                            foreach (DataGridViewColumn column in gridPrzychody.Columns)
                            {
                                BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1257, BaseFont.EMBEDDED);
                                iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 16);
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, font));
                                cell.BackgroundColor = new iTextSharp.text.BaseColor(210, 180, 140);

                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in gridWydatki.Rows)
                            {
                                BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1257, BaseFont.EMBEDDED);
                                iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 13);

                                foreach (DataGridViewCell cell in row.Cells)
                                {

                                    PdfPCell acell = new PdfPCell(new Phrase(cell.Value.ToString(), font));
                                    acell.BackgroundColor = new iTextSharp.text.BaseColor(245, 245, 220);

                                    pdfTable.AddCell(acell);
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, System.IO.FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);

                                
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                var textfont = FontFactory.GetFont("Arial", 20);
                                var descriptionChunk = new Chunk("                                      Raport Wydatków", textfont);
                                pdfDoc.Add(new Paragraph("\n"));
                                pdfDoc.Add(new Paragraph("\n"));

                                pathW = sfd.ToString();
                                pathW = pathW.Split(' ').Last();
                                label25.Text = pathW;

                                pdfDoc.Add(descriptionChunk);
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                                markerW = true;
                            }
                            MessageBox.Show("Raport został wygenerowany!", "Info");
                            System.Diagnostics.Process.Start(sfd.FileName);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Błąd :" + ex.Message);
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Brak danych do wygenerowania raportu!", "Info");
            }

        }
        private string pathO = string.Empty;
        private void MergePDF(string File1, string File2)
        {
            //raport ogolny - laczenie dwoch raportow
            string[] fileArray = new string[3];
            fileArray[0] = File1;
            fileArray[1] = File2;

            PdfReader reader = null;
            Document sourceDocument = null;
            PdfCopy pdfCopyProvider = null;
            PdfImportedPage importedPage;


            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF (*.pdf)|*.pdf";
            sfd.FileName = "Ogólny.pdf";

            string outputPdfPath = sfd.FileName;
            bool fileError = false;
            pathO = sfd.ToString();
            pathO = pathO.Split(' ').Last();
            label26.Text = pathO;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(sfd.FileName))
                {
                    try
                    {
                        File.Delete(sfd.FileName);
                    }
                    catch (IOException ex)
                    {
                        fileError = true;
                        MessageBox.Show("Nie można było zapisać na dysku." + ex.Message);
                    }
                }

                if (!fileError)
                {
                    try
                    {


                        sourceDocument = new Document();
                        pdfCopyProvider = new PdfCopy(sourceDocument, new System.IO.FileStream(sfd.FileName, System.IO.FileMode.Create));

                        //output file Open  
                        sourceDocument.Open();


                        //files list wise Loop  
                        for (int f = 0; f < fileArray.Length - 1; f++)
                        {
                            int pages = TotalPageCount(fileArray[f]);

                            reader = new PdfReader(fileArray[f]);
                            //Add pages in new file  
                            for (int i = 1; i <= pages; i++)
                            {
                                importedPage = pdfCopyProvider.GetImportedPage(reader, i);
                                pdfCopyProvider.AddPage(importedPage);
                            }

                            reader.Close();

                        }
                        //save the output file  
                        sourceDocument.Close();
                        System.Diagnostics.Process.Start(sfd.FileName);
                        MessageBox.Show("Raport ogólny został stworzony!", "Info");

                    }
                    catch (Exception ex)
                    {
                        fileError = true;
                        MessageBox.Show("Nie można było zapisać na dysku." + ex.Message);
                    }
                }
            }
        }

        private static int TotalPageCount(string file)
        {
            using (StreamReader sr = new StreamReader(System.IO.File.OpenRead(file)))
            {
                Regex regex = new Regex(@"/Type\s*/Page[^s]");
                MatchCollection matches = regex.Matches(sr.ReadToEnd());

                return matches.Count;
            }
        }



        private void bunifuTileButton9_Click(object sender, EventArgs e)
        {
            
            //raport ogolny przez zlaczenie raportow wydatkow i przychodow
            string x = pathP;
            string z = pathW;
            if (markerP = true && markerW == true)
            {
                MergePDF(x, z);
            }
            else
            {
                MessageBox.Show("Najpierw stwórz aktualne raporty wydatków i przychodów!", "Info");
            }

        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            //potwierdzenie 

            bool pot = false;
            var confirmResult = MessageBox.Show("Czy chcesz wydrukować raport przychodów?",
                                     "Potwierdź drukowanie",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                pot = true;
            }
            else
            {
                pot = false;
                MessageBox.Show("Drukowanie przerwane", "Info");
            }

            //drukowanie po zatwierdzeniu 

            if (pot == true) if (pathP != null)
            {
                Spire.Pdf.PdfDocument doc = new Spire.Pdf.PdfDocument();
                doc.LoadFromFile(pathP);
                doc.PrintDocument.Print();
            }
            else
                MessageBox.Show("Najpierw stwórz raport!", "Info");

        }

        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {
            //potwierdzenie 
            bool pot = false;
            var confirmResult = MessageBox.Show("Czy chcesz wydrukować raport wydatków?",
                                     "Potwierdź drukowanie",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                pot = true;
            }
            else
            {
                pot = false;
                MessageBox.Show("Drukowanie przerwane", "Info");
            }

            //drukowanie po zatwierdzeniu 

            if (pot == true) if (pathW != null)
            {
                Spire.Pdf.PdfDocument doc = new Spire.Pdf.PdfDocument();
                doc.LoadFromFile(pathW);
                doc.PrintDocument.Print();
            }
            else
                MessageBox.Show("Najpierw stwórz raport!", "Info");
        }

        private void bunifuTileButton8_Click(object sender, EventArgs e)
        {

            //raport ogolny - potwierdzenie
            bool pot = false;
            var confirmResult = MessageBox.Show("Czy chcesz wydrukować raport ogólny?",
                                     "Potwierdź drukowanie",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                pot = true;
            }
            else
            {
                pot = false;
                MessageBox.Show("Drukowanie przerwane", "Info");
            }

            //drukowanie po zatwierdzeniu 
            if (pot == true)
            {
                if (pathO != null)
                {
                    Spire.Pdf.PdfDocument doc = new Spire.Pdf.PdfDocument();
                    doc.LoadFromFile(pathO);
                    doc.PrintDocument.Print();
                }
                else
                    MessageBox.Show("Najpierw stwórz raport!", "Info");
            }
        }



        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            //wylogowanie - zamknij i otworz znowu aplikacje
            System.Windows.Forms.Application.Exit();
            var p = new Process();
            p.StartInfo.FileName = "Skarbonka.exe";  
            p.Start();


        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            string curs = "";

            foreach (string line in File.ReadLines(@"current.txt"))
            {
                curs = line.ToString();
            }

            string txtprzych = curs + "przychod.txt";
            string txtwyd = curs + "wydatek.txt";


            //reset konta potwierdzenie
            bool pot = false;
            var confirmResult = MessageBox.Show("Czy na pewno chcesz zresetować swoje konto?",
                                     "Reset",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                pot = true;
            }
            else
            {
                pot = false;
                MessageBox.Show("Resetowanie zakończone niepowodzeniem", "Info");
            }

            //reset konta 
            if (pot == true)
            {
                File.WriteAllText(txtprzych, "");
                File.WriteAllText(txtwyd, "");
            }

        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            //todo check if the report has been created before prompting
            string input = Microsoft.VisualBasic.Interaction.InputBox("Podaj adres e-mail",
                       "Adres",
                       "");
            if (input != null)
            {
                MailMessage theMailMessage = new MailMessage("sprawdziantei@wp.pl", input);
                theMailMessage.Body = "Raport przychodów z programu Skarbonka";
                theMailMessage.Attachments.Add(new Attachment(label24.Text));
                theMailMessage.Subject = "Raport przychodów";

                SmtpClient theClient = new SmtpClient("smtp.wp.pl");
                theClient.UseDefaultCredentials = false;
                System.Net.NetworkCredential theCredential = new System.Net.NetworkCredential("sprawdziantei@wp.pl", "pszemo123");
                theClient.Credentials = theCredential;
                theClient.Send(theMailMessage);
                MessageBox.Show("Raport został wysłany!", "Info");

            }
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Podaj adres e-mail",
           "Adres",
           "");
            if (input != null)
            { 

            MailMessage theMailMessage = new MailMessage("sprawdziantei@wp.pl", input);
            theMailMessage.Body = "Raport wydatków z programu Skarbonka";
            theMailMessage.Attachments.Add(new Attachment(label25.Text));
            theMailMessage.Subject = "Raport wydatków";

            SmtpClient theClient = new SmtpClient("smtp.wp.pl");
            theClient.UseDefaultCredentials = false;
            System.Net.NetworkCredential theCredential = new System.Net.NetworkCredential("sprawdziantei@wp.pl", "pszemo123");
            theClient.Credentials = theCredential;
            theClient.Send(theMailMessage);
                MessageBox.Show("Raport został wysłany!", "Info");

            }
        }

        private void bunifuTileButton7_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Podaj adres e-mail",
           "Adres",
           "");
            if (input != null)
            {
                MailMessage theMailMessage = new MailMessage("sprawdziantei@wp.pl", input);
                theMailMessage.Body = "Raport ogólny z programu Skarbonka";
                theMailMessage.Attachments.Add(new Attachment(label26.Text));
                theMailMessage.Subject = "Raport ogólny";

                SmtpClient theClient = new SmtpClient("smtp.wp.pl");
                theClient.UseDefaultCredentials = false;
                System.Net.NetworkCredential theCredential = new System.Net.NetworkCredential("sprawdziantei@wp.pl", "pszemo123");
                theClient.Credentials = theCredential;
                theClient.Send(theMailMessage);
                MessageBox.Show("Raport został wysłany!", "Info");

            }
        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdprzychody = new OpenFileDialog();
            string filePath = "";
            if (fdprzychody.ShowDialog() == DialogResult.OK)
            {   
                
                //Get the path of specified file
                filePath = fdprzychody.FileName;

            }

            File.AppendAllText(txtprzych, File.ReadAllText(filePath));

        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdwydatki = new OpenFileDialog();
            string filePath = "";
            if (fdwydatki.ShowDialog() == DialogResult.OK)
            {

                //Get the path of specified file
                filePath = fdwydatki.FileName;

            }

            File.AppendAllText(txtwyd, File.ReadAllText(filePath));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //waluta brana z txtboxa w ustawieniach do labela w datagridview


           lblWaluta.Text = "[" + comboBox1.Text + "]";
           lblWaluta2.Text = "[" + comboBox1.Text + "]";
                       
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            Strony.SetPage("Waluty");
        }

        private void button1_Click(object sender, EventArgs e)
        {
           string from, to;
           from = listBox1.SelectedItem.ToString();
           to = listBox2.SelectedItem.ToString();
           webBrowser1.Navigate("https://www.google.com/search?q=" + textBox1.Text + " " + from + " in " + to + "&oq=" + textBox1.Text + from + "in" + to);
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            Dashboard.BackColor = Color.FromArgb(27, 38, 44);
            tabPage1.BackColor = Color.FromArgb(27, 38, 44);
            tabPage2.BackColor = Color.FromArgb(27, 38, 44);
            tabPage3.BackColor = Color.FromArgb(27, 38, 44);
            tabPage4.BackColor = Color.FromArgb(27, 38, 44);
            tabPage5.BackColor = Color.FromArgb(27, 38, 44);
            tabPage6.BackColor = Color.FromArgb(27, 38, 44);
            panelNaglowek.BackColor = Color.FromArgb(27, 38, 44);
            panelTytul.BackColor = Color.FromArgb(27, 38, 44);
            bunifuDataViz1.BackColor = Color.FromArgb(27, 38, 44);
            bunifuDataViz2.BackColor = Color.FromArgb(27, 38, 44);
            bunifuDataViz3.BackColor = Color.FromArgb(27, 38, 44);
            bunifuDropdown2.BackColor = Color.FromArgb(27, 38, 44);
            bunifuDropdown3.BackColor = Color.FromArgb(27, 38, 44);
            bunifuDropdown4.BackColor = Color.FromArgb(27, 38, 44);
            bunifuDropdown5.BackColor = Color.FromArgb(27, 38, 44);
            label1.BackColor = Color.FromArgb(27, 38, 44);
            label10.BackColor = Color.FromArgb(27, 38, 44);
            label11.BackColor = Color.FromArgb(27, 38, 44);
            label12.BackColor = Color.FromArgb(27, 38, 44);
            label13.BackColor = Color.FromArgb(27, 38, 44);
            label14.BackColor = Color.FromArgb(27, 38, 44);
            label15.BackColor = Color.FromArgb(27, 38, 44);
            label16.BackColor = Color.FromArgb(27, 38, 44);
            label17.BackColor = Color.FromArgb(27, 38, 44);
            label18.BackColor = Color.FromArgb(27, 38, 44);
            label19.BackColor = Color.FromArgb(27, 38, 44);
            label2.BackColor = Color.FromArgb(27, 38, 44);
            label20.BackColor = Color.FromArgb(27, 38, 44);
            label21.BackColor = Color.FromArgb(27, 38, 44);
            label22.BackColor = Color.FromArgb(27, 38, 44);
            label23.BackColor = Color.FromArgb(27, 38, 44);
            label24.BackColor = Color.FromArgb(27, 38, 44);
            label25.BackColor = Color.FromArgb(27, 38, 44);
            label26.BackColor = Color.FromArgb(27, 38, 44);
            label27.BackColor = Color.FromArgb(27, 38, 44);
            label28.BackColor = Color.FromArgb(27, 38, 44);
            label29.BackColor = Color.FromArgb(27, 38, 44);
            label3.BackColor = Color.FromArgb(27, 38, 44);
            label31.BackColor = Color.FromArgb(27, 38, 44);
            label30.BackColor = Color.FromArgb(27, 38, 44);
            label32.BackColor = Color.FromArgb(27, 38, 44);
            label33.BackColor = Color.FromArgb(27, 38, 44);
            label34.BackColor = Color.FromArgb(27, 38, 44);
            label35.BackColor = Color.FromArgb(27, 38, 44);
            label36.BackColor = Color.FromArgb(27, 38, 44);
            label38.BackColor = Color.FromArgb(27, 38, 44);
            label4.BackColor = Color.FromArgb(27, 38, 44);
            label5.BackColor = Color.FromArgb(27, 38, 44);
            label6.BackColor = Color.FromArgb(27, 38, 44);
            label7.BackColor = Color.FromArgb(27, 38, 44);
            label8.BackColor = Color.FromArgb(27, 38, 44);
            label9.BackColor = Color.FromArgb(27, 38, 44);
            label39.BackColor = Color.FromArgb(27, 38, 44);
            label37.BackColor = Color.FromArgb(27, 38, 44);
            lblEuro.BackColor = Color.FromArgb(27, 38, 44);
            lblGBP.BackColor = Color.FromArgb(27, 38, 44);
            lblTotoIncome.BackColor = Color.FromArgb(27, 38, 44);
            lblUSD.BackColor = Color.FromArgb(27, 38, 44);
            lblWaluta.BackColor = Color.FromArgb(27, 38, 44);
            lblWaluta2.BackColor = Color.FromArgb(27, 38, 44);
            lblWitaj.BackColor = Color.FromArgb(27, 38, 44);
            bunifuFlatButton7.BackColor = Color.FromArgb(27, 38, 44);
            bunifuFlatButton7.OnHovercolor = Color.FromArgb(27, 38, 44);
            bunifuFlatButton7.Normalcolor = Color.FromArgb(27, 38, 44);
            bunifuFlatButton9.BackColor = Color.FromArgb(27, 38, 44);
            bunifuFlatButton9.OnHovercolor = Color.FromArgb(27, 38, 44);
            bunifuFlatButton9.Normalcolor = Color.FromArgb(27, 38, 44);
            przDashboard.BackColor = Color.FromArgb(27, 38, 44);
            przDashboard.OnHovercolor = Color.FromArgb(27, 38, 44);
            przDashboard.Normalcolor = Color.FromArgb(27, 38, 44);
            przPrzychody.BackColor = Color.FromArgb(27, 38, 44);
            przPrzychody.OnHovercolor = Color.FromArgb(27, 38, 44);
            przPrzychody.Normalcolor = Color.FromArgb(27, 38, 44);
            przRaporty.BackColor = Color.FromArgb(27, 38, 44);
            przRaporty.OnHovercolor = Color.FromArgb(27, 38, 44);
            przRaporty.Normalcolor = Color.FromArgb(27, 38, 44);
            przUstawienia.BackColor = Color.FromArgb(27, 38, 44);
            przUstawienia.OnHovercolor = Color.FromArgb(27, 38, 44);
            przUstawienia.Normalcolor = Color.FromArgb(27, 38, 44);
            przWydatki.BackColor = Color.FromArgb(27, 38, 44);
            przWydatki.OnHovercolor = Color.FromArgb(27, 38, 44);
            przWydatki.Normalcolor = Color.FromArgb(27, 38, 44);
            panel2.BackColor = Color.FromArgb(27, 38, 44);
            bunifuTileButton1.BackColor = Color.FromArgb(27, 38, 44);
            bunifuTileButton2.BackColor = Color.FromArgb(27, 38, 44);
            bunifuTileButton3.BackColor = Color.FromArgb(27, 38, 44);
            bunifuTileButton4.BackColor = Color.FromArgb(27, 38, 44);
            bunifuTileButton5.BackColor = Color.FromArgb(27, 38, 44);
            bunifuTileButton6.BackColor = Color.FromArgb(27, 38, 44);
            bunifuTileButton7.BackColor = Color.FromArgb(27, 38, 44);
            bunifuTileButton8.BackColor = Color.FromArgb(27, 38, 44);
            bunifuTileButton9.BackColor = Color.FromArgb(27, 38, 44);
            gridPrzychody.BackgroundColor = Color.FromArgb(27, 38, 44);
            gridWydatki.BackgroundColor = Color.FromArgb(27, 38, 44);
            bunifuTileButton1.color = Color.FromArgb(27, 38, 44);
            bunifuTileButton2.color = Color.FromArgb(27, 38, 44);
            bunifuTileButton3.color = Color.FromArgb(27, 38, 44);
            bunifuTileButton4.color = Color.FromArgb(27, 38, 44);
            bunifuTileButton5.color = Color.FromArgb(27, 38, 44);
            bunifuTileButton6.color = Color.FromArgb(27, 38, 44);
            bunifuTileButton7.color = Color.FromArgb(27, 38, 44);
            bunifuTileButton8.color = Color.FromArgb(27, 38, 44);
            bunifuTileButton9.color = Color.FromArgb(27, 38, 44);
            listView1.BackColor = Color.FromArgb(27, 38, 44);
            listView2.BackColor = Color.FromArgb(27, 38, 44);

        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton9_Click_1(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            Strony.SetPage("Konta");
        }
        int sum32;

        void lista()
        {
            int ix;
            listView1.View = View.List;
            String cura = System.Environment.CurrentDirectory;
            DirectoryInfo d = new DirectoryInfo(cura);//Assuming Test is your Folder
            FileInfo[] Files = d.GetFiles("*przychod.txt"); //Getting Text files
            string str = "";
            foreach (FileInfo file in Files)
            {
                str = str + "" + file.Name;

                foreach (string line in File.ReadLines(str))
                {
                string lastWord = line.Split(';').Last();
                ix = System.Convert.ToInt32(lastWord);
                    sum32 += ix;
                }


                str = str.Replace("przychod.txt", "");
                str = str + "                   " + sum32;
                ix = 0;
                sum32 = 0;
                //sum32 = 0;
                listView1.Items.Add(str);
                str = "";
                }
        }

        void lista2()
        {
            int ix;
            listView2.View = View.List;
            String cura = System.Environment.CurrentDirectory;
            DirectoryInfo d = new DirectoryInfo(cura);//Assuming Test is your Folder
            FileInfo[] Files = d.GetFiles("*wydatek.txt"); //Getting Text files
            string str = "";
            foreach (FileInfo file in Files)
            {
                str = str + "" + file.Name;

                foreach (string line in File.ReadLines(str))
                {
                    string lastWord = line.Split(';').Last();
                    ix = System.Convert.ToInt32(lastWord);
                    sum32 += ix;
                }


                str = str.Replace("wydatek.txt", "");
                str = str + "                   " + sum32;
                ix = 0;
                sum32 = 0;
                //sum32 = 0;
                listView2.Items.Add(str);
                str = "";
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            przDashboard.Text = "Dashboard";
            przPrzychody.Text = "Income";
            przRaporty.Text = "Reports";
            przUstawienia.Text = "Settings";
            przWydatki.Text = "Expense";
            bunifuFlatButton7.Text = "Currencies";
            bunifuFlatButton9.Text = "Accounts";
            label8.Text = "Income";
            label9.Text = "Expense";
            label12.Text = "Expense overview";
            label11.Text = "Income overview";
            label2.Text = "All income";
            label5.Text = "All expenses";
            label7.Text = "Balance";
            podajDate.Visible = false;
            lblWitaj.Text = "Hello";
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void czas_Click(object sender, EventArgs e)
        {

        }

        private void timer4_Tick(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        public void redfont()
        {
            label1.ForeColor = Color.FromArgb(206, 86, 86);
            label10.ForeColor = Color.FromArgb(206, 86, 86);
            label11.ForeColor = Color.FromArgb(206, 86, 86);
            label12.ForeColor = Color.FromArgb(206, 86, 86);
            label13.ForeColor = Color.FromArgb(206, 86, 86);
            label14.ForeColor = Color.FromArgb(206, 86, 86);
            label15.ForeColor = Color.FromArgb(206, 86, 86);
            label16.ForeColor = Color.FromArgb(206, 86, 86);
            label17.ForeColor = Color.FromArgb(206, 86, 86);
            label18.ForeColor = Color.FromArgb(206, 86, 86);
            label19.ForeColor = Color.FromArgb(206, 86, 86);
            label2.ForeColor = Color.FromArgb(206, 86, 86);
            label20.ForeColor = Color.FromArgb(206, 86, 86);
            label21.ForeColor = Color.FromArgb(206, 86, 86);
            label22.ForeColor = Color.FromArgb(206, 86, 86);
            label23.ForeColor = Color.FromArgb(206, 86, 86);
            label24.ForeColor = Color.FromArgb(206, 86, 86);
            label25.ForeColor = Color.FromArgb(206, 86, 86);
            label26.ForeColor = Color.FromArgb(206, 86, 86);
            label27.ForeColor = Color.FromArgb(206, 86, 86);
            label28.ForeColor = Color.FromArgb(206, 86, 86);
            label29.ForeColor = Color.FromArgb(206, 86, 86);
            label3.ForeColor = Color.FromArgb(206, 86, 86);
            label31.ForeColor = Color.FromArgb(206, 86, 86);
            label30.ForeColor = Color.FromArgb(206, 86, 86);
            label32.ForeColor = Color.FromArgb(206, 86, 86);
            label33.ForeColor = Color.FromArgb(206, 86, 86);
            label34.ForeColor = Color.FromArgb(206, 86, 86);
            label35.ForeColor = Color.FromArgb(206, 86, 86);
            label36.ForeColor = Color.FromArgb(206, 86, 86);
            label38.ForeColor = Color.FromArgb(206, 86, 86);
            label4.ForeColor = Color.FromArgb(206, 86, 86);
            label5.ForeColor = Color.FromArgb(206, 86, 86);


            label42.ForeColor = Color.FromArgb(206, 86, 86);
            label40.ForeColor = Color.FromArgb(206, 86, 86);

            label6.ForeColor = Color.FromArgb(206, 86, 86);
            label7.ForeColor = Color.FromArgb(206, 86, 86);
            label8.ForeColor = Color.FromArgb(206, 86, 86);
            label9.ForeColor = Color.FromArgb(206, 86, 86);
            label39.ForeColor = Color.FromArgb(206, 86, 86);
            label37.ForeColor = Color.FromArgb(206, 86, 86);
        }

        public void greenfont()
        {
            label1.ForeColor = Color.FromArgb(0, 153, 0);
            label10.ForeColor = Color.FromArgb(0, 153, 0);
            label11.ForeColor = Color.FromArgb(0, 153, 0);
            label12.ForeColor = Color.FromArgb(0, 153, 0);
            label13.ForeColor = Color.FromArgb(0, 153, 0);
            label14.ForeColor = Color.FromArgb(0, 153, 0);
            label15.ForeColor = Color.FromArgb(0, 153, 0);
            label16.ForeColor = Color.FromArgb(0, 153, 0);
            label17.ForeColor = Color.FromArgb(0, 153, 0);
            label18.ForeColor = Color.FromArgb(0, 153, 0);
            label19.ForeColor = Color.FromArgb(0, 153, 0);
            label2.ForeColor = Color.FromArgb(0, 153, 0);
            label20.ForeColor = Color.FromArgb(0, 153, 0);
            label21.ForeColor = Color.FromArgb(0, 153, 0);
            label22.ForeColor = Color.FromArgb(0, 153, 0);
            label23.ForeColor = Color.FromArgb(0, 153, 0);
            label24.ForeColor = Color.FromArgb(0, 153, 0);
            label25.ForeColor = Color.FromArgb(0, 153, 0);
            label26.ForeColor = Color.FromArgb(0, 153, 0);
            label27.ForeColor = Color.FromArgb(0, 153, 0);
            label28.ForeColor = Color.FromArgb(0, 153, 0);
            label29.ForeColor = Color.FromArgb(0, 153, 0);
            label3.ForeColor = Color.FromArgb(0, 153, 0);
            label31.ForeColor = Color.FromArgb(0, 153, 0);
            label30.ForeColor = Color.FromArgb(0, 153, 0);
            label32.ForeColor = Color.FromArgb(0, 153, 0);
            label33.ForeColor = Color.FromArgb(0, 153, 0);
            label34.ForeColor = Color.FromArgb(0, 153, 0);
            label35.ForeColor = Color.FromArgb(0, 153, 0);
            label36.ForeColor = Color.FromArgb(0, 153, 0);
            label38.ForeColor = Color.FromArgb(0, 153, 0);
            label4.ForeColor = Color.FromArgb(0, 153, 0);
            label5.ForeColor = Color.FromArgb(0, 153, 0);
            label6.ForeColor = Color.FromArgb(0, 153, 0);
            label7.ForeColor = Color.FromArgb(0, 153, 0);
            label8.ForeColor = Color.FromArgb(0, 153, 0);
            label9.ForeColor = Color.FromArgb(0, 153, 0);

            label42.ForeColor = Color.FromArgb(0, 153, 0);
            label40.ForeColor = Color.FromArgb(0, 153, 0);

            label39.ForeColor = Color.FromArgb(0, 153, 0);
            label37.ForeColor = Color.FromArgb(0, 153, 0);
        }

        private void bunifuFlatButton11_Click(object sender, EventArgs e)
        {
            redfont();
        }

        private void bunifuFlatButton12_Click(object sender, EventArgs e)
        {
            greenfont();
        }
    }

}
