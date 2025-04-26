using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTP_Ders_H2_Formlab
{
    public partial class Form2 : Form
    {

        string s;
        public Form2()
        {
            InitializeComponent();
            s = "";
            btn_1.Click += btn_0_Click;
        }
        //00010101 gibi binary'i decimale dönüştüren kodu yazdıracak labda
        // sınavda hexadecimal olanı çıkabilir ihtimali yüksek
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            s = s+ b.Text;
            txt_1.Text = s;
        }

        private void btn_donustur_Click(object sender, EventArgs e)
        {
            int sonuc = 0;
            int us = 0;

            for (int i = s.Length -1;i >= 0;i --)   // 0 ascii : 48 
            {
                int rakam = Convert.ToInt32(s[i]-'0'); //ascii değeri gelmesin diye.
                sonuc +=  (int)(Math.Pow(2,us)*rakam);
                us = us + 1;

            }
            lbl_sonuc.Text = "Sayı : " + sonuc;
            s = "";
            txt_1.Text = s;
        }

        private void btn_hexa_Click(object sender, EventArgs e)
        {
            try
            {
                // Binary'den Decimal'e çevirme
                int decimalValue = Convert.ToInt32(s, 2);

                // Decimal'den Hex'e çevirme
                string hexValue = decimalValue.ToString("X");

                // Sonucu ekrana yazdırma
                lbl_sonuc.Text = "Hexadecimal: " + hexValue;
            }
            catch (Exception)
            {
                MessageBox.Show("Geçerli bir binary sayı giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            s = "";
            txt_1.Text = s;
        }
    }
}
