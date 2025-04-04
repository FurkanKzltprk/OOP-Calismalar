using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTP_Ders_H5_uyg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            Fabrika fabrika = new Fabrika();
            fabrika.Ad = "Seyrek Fabrikası";

            KimlikBilgisi kimlik = new KimlikBilgisi();

            kimlik.TCKimlikNo = 1221122313;
            kimlik.Ad = "mehmet";
            kimlik.Soyad = "kaya";
            kimlik.DogumYeri = "adana";
            //AdSoyad read-only
            //Kimlik.AdSoyad = "..";

            Isci isci = new Isci();

            isci.Kimlik = kimlik;
            isci.SirketKimlikNo = 9812;
            isci.Maas = 4000;
            MessageBox.Show(isci.Kimlik.AdSoyad);

            fabrika.CalisanEkle(isci);
        }
    }
}
