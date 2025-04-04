using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTP_Ders_H2._1
{
    public partial class H2_Lab_Form : Form
    {
        public H2_Lab_Form()
        {
            InitializeComponent();
        }

        //proje console üzerine açıldığı için çalışmadı form . kodlar doğru ama.

        private void btn_topla_Click(object sender, EventArgs e)
        {
            int birincisayi, ikincisayi, toplam;

            birincisayi = Convert.ToInt32(textBox1.Text);
            ikincisayi = Convert.ToInt32(textBox2.Text);

            toplam = birincisayi + ikincisayi;

            MessageBox.Show("Toplam : " + toplam);


        }
    }
}
