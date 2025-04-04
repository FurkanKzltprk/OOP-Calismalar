namespace NTP_Ders_H2
{
    partial class Frm_TekCiftHesaplama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_tektoplam = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tektoplam = new System.Windows.Forms.TextBox();
            this.txt_cifttoplam = new System.Windows.Forms.TextBox();
            this.txt_geneltoplam = new System.Windows.Forms.TextBox();
            this.lbl_baslangıc = new System.Windows.Forms.Label();
            this.lbl_bitis = new System.Windows.Forms.Label();
            this.txt_baslangıc = new System.Windows.Forms.TextBox();
            this.txt_bitis = new System.Windows.Forms.TextBox();
            this.btn_hesapla = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_hesapla);
            this.groupBox1.Controls.Add(this.txt_bitis);
            this.groupBox1.Controls.Add(this.txt_baslangıc);
            this.groupBox1.Controls.Add(this.lbl_bitis);
            this.groupBox1.Controls.Add(this.lbl_baslangıc);
            this.groupBox1.Location = new System.Drawing.Point(25, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 248);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş Bilgileri";
            // 
            // lbl_tektoplam
            // 
            this.lbl_tektoplam.AutoSize = true;
            this.lbl_tektoplam.Location = new System.Drawing.Point(351, 46);
            this.lbl_tektoplam.Name = "lbl_tektoplam";
            this.lbl_tektoplam.Size = new System.Drawing.Size(81, 16);
            this.lbl_tektoplam.TabIndex = 0;
            this.lbl_tektoplam.Text = "Tek Toplam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Çift Toplam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Genel Toplam";
            // 
            // txt_tektoplam
            // 
            this.txt_tektoplam.Location = new System.Drawing.Point(310, 65);
            this.txt_tektoplam.Name = "txt_tektoplam";
            this.txt_tektoplam.Size = new System.Drawing.Size(164, 22);
            this.txt_tektoplam.TabIndex = 3;
            // 
            // txt_cifttoplam
            // 
            this.txt_cifttoplam.Location = new System.Drawing.Point(310, 167);
            this.txt_cifttoplam.Name = "txt_cifttoplam";
            this.txt_cifttoplam.Size = new System.Drawing.Size(164, 22);
            this.txt_cifttoplam.TabIndex = 3;
            // 
            // txt_geneltoplam
            // 
            this.txt_geneltoplam.Location = new System.Drawing.Point(310, 272);
            this.txt_geneltoplam.Name = "txt_geneltoplam";
            this.txt_geneltoplam.Size = new System.Drawing.Size(164, 22);
            this.txt_geneltoplam.TabIndex = 3;
            // 
            // lbl_baslangıc
            // 
            this.lbl_baslangıc.AutoSize = true;
            this.lbl_baslangıc.Location = new System.Drawing.Point(9, 75);
            this.lbl_baslangıc.Name = "lbl_baslangıc";
            this.lbl_baslangıc.Size = new System.Drawing.Size(67, 16);
            this.lbl_baslangıc.TabIndex = 1;
            this.lbl_baslangıc.Text = "Başlangıç";
            // 
            // lbl_bitis
            // 
            this.lbl_bitis.AutoSize = true;
            this.lbl_bitis.Location = new System.Drawing.Point(44, 121);
            this.lbl_bitis.Name = "lbl_bitis";
            this.lbl_bitis.Size = new System.Drawing.Size(32, 16);
            this.lbl_bitis.TabIndex = 2;
            this.lbl_bitis.Text = "Bitiş";
            // 
            // txt_baslangıc
            // 
            this.txt_baslangıc.Location = new System.Drawing.Point(82, 69);
            this.txt_baslangıc.Name = "txt_baslangıc";
            this.txt_baslangıc.Size = new System.Drawing.Size(101, 22);
            this.txt_baslangıc.TabIndex = 4;
            // 
            // txt_bitis
            // 
            this.txt_bitis.Location = new System.Drawing.Point(82, 115);
            this.txt_bitis.Name = "txt_bitis";
            this.txt_bitis.Size = new System.Drawing.Size(101, 22);
            this.txt_bitis.TabIndex = 5;
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.Location = new System.Drawing.Point(82, 156);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(101, 23);
            this.btn_hesapla.TabIndex = 6;
            this.btn_hesapla.Text = "Hesapla";
            this.btn_hesapla.UseVisualStyleBackColor = true;
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // Frm_TekCiftHesaplama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 314);
            this.Controls.Add(this.txt_geneltoplam);
            this.Controls.Add(this.txt_cifttoplam);
            this.Controls.Add(this.txt_tektoplam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_tektoplam);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_TekCiftHesaplama";
            this.Text = "Sayılar Arası Hesapla";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_bitis;
        private System.Windows.Forms.TextBox txt_baslangıc;
        private System.Windows.Forms.Label lbl_bitis;
        private System.Windows.Forms.Label lbl_baslangıc;
        private System.Windows.Forms.Label lbl_tektoplam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tektoplam;
        private System.Windows.Forms.TextBox txt_cifttoplam;
        private System.Windows.Forms.TextBox txt_geneltoplam;
        private System.Windows.Forms.Button btn_hesapla;
    }
}