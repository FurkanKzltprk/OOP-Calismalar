namespace NTP_Vize_s3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_topla_Click(object sender, EventArgs e)
        {
            string metin = txtBox.Text;
            string[] sayilarstr = metin.Split(',');
            int toplam = 0;

            for (int i = 0; i < sayilarstr.Length; i++)
            {
                int sayi = Convert.ToInt32(sayilarstr[i]);
                toplam += sayi;

            }
            double ortalama = toplam / sayilarstr.Length;

            lbl_ort.Text = "Ortalama : " + ortalama.ToString();
            lbl_top.Text = "Toplam   : " + toplam.ToString();   



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
