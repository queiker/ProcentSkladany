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
            /*
            txt_kapital_poczatkowy.Text*(1+txt_roczne_oprocentowanie_w_procentach.Text/100/txt_liczba_kapitalizacji_w_roku.Text)^txt_liczba_kapitalizacji_w_roku.text*txt_liczba_lat_zapadalnosci_depozytu.Text
            */
            double init_capital = double.Parse(txt_kapital_poczatkowy.Text);
            
            double compound_invest_number_in_year = double.Parse(txt_liczba_kapitalizacji_w_roku.Text);
            double investment_years = double.Parse(txt_liczba_lat_zapadalnosci_depozytu.Text);
            double year_capitalization = double.Parse(txt_roczne_oprocentowanie_w_procentach.Text);
            double equal_1 = 0;
            equal_1 = init_capital * (1 + year_capitalization / 100 / compound_invest_number_in_year);
            double equal_2;
            equal_2 = Math.Pow(equal_1, (compound_invest_number_in_year * investment_years));

            lbl_wynik.Text = string.Concat(equal_2);




        }
    }
}
