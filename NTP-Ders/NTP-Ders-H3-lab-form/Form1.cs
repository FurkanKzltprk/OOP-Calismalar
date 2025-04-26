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

namespace NTP_Ders_H3_lab_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Butona basıldığında hedef dosya yolundaki verileri TextBox'a getirir
        private void btn_vericek_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("D:\\Text.txt");
            string line = sr.ReadLine();
            while (line != null)
            {
                txt_veri.Text += " " + line;
                line = sr.ReadLine();
            }
            sr.Close();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            char[] noktalama = {
                '.', ',', ';', ':', '!', '?', '-', '_', '(', ')', '[', ']', '{', '}',
                '"', '/', '|', '@', '#', '$', '%', '^', '&', '*', '=', '+',
                '<', '>', '~', '`',
            };

            string metin = txt_veri.Text;
            string temizMetin = "";
            //string temizMetin2 = new string(metin.Where(c => !noktalama.Contains(c)).ToArray()); //alternatif kullanım

            foreach (char karakter in metin)
            {
                bool varMi = false;
                for (int i = 0; i < noktalama.Length; i++)
                {
                    if (karakter == noktalama[i])
                    {
                        varMi = true;
                        break; // Noktalama işareti bulunursa döngüden çık
                    }
                }

                if (!varMi) // Eğer karakter noktalama işareti değilse ekle
                {
                    temizMetin += karakter;
                }
            }

            txt_temizveri.Text = temizMetin; // TextBox'a temizlenmiş metni geri yükle
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}