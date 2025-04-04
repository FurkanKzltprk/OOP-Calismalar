namespace NTP_Ders_H4_Form__Gr_
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
            btn_test = new Button();
            txt_boxAd = new TextBox();
            txt_soyad = new TextBox();
            lbl_ad = new Label();
            lbl_soyad = new Label();
            SuspendLayout();
            // 
            // btn_test
            // 
            btn_test.Location = new Point(95, 178);
            btn_test.Name = "btn_test";
            btn_test.Size = new Size(117, 58);
            btn_test.TabIndex = 0;
            btn_test.Text = "Test";
            btn_test.UseVisualStyleBackColor = true;
            btn_test.Click += btn_test_Click;
            // 
            // txt_boxAd
            // 
            txt_boxAd.Location = new Point(95, 46);
            txt_boxAd.Name = "txt_boxAd";
            txt_boxAd.Size = new Size(125, 27);
            txt_boxAd.TabIndex = 1;
            // 
            // txt_soyad
            // 
            txt_soyad.Location = new Point(95, 94);
            txt_soyad.Name = "txt_soyad";
            txt_soyad.Size = new Size(125, 27);
            txt_soyad.TabIndex = 2;
            // 
            // lbl_ad
            // 
            lbl_ad.AutoSize = true;
            lbl_ad.Location = new Point(45, 53);
            lbl_ad.Name = "lbl_ad";
            lbl_ad.Size = new Size(28, 20);
            lbl_ad.TabIndex = 3;
            lbl_ad.Text = "Ad";
            lbl_ad.Click += lbl_ad_Click;
            // 
            // lbl_soyad
            // 
            lbl_soyad.AutoSize = true;
            lbl_soyad.Location = new Point(21, 101);
            lbl_soyad.Name = "lbl_soyad";
            lbl_soyad.Size = new Size(52, 20);
            lbl_soyad.TabIndex = 4;
            lbl_soyad.Text = "SoyAd";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 332);
            Controls.Add(lbl_soyad);
            Controls.Add(lbl_ad);
            Controls.Add(txt_soyad);
            Controls.Add(txt_boxAd);
            Controls.Add(btn_test);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_test;
        private TextBox txt_boxAd;
        private TextBox txt_soyad;
        private Label lbl_ad;
        private Label lbl_soyad;
    }
}
