namespace NTP_Ders_H4_Form__Gr_
{
    public partial class Form1 : Form
    {

        public class Personel
        {
            public string Ad;
            public string Soyad;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_ad_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void PersonelBilgiDegistir(Personel p)
        {
            p.Ad = p.Ad.ToUpper();
            p.Soyad = p.Soyad.ToUpper();

        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            personel.Ad =txt_boxAd.Text;
            personel.Soyad = txt_soyad.Text;


            //metoda parametre olarak nesne yolladýk
            PersonelBilgiDegistir(personel);

            //nesne metot dýþýmda çýktýðýnda da deðeri deðiþtir.
            txt_boxAd.Text = personel.Ad;
            txt_soyad.Text = personel.Soyad;

        }
    }
}
