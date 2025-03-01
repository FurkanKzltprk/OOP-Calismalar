using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTP_Ders_2
{
    public partial class Frm_Toplama : Form
    {
        public Frm_Toplama()
        {
            InitializeComponent();
        }



        private int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        private Boolean Dogrula()
        {

            try
            {
                Convert.ToInt32(txt_birincisayi.Text);
                Convert.ToInt32(txt_ikincisayi.Text);
                return true;

            }
            catch (Exception e)
            {
                return false;
            }
        }

        private void EkraniAyarla(bool toplamBasarili = false)
        {
            if (!toplamBasarili)
            {

                txt_birincisayi.Text = txt_ikincisayi.Text = "0";
                txt_birincisayi.Focus();


            }

        }
        private void btn_toplama_Click(object sender, EventArgs e)
        {
            bool dogrulamaSonucu = Dogrula();
            if (dogrulamaSonucu)
            {
                int toplam = Topla(Convert.ToInt32(txt_birincisayi.Text), (Convert.ToInt32(txt_ikincisayi.Text)));
                txt_sonuc.Text = toplam.ToString();
            }
            else
            {
                MessageBox.Show("Girdiğiniz değerlerde hata var !");

                EkraniAyarla(dogrulamaSonucu);
            }

        }

        private void txt_birincisayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) ||
                    char.IsSymbol(e.KeyChar) ||
                    char.IsWhiteSpace(e.KeyChar) ||
                    char.IsPunctuation(e.KeyChar) && e.KeyChar != '-')


                e.Handled = true;

        }

        private void txt_ikincisayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) ||
                   char.IsSymbol(e.KeyChar) ||
                   char.IsWhiteSpace(e.KeyChar) ||
                   char.IsPunctuation(e.KeyChar) && e.KeyChar != '-')

                e.Handled = true;
        }

        private void Frm_Toplama_Load(object sender, EventArgs e)
        {

        }
    }
}
