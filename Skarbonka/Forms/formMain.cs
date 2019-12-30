﻿using System;
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


namespace Skarbonka
{

    public partial class formMain : Form
    {


        string txtprzych = "przychod.txt";
        string txtwyd = "wydatek.txt";
        string txtlog = "login.txt";



        public formMain()
        {
            File.AppendAllText("current.txt", "");
            File.AppendAllText("login.txt", "admin;admin");

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
          //  new Helper.Popup.transparentBg(this, new Forms.login());

            InitializeComponent();

            ApplyGridTheme(gridPrzychody);
            ApplyGridTheme(gridWydatki);
            ApplyGridTheme(gridZPrzychod);
            ApplyGridTheme(gridZKonta);
            ApplyGridTheme(gridWydatki);
            ApplyGridTheme(gridZWydatki);
            bunifuDataViz1.colorSet.Add(col1.BackColor);
            bunifuDataViz1.colorSet.Add(col2.BackColor);
            bunifuDataViz1.colorSet.Add(col3.BackColor);

         }




        public void klik()
        {
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
            wskaznik.Left = btn.Left;
            wskaznik.Width = btn.Width;

        }

        private void formMain_Load(object sender, EventArgs e)
        {

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
            Bunifu.DataViz.WinForms.Canvas canvas = new Bunifu.DataViz.WinForms.Canvas();

            Bunifu.DataViz.WinForms.DataPoint przychod = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_spline);
            Bunifu.DataViz.WinForms.DataPoint wydatki = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_spline);
            //Bunifu.DataViz.WinForms.DataPoint balans = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_spline);

            //random data
         /* Random ran = new Random();
            for (int i = 0; i <= 30; i++)
            {
                wydatki.addLabely(i.ToString(), ran.Next(0, 100));
                balans.addLabely(i.ToString(), ran.Next(100, 1000));
            }*/

            

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

            //random data

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
            timer1.Interval = 2000;
            RenderMonthChart();
            RenderPrzychodChart();
            RenderWydatkiChart();
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

            new Helper.Popup.transparentBg(this, new Forms.formdodajPrzychod(podajDate.Value));

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
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
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            rows.AddRange(gridPrzychody.Rows.Cast<DataGridViewRow>());
            rows.Reverse();
            gridPrzychody.Rows.Clear();
            gridPrzychody.Rows.AddRange(rows.ToArray());
        }


        private void Timer2_Tick(object sender, EventArgs e)
        {

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





        }

        private void button69_Click(object sender, EventArgs e)
        {

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
            List<string> lines = File.ReadAllLines(filepath).ToList();

            File.WriteAllLines(filepath, lines.GetRange(0, lines.Count - 1).ToArray());

        }


        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            DeleteLastLine(txtwyd);
        }

        private void buttonUsun_Click(object sender, EventArgs e)
        {
            DeleteLastLine(txtprzych);
        }

        private void bunifuDataViz3_Load(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
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
                                pdfDoc.Add(descriptionChunk);

                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                                markerP = true;
                            }

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

                                pdfDoc.Add(descriptionChunk);
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                                markerW = true;
                            }

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
        private string pathO = string.Empty;
        private void MergePDF(string File1, string File2)
        {
            
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
            
            string x = pathP;
            string z = pathW;
            if (markerP = true && markerW == true)
            {
                MergePDF(x, z);
                MessageBox.Show("Raport ogólny został stworzony!", "Info");

            }
            else
            {
                MessageBox.Show("Najpierw stwórz aktualne raporty wydatków i przychodów!", "Info");
            }

        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
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
    }
}
