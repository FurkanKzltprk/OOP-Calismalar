namespace Hali_Yikama
{
    public partial class Form1 : Form
    {
        List<Musteri> musteriler = new List<Musteri>();
        List<Hali> halilar = new List<Hali>();

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MusterileriYukle();
        }

        //Form yüklendiðinde Musterileri aktif müþterileri ComboBox'a eklemek laýzm!!
        private void MusterileriYukle()
        {
            cmb_musteriler.Items.Clear(); //comboboxu temizledik önce
            foreach (Musteri musteri in musteriler)
            {
                cmb_musteriler.Items.Add(musteri.Id + " " + musteri.Ad);
            }

        }
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            int musteriId = musteriler.Count + 1;
            string ad = txt_Ad.Text;
            string telefon = txt_Telefon.Text;
            string adres = txt_Adres.Text;

            if (string.IsNullOrWhiteSpace(ad) || string.IsNullOrWhiteSpace(telefon) || string.IsNullOrWhiteSpace(adres))
            {
                MessageBox.Show("Lütfen tüm müþteri bilgilerini giriniz.");
                return;
            }

            if (telefon.Length != 10 || !telefon.All(char.IsDigit))
            {
                MessageBox.Show("Telefon numarasý 10 haneli olmalý ve sadece rakamlardan oluþmalýdýr.");
                return;
            }

            Musteri yeniMusteri = new Musteri(musteriId, ad, telefon, adres);
            musteriler.Add(yeniMusteri); //List'in Add metodunu kullandýk en üstte tanýmladýk dikkat.
            MusterileriYukle();

            /*2.bir müþteri eklemek istediðimde textbox'lar bir öncekini içeriyordu
               bunu çözmek için textbox'larýn içeriðini temizlemek gerekiyor*/

            txt_Ad.Clear();
            txt_Telefon.Clear();
            txt_Adres.Clear();

            MessageBox.Show("Müþteri baþarýyla eklendi");


        }

        private void btn_HaliEkle_Click(object sender, EventArgs e)
        {
            if (cmb_musteriler.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir müþteri seçiniz...");
                return;
            }

            string secilen = cmb_musteriler.SelectedItem.ToString();
            int musteriId = int.Parse(secilen.Split(' ')[0]); //Ýd alýp split ediyoruz

            Musteri secilenMusteri = null;

            foreach (Musteri m in musteriler)
            {
                if (m.Id == musteriId)
                {
                    secilenMusteri = m;
                    break;
                }

            }
            if (secilenMusteri == null)
            {
                MessageBox.Show("Müþteri bulunamadý");
                return;
            }


            if (!double.TryParse(txt_metrekare.Text, out double metrekare) || metrekare <= 0)
            {
                MessageBox.Show("Geçerli bir metrekare deðeri giriniz.");
                return;
            }

            DateTime alimTarihi = dtp_alimTarihi.Value;
            DateTime teslimTarihi = dtp_teslimTarihi.Value;

            int haliId = halilar.Count + 1;
            string durum = "Yýkamada";

            Hali yeniHali = new Hali(haliId, metrekare, alimTarihi, teslimTarihi, durum);

            secilenMusteri.Halilar.Add(yeniHali);
            halilar.Add(yeniHali);
            lst_yýkamada.Items.Add(yeniHali);

            txt_metrekare.Clear();
            MessageBox.Show("Halý baþarýyla eklendi");
        }

        private void btn_durum_Click(object sender, EventArgs e)
        {
            if (lst_yýkamada.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen teslim edilecek halýyý seçin.");
                return;
            }
            Hali secilenHali = (Hali)lst_yýkamada.SelectedItem;

            secilenHali.Durum = "Teslim Edildi";

            lst_yýkamada.Items.Remove(secilenHali);
            lst_teslim.Items.Add(secilenHali);

            MessageBox.Show("Halý durumu 'Teslim Edildi' olarak güncellendi");
        }
    }
}
