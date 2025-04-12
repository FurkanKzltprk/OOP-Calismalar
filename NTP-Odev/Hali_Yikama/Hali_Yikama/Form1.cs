namespace Hali_Yikama
{
    public partial class Form1 : Form
    {
        List<Musteri> musteriler = new List<Musteri>();
        List<Hali> halilar = new List<Hali>();
        string dosyaYolu = Path.Combine(Application.StartupPath,"Dosyalar","veriler.txt");

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
            VerileriYukle();
            MusterileriYukle();
        }

        private void VerileriKaydet()
        {
            // 1. Klasörü oluþtur (yoksa)
            string klasorYolu = Path.Combine(Application.StartupPath, "Dosyalar");
            if (!Directory.Exists(klasorYolu))
            {
                Directory.CreateDirectory(klasorYolu);
            }

            // 2. Dosya yolunu hazýrla
            string dosyaYolu = Path.Combine(klasorYolu, "veriler.txt");

            // 3. Yazma iþlemi
            using (StreamWriter sw = new StreamWriter(dosyaYolu))
            {
                // Müþteriler bölümü
                sw.WriteLine("[Musteri]");
                foreach (var m in musteriler)
                {
                    sw.WriteLine($"{m.Id}|{m.Ad}|{m.TelNo}|{m.Adres}");
                }

                // Halýlar bölümü
                sw.WriteLine("[Hali]");
                foreach (var m in musteriler)
                {
                    foreach (var h in m.Halilar)
                    {
                        sw.WriteLine($"{h.Id}|{m.Id}|{h.Metrekare}|{h.AlimTarihi.ToShortDateString()}|{h.TeslimTarihi.ToShortDateString()}|{h.Durum}|{h.Ucret}");
                    }
                }
            }
        }

        private void VerileriYukle()
        {
            // Dosya yolu belirle
            string dosyaYolu = Path.Combine(Application.StartupPath, "Dosyalar", "veriler.txt");

            // Dosya yoksa hiç uðraþma, geri dön
            if (!File.Exists(dosyaYolu)) return;

            string[] satirlar = File.ReadAllLines(dosyaYolu);
            bool musteriKismi = false;
            bool haliKismi = false;

            foreach (string satir in satirlar)
            {
                if (satir == "[Musteri]") { musteriKismi = true; haliKismi = false; continue; }
                if (satir == "[Hali]") { haliKismi = true; musteriKismi = false; continue; }

                if (musteriKismi)
                {
                    var p = satir.Split('|');
                    int id = int.Parse(p[0]);
                    string ad = p[1];
                    string tel = p[2];
                    string adres = p[3];

                    Musteri m = new Musteri(id, ad, tel, adres);
                    musteriler.Add(m);
                }
                else if (haliKismi)
                {
                    var p = satir.Split('|');
                    int haliId = int.Parse(p[0]);
                    int musteriId = int.Parse(p[1]);
                    double metrekare = double.Parse(p[2]);
                    DateTime alim = DateTime.Parse(p[3]);
                    DateTime teslim = DateTime.Parse(p[4]);
                    string durum = p[5];

                    Hali h = new Hali(haliId, metrekare, alim, teslim, durum);

                    Musteri musteri = musteriler.FirstOrDefault(m => m.Id == musteriId);
                    if (musteri != null)
                    {
                        h.MusteriAdi = musteri.Ad;
                        musteri.Halilar.Add(h);
                        halilar.Add(h);

                        if (durum == "Yýkamada")
                            lst_yýkamada.Items.Add(h);
                        else
                            lst_teslim.Items.Add(h);
                    }
                }
            }

            MusterileriYukle(); // ComboBox’ý güncelle
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

            VerileriKaydet();


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

            VerileriKaydet();
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
            VerileriKaydet();
        }
    }
}
