namespace NTP_Vize_uygulama__ATM_
{
    public partial class Form1 : Form
    {

        int s = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_10_Click(object sender, EventArgs e)
        {

        }

        private void btn_paraver_Click(object sender, EventArgs e)
        {
            lstDetails.Items.Clear();

            int miktar = Convert.ToInt32(textBox1.Text);

            int[] banknotlar = { 200, 100, 50, 20, 10 };

            foreach (int banknot in banknotlar)
            {

                int adet = miktar / banknot;


                if (adet > 0)
                {
                    lstDetails.Items.Add($"{banknot} TL x {adet}");

                    miktar %= banknot;
                }



            }
        }

        private void btn_20_Click(object sender, EventArgs e)
        {


            Button b = (Button)sender;

            int sayi = Convert.ToInt32(b.Text);

            s = s + sayi;

            textBox1.Text = s.ToString();
        }
    }
}
