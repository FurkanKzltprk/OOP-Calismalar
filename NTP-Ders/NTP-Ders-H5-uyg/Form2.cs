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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            Hali hali = new Hali();
            hali.Genislik = 4;
            hali.Uzunluk = 6;

            MessageBox.Show("Alan :" + hali.Alan);
                
                       
    
        }
    }
}
