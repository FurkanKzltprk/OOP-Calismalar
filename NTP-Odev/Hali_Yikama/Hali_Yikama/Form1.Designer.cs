namespace Hali_Yikama
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grp_Musteri = new GroupBox();
            txt_Adres = new TextBox();
            txt_Telefon = new TextBox();
            txt_Ad = new TextBox();
            btn_ekle = new Button();
            lbl_Adres = new Label();
            lbl_Telefon = new Label();
            lbl_ad = new Label();
            grp_Hali = new GroupBox();
            btn_HaliEkle = new Button();
            dtp_teslimTarihi = new DateTimePicker();
            dtp_alimTarihi = new DateTimePicker();
            cmb_musteriler = new ComboBox();
            txt_metrekare = new TextBox();
            lbl_teslimtarihi = new Label();
            lbl_Alımtarihi = new Label();
            lbl_metrekare = new Label();
            lbl_musteri = new Label();
            grp_durum = new GroupBox();
            btn_durum = new Button();
            lst_yıkamada = new ListBox();
            lst_teslim = new ListBox();
            grp_Musteri.SuspendLayout();
            grp_Hali.SuspendLayout();
            grp_durum.SuspendLayout();
            SuspendLayout();
            // 
            // grp_Musteri
            // 
            grp_Musteri.Controls.Add(txt_Adres);
            grp_Musteri.Controls.Add(txt_Telefon);
            grp_Musteri.Controls.Add(txt_Ad);
            grp_Musteri.Controls.Add(btn_ekle);
            grp_Musteri.Controls.Add(lbl_Adres);
            grp_Musteri.Controls.Add(lbl_Telefon);
            grp_Musteri.Controls.Add(lbl_ad);
            grp_Musteri.Location = new Point(12, 12);
            grp_Musteri.Name = "grp_Musteri";
            grp_Musteri.Size = new Size(368, 265);
            grp_Musteri.TabIndex = 0;
            grp_Musteri.TabStop = false;
            grp_Musteri.Text = "Müşteri Ekle";
            // 
            // txt_Adres
            // 
            txt_Adres.Location = new Point(106, 113);
            txt_Adres.Name = "txt_Adres";
            txt_Adres.Size = new Size(125, 27);
            txt_Adres.TabIndex = 2;
            // 
            // txt_Telefon
            // 
            txt_Telefon.Location = new Point(106, 76);
            txt_Telefon.Name = "txt_Telefon";
            txt_Telefon.Size = new Size(125, 27);
            txt_Telefon.TabIndex = 2;
            // 
            // txt_Ad
            // 
            txt_Ad.Location = new Point(106, 40);
            txt_Ad.Name = "txt_Ad";
            txt_Ad.Size = new Size(125, 27);
            txt_Ad.TabIndex = 2;
            // 
            // btn_ekle
            // 
            btn_ekle.Location = new Point(23, 172);
            btn_ekle.Name = "btn_ekle";
            btn_ekle.Size = new Size(208, 29);
            btn_ekle.TabIndex = 1;
            btn_ekle.Text = "Ekle";
            btn_ekle.UseVisualStyleBackColor = true;
            btn_ekle.Click += btn_ekle_Click;
            // 
            // lbl_Adres
            // 
            lbl_Adres.AutoSize = true;
            lbl_Adres.Location = new Point(23, 120);
            lbl_Adres.Name = "lbl_Adres";
            lbl_Adres.Size = new Size(54, 20);
            lbl_Adres.TabIndex = 0;
            lbl_Adres.Text = "Adres :";
            // 
            // lbl_Telefon
            // 
            lbl_Telefon.AutoSize = true;
            lbl_Telefon.Location = new Point(23, 79);
            lbl_Telefon.Name = "lbl_Telefon";
            lbl_Telefon.Size = new Size(65, 20);
            lbl_Telefon.TabIndex = 0;
            lbl_Telefon.Text = "Telefon :";
            // 
            // lbl_ad
            // 
            lbl_ad.AutoSize = true;
            lbl_ad.Location = new Point(23, 43);
            lbl_ad.Name = "lbl_ad";
            lbl_ad.Size = new Size(35, 20);
            lbl_ad.TabIndex = 0;
            lbl_ad.Text = "Ad :";
            // 
            // grp_Hali
            // 
            grp_Hali.Controls.Add(btn_HaliEkle);
            grp_Hali.Controls.Add(dtp_teslimTarihi);
            grp_Hali.Controls.Add(dtp_alimTarihi);
            grp_Hali.Controls.Add(cmb_musteriler);
            grp_Hali.Controls.Add(txt_metrekare);
            grp_Hali.Controls.Add(lbl_teslimtarihi);
            grp_Hali.Controls.Add(lbl_Alımtarihi);
            grp_Hali.Controls.Add(lbl_metrekare);
            grp_Hali.Controls.Add(lbl_musteri);
            grp_Hali.Location = new Point(403, 12);
            grp_Hali.Name = "grp_Hali";
            grp_Hali.Size = new Size(452, 265);
            grp_Hali.TabIndex = 0;
            grp_Hali.TabStop = false;
            grp_Hali.Text = "Halı Ekle";
            // 
            // btn_HaliEkle
            // 
            btn_HaliEkle.Location = new Point(106, 207);
            btn_HaliEkle.Name = "btn_HaliEkle";
            btn_HaliEkle.Size = new Size(264, 29);
            btn_HaliEkle.TabIndex = 6;
            btn_HaliEkle.Text = "Ekle";
            btn_HaliEkle.UseVisualStyleBackColor = true;
            btn_HaliEkle.Click += btn_HaliEkle_Click;
            // 
            // dtp_teslimTarihi
            // 
            dtp_teslimTarihi.Location = new Point(106, 163);
            dtp_teslimTarihi.Name = "dtp_teslimTarihi";
            dtp_teslimTarihi.Size = new Size(264, 27);
            dtp_teslimTarihi.TabIndex = 5;
            // 
            // dtp_alimTarihi
            // 
            dtp_alimTarihi.Location = new Point(106, 115);
            dtp_alimTarihi.Name = "dtp_alimTarihi";
            dtp_alimTarihi.Size = new Size(264, 27);
            dtp_alimTarihi.TabIndex = 4;
            // 
            // cmb_musteriler
            // 
            cmb_musteriler.FormattingEnabled = true;
            cmb_musteriler.Location = new Point(106, 35);
            cmb_musteriler.Name = "cmb_musteriler";
            cmb_musteriler.Size = new Size(125, 28);
            cmb_musteriler.TabIndex = 3;
            // 
            // txt_metrekare
            // 
            txt_metrekare.Location = new Point(106, 76);
            txt_metrekare.Name = "txt_metrekare";
            txt_metrekare.Size = new Size(125, 27);
            txt_metrekare.TabIndex = 2;
            // 
            // lbl_teslimtarihi
            // 
            lbl_teslimtarihi.AutoSize = true;
            lbl_teslimtarihi.Location = new Point(6, 172);
            lbl_teslimtarihi.Name = "lbl_teslimtarihi";
            lbl_teslimtarihi.Size = new Size(90, 20);
            lbl_teslimtarihi.TabIndex = 0;
            lbl_teslimtarihi.Text = "Teslim Tarihi";
            // 
            // lbl_Alımtarihi
            // 
            lbl_Alımtarihi.AutoSize = true;
            lbl_Alımtarihi.Location = new Point(6, 120);
            lbl_Alımtarihi.Name = "lbl_Alımtarihi";
            lbl_Alımtarihi.Size = new Size(82, 20);
            lbl_Alımtarihi.TabIndex = 0;
            lbl_Alımtarihi.Text = "Alım Tarihi:";
            // 
            // lbl_metrekare
            // 
            lbl_metrekare.AutoSize = true;
            lbl_metrekare.Location = new Point(23, 79);
            lbl_metrekare.Name = "lbl_metrekare";
            lbl_metrekare.Size = new Size(79, 20);
            lbl_metrekare.TabIndex = 0;
            lbl_metrekare.Text = "Metrekare:";
            // 
            // lbl_musteri
            // 
            lbl_musteri.AutoSize = true;
            lbl_musteri.Location = new Point(23, 43);
            lbl_musteri.Name = "lbl_musteri";
            lbl_musteri.Size = new Size(61, 20);
            lbl_musteri.TabIndex = 0;
            lbl_musteri.Text = "Müşteri:";
            // 
            // grp_durum
            // 
            grp_durum.Controls.Add(btn_durum);
            grp_durum.Controls.Add(lst_yıkamada);
            grp_durum.Controls.Add(lst_teslim);
            grp_durum.Location = new Point(26, 286);
            grp_durum.Name = "grp_durum";
            grp_durum.Size = new Size(829, 232);
            grp_durum.TabIndex = 1;
            grp_durum.TabStop = false;
            grp_durum.Text = "                  Yıkamada Olan Halılar                                                                                             Teslim Edilen Halılar ";
            // 
            // btn_durum
            // 
            btn_durum.Location = new Point(238, 176);
            btn_durum.Name = "btn_durum";
            btn_durum.Size = new Size(361, 29);
            btn_durum.TabIndex = 1;
            btn_durum.Text = "Durumu Güncelle";
            btn_durum.UseVisualStyleBackColor = true;
            btn_durum.Click += btn_durum_Click;
            // 
            // lst_yıkamada
            // 
            lst_yıkamada.FormattingEnabled = true;
            lst_yıkamada.Location = new Point(10, 26);
            lst_yıkamada.Name = "lst_yıkamada";
            lst_yıkamada.Size = new Size(361, 144);
            lst_yıkamada.TabIndex = 0;
            // 
            // lst_teslim
            // 
            lst_teslim.FormattingEnabled = true;
            lst_teslim.Location = new Point(452, 26);
            lst_teslim.Name = "lst_teslim";
            lst_teslim.Size = new Size(371, 144);
            lst_teslim.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 520);
            Controls.Add(grp_durum);
            Controls.Add(grp_Hali);
            Controls.Add(grp_Musteri);
            Name = "Form1";
            Text = "Hali Yıkama";
            Load += Form1_Load;
            grp_Musteri.ResumeLayout(false);
            grp_Musteri.PerformLayout();
            grp_Hali.ResumeLayout(false);
            grp_Hali.PerformLayout();
            grp_durum.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grp_Musteri;
        private TextBox txt_Adres;
        private TextBox txt_Telefon;
        private TextBox txt_Ad;
        private Button btn_ekle;
        private Label lbl_Adres;
        private Label lbl_Telefon;
        private Label lbl_ad;
        private GroupBox grp_Hali;
        private ComboBox cmb_musteriler;
        private TextBox txt_metrekare;
        private Label lbl_Alımtarihi;
        private Label lbl_metrekare;
        private Label lbl_musteri;
        private DateTimePicker dtp_teslimTarihi;
        private DateTimePicker dtp_alimTarihi;
        private Label lbl_teslimtarihi;
        private GroupBox grp_durum;
        private Button btn_durum;
        private ListBox lst_yıkamada;
        private ListBox lst_teslim;
        private Button btn_HaliEkle;
    }
}
