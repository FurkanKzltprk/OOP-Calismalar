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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private int Topla (int sayi1 , int sayi2)
        {
            return sayi1 + sayi2;
        }


        private void EkraniAyarla()
        {
            txt_birincisayi.Text = txt_ikincisayi.Text = "0";
            txt_birincisayi.Focus(); //Focus , program başlayınca oraya atar imleci
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

        private void btn_topla_Click(object sender, EventArgs e)
        {
            if (Dogrula())
            {
                int toplam = Topla(Convert.ToInt32(txt_birincisayi.Text)
                                  , Convert.ToInt32(txt_ikincisayi.Text));

                //interpolasyon yeni yöntem '$' bunu kullanarak yap.

                MessageBox.Show($"Toplam : {toplam}");

                //alernatif
                //MessageBox.Show(string.Format("Toplam : {0}",toplam));


            }else
            {
                MessageBox.Show("Girdiğiniz değerlerde hata var ! ");
            }
        }
        
        private void ToplamaFormu_Shown(object sender, EventArgs e)
        {
            EkraniAyarla();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
