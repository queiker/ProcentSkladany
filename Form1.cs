using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;



namespace ProcentSkladany
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_wynik.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (check_values() == "Błąd : ")
            {
                double v0 = double.Parse(txt_kapital_poczatkowy.Text);
                double m = double.Parse(txt_liczba_kapitalizacji_w_roku.Text);
                double n = double.Parse(txt_liczba_lat_zapadalnosci_depozytu.Text);
                double r = double.Parse(txt_roczne_oprocentowanie_w_procentach.Text);
                double b = (1 + (r / m / 100));
                double power = m * n;
                double equal = v0 * Math.Pow(b, power);
                lbl_wynik.Text = string.Concat(equal);
            }
            else
            {
                lbl_wynik.Text = check_values();
            }
        }
        public string check_values()
        {
            string to_return = "Błąd : ";

            try
            {
                double.Parse(txt_kapital_poczatkowy.Text);
            }
            catch
            {
                to_return = to_return + "kapitał początkowy \n";
            }
            try
            {
                double.Parse(txt_liczba_kapitalizacji_w_roku.Text);
            }
            catch
            {
                to_return = to_return + "liczba kapitalizacji \n";
            }
            try
            {
                double.Parse(txt_liczba_lat_zapadalnosci_depozytu.Text);
            }
            catch
            {
                to_return = to_return + "liczba lat zapadalności depozytu \n";
            }
            try
            {
                double.Parse(txt_roczne_oprocentowanie_w_procentach.Text);
            }
            catch
            {
                to_return = to_return + "oprocentowanie w procentach \n";
            }
            return to_return;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.itkrakow.pl");

        }
    }
}

