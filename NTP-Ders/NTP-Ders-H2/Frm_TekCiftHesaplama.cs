using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTP_Ders_H2
{
    public partial class Frm_TekCiftHesaplama : Form
    {
        public Frm_TekCiftHesaplama()
        {
            InitializeComponent();
        }

        private void AralikHesapla(int baslangic, int bitis)
        {
            int tekToplam = 0;
            int ciftToplam = 0;
            int genelToplam = 0;
            for (int i = baslangic; i <= bitis; i++)
            {
                genelToplam += i;

                if ((i % 2) == 0)
                {
                    ciftToplam += i;
                }
                else
                {
                    tekToplam += i;
                }
            }
        }
            
               

            
        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            int baslangic = Convert.ToInt32(txt_baslangıc);
            int bitis = Convert.ToInt32(txt_bitis);
            int tekToplam = 0;
            int ciftToplam = 0;
            int genelToplam = 0;
            for (int i = baslangic; i <= bitis; i++)
            {
                genelToplam += i;

                if ((i % 2) == 0)
                {
                    ciftToplam += i;
                }
                else
                {
                    tekToplam += i;
                }
            }

            txt_tektoplam.Text = Convert.ToInt32(tekToplam);
           
            
        }
    }
}
