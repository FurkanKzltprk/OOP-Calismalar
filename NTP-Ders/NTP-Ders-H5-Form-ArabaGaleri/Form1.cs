namespace NTP_H5_Form_ArabaGaleri
{
    public partial class Form1 : Form
    {
        Galeri c;
        public Form1()
        {
            InitializeComponent();
            c = new Galeri();
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            string[] s = c.arabaListele();
            for (int i = 0; i < s.Length; i++)
            {
                listBox1.Items.Add(s[i]);
            }

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            string marka = txt_marka.Text;
            short model = Convert.ToInt16(txt_model.Text);
            string renk = txt_renk.Text;
            Araba a = new Araba(marka, model, renk);

            c.arabaEkle(a);
            MessageBox.Show("Ekleme baþarýlý");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
