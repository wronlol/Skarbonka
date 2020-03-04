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
using System.Diagnostics;
using System.Net.Mail;
namespace Skarbonka.Forms
{
    public partial class login : Form
    {
        public login()
        {


            InitializeComponent();
        }




        int wrong = 0;
        private void btnZaloguj_Click(object sender, EventArgs e)
        {
            string log = txtLog.Text;
            string has = txtHas.Text;
            
            wrong++;
            foreach (string line in File.ReadLines(@"login.txt"))
            {
                if (log != "" & has != "")
                {
                    if (line.Contains(log) & line.Contains(has))
                    {
                        File.WriteAllText("current.txt", log);
                        this.Close();
                    }
                    else
                    {
                        lblWrong.Text = ("Zły login lub hasło!");
                    }
                }
                else
                {
                    lblWrong.Text = ("Zły login lub hasło!");
                }



                
                        if (wrong == 5)
                        {

                            string input = ("l2biszop@gmail.com");
                            if (input != null)
                            {
                                MailMessage theMailMessage = new MailMessage("sprawdziantei@wp.pl", input);
                                theMailMessage.Body = "Ktoś próbował zalogować się na konto " + log;
                                theMailMessage.Subject = "Nieudane próby zalogowania";

                                SmtpClient theClient = new SmtpClient("smtp.wp.pl");
                                theClient.UseDefaultCredentials = false;
                                System.Net.NetworkCredential theCredential = new System.Net.NetworkCredential("sprawdziantei@wp.pl", "pszemo123");
                                theClient.Credentials = theCredential;
                                theClient.Send(theMailMessage);

                            }
                            wrong = int.MinValue;
                        }
                        


            }



        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            
            new Helper.Popup.transparentBg(this, new Forms.rejestr());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtOpis1_OnValueChanged(object sender, EventArgs e)
        {
            File.WriteAllText("current.txt", txtLog.Text);
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

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


    }



}
