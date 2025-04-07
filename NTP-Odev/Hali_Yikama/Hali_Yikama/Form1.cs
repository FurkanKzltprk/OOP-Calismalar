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

        //Form y�klendi�inde Musterileri aktif m��terileri ComboBox'a eklemek la�zm!!
        private void MusterileriYukle()
        {
            cmb_musteriler.Items.Clear(); //comboboxu temizledik �nce
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
                MessageBox.Show("L�tfen t�m m��teri bilgilerini giriniz.");
                return;
            }

            if (telefon.Length != 10 || !telefon.All(char.IsDigit))
            {
                MessageBox.Show("Telefon numaras� 10 haneli olmal� ve sadece rakamlardan olu�mal�d�r.");
                return;
            }

            Musteri yeniMusteri = new Musteri(musteriId, ad, telefon, adres);
            musteriler.Add(yeniMusteri); //List'in Add metodunu kulland�k en �stte tan�mlad�k dikkat.
            MusterileriYukle();

            /*2.bir m��teri eklemek istedi�imde textbox'lar bir �ncekini i�eriyordu
               bunu ��zmek i�in textbox'lar�n i�eri�ini temizlemek gerekiyor*/

            txt_Ad.Clear();
            txt_Telefon.Clear();
            txt_Adres.Clear();

            MessageBox.Show("M��teri ba�ar�yla eklendi");


        }

        private void btn_HaliEkle_Click(object sender, EventArgs e)
        {
            if (cmb_musteriler.SelectedIndex == -1)
            {
                MessageBox.Show("L�tfen bir m��teri se�iniz...");
                return;
            }

            string secilen = cmb_musteriler.SelectedItem.ToString();
            int musteriId = int.Parse(secilen.Split(' ')[0]); //�d al�p split ediyoruz

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
                MessageBox.Show("M��teri bulunamad�");
                return;
            }


            if (!double.TryParse(txt_metrekare.Text, out double metrekare) || metrekare <= 0)
            {
                MessageBox.Show("Ge�erli bir metrekare de�eri giriniz.");
                return;
            }

            DateTime alimTarihi = dtp_alimTarihi.Value;
            DateTime teslimTarihi = dtp_teslimTarihi.Value;

            int haliId = halilar.Count + 1;
            string durum = "Y�kamada";

            Hali yeniHali = new Hali(haliId, metrekare, alimTarihi, teslimTarihi, durum);

            secilenMusteri.Halilar.Add(yeniHali);
            halilar.Add(yeniHali);
            lst_y�kamada.Items.Add(yeniHali);

            txt_metrekare.Clear();
            MessageBox.Show("Hal� ba�ar�yla eklendi");
        }

        private void btn_durum_Click(object sender, EventArgs e)
        {
            if (lst_y�kamada.SelectedIndex == -1)
            {
                MessageBox.Show("L�tfen teslim edilecek hal�y� se�in.");
                return;
            }
            Hali secilenHali = (Hali)lst_y�kamada.SelectedItem;

            secilenHali.Durum = "Teslim Edildi";

            lst_y�kamada.Items.Remove(secilenHali);
            lst_teslim.Items.Add(secilenHali);

            MessageBox.Show("Hal� durumu 'Teslim Edildi' olarak g�ncellendi");
        }
    }
}
