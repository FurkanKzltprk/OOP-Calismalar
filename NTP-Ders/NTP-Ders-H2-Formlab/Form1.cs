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
    public partial class Form1 : Form
    {
        string s;
        public Form1()
        {
            InitializeComponent();
            s = "";
            button2.Click += button7_Click;
            button3.Click += button7_Click;
            button4.Click += button7_Click;
            button8.Click += button7_Click;
            button6.Click += button7_Click;
            button10.Click += button7_Click;
            button11.Click += button7_Click; //button11.Click = button11.Click + button7_Click
            button13.Click += button7_Click;
            button14.Click += button7_Click;
            // burada buton isimleri saçma ama doğru çalışıyor dikkat et !!!
            //bağlama işlemi çok önemli dedi emre hoca 
            //ctro'un içerisinde bağladı.



            //button7.Click = Delegate.Combine(button7.Click, new EventHandler(BenimMetodum));
            //button7.Click += BenimMetodum; ✅  // Olay listesine ekler
            //button7.Click -= BenimMetodum; ✅  // Olay listesinden çıkarır
            //button7.Click = button7.Click + BenimMetodum; ❌  // Derleme hatası alırsın

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            s = "";
            textBox1.Text= "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // bir butonu refeans buton olarak ayarlama olayı !! önemli
            //button7 nin texti 1 sadece biri bağladık şimdi Formun ctor'unda -
            // geri kalan butonları bağlayacaz.

            Button b=(Button)sender;
            s += b.Text;
            textBox1.Text = s;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                sum = sum + (int)(s[i] -'0');  //asci kodlarından 0'ı çıkartınca gerçek değerini veriyor.
                                               //öenmli bilgi.
                Form1.ActiveForm.Text = "rakamlar Toplamı:"+sum;  //??   //En üstteki formun ismi
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
    }
}
