namespace NTP_Ders_2
{
    partial class Frm_Toplama
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
            this.lbl_birincisayi = new System.Windows.Forms.Label();
            this.lbl_ikincisayi = new System.Windows.Forms.Label();
            this.lbl_soncu = new System.Windows.Forms.Label();
            this.txt_birincisayi = new System.Windows.Forms.TextBox();
            this.txt_ikincisayi = new System.Windows.Forms.TextBox();
            this.txt_sonuc = new System.Windows.Forms.TextBox();
            this.btn_toplama = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Toplama = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.Toplama.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_birincisayi
            // 
            this.lbl_birincisayi.AutoSize = true;
            this.lbl_birincisayi.Location = new System.Drawing.Point(64, 45);
            this.lbl_birincisayi.Name = "lbl_birincisayi";
            this.lbl_birincisayi.Size = new System.Drawing.Size(79, 16);
            this.lbl_birincisayi.TabIndex = 0;
            this.lbl_birincisayi.Text = "Birinci Sayi :";
            // 
            // lbl_ikincisayi
            // 
            this.lbl_ikincisayi.AutoSize = true;
            this.lbl_ikincisayi.Location = new System.Drawing.Point(64, 87);
            this.lbl_ikincisayi.Name = "lbl_ikincisayi";
            this.lbl_ikincisayi.Size = new System.Drawing.Size(76, 16);
            this.lbl_ikincisayi.TabIndex = 1;
            this.lbl_ikincisayi.Text = "İkinci Sayi : ";
            // 
            // lbl_soncu
            // 
            this.lbl_soncu.AutoSize = true;
            this.lbl_soncu.Location = new System.Drawing.Point(64, 187);
            this.lbl_soncu.Name = "lbl_soncu";
            this.lbl_soncu.Size = new System.Drawing.Size(51, 16);
            this.lbl_soncu.TabIndex = 2;
            this.lbl_soncu.Text = "Sonuç :";
            // 
            // txt_birincisayi
            // 
            this.txt_birincisayi.Location = new System.Drawing.Point(156, 42);
            this.txt_birincisayi.Name = "txt_birincisayi";
            this.txt_birincisayi.Size = new System.Drawing.Size(127, 22);
            this.txt_birincisayi.TabIndex = 0;
            this.txt_birincisayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_birincisayi_KeyPress);
            // 
            // txt_ikincisayi
            // 
            this.txt_ikincisayi.Location = new System.Drawing.Point(156, 81);
            this.txt_ikincisayi.Name = "txt_ikincisayi";
            this.txt_ikincisayi.Size = new System.Drawing.Size(127, 22);
            this.txt_ikincisayi.TabIndex = 1;
            this.txt_ikincisayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ikincisayi_KeyPress);
            // 
            // txt_sonuc
            // 
            this.txt_sonuc.Enabled = false;
            this.txt_sonuc.Location = new System.Drawing.Point(156, 181);
            this.txt_sonuc.Name = "txt_sonuc";
            this.txt_sonuc.Size = new System.Drawing.Size(127, 22);
            this.txt_sonuc.TabIndex = 3;
            // 
            // btn_toplama
            // 
            this.btn_toplama.Location = new System.Drawing.Point(156, 121);
            this.btn_toplama.Name = "btn_toplama";
            this.btn_toplama.Size = new System.Drawing.Size(127, 40);
            this.btn_toplama.TabIndex = 2;
            this.btn_toplama.Text = "Toplama";
            this.btn_toplama.UseVisualStyleBackColor = true;
            this.btn_toplama.Click += new System.EventHandler(this.btn_toplama_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Toplama);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(365, 308);
            this.tabControl1.TabIndex = 7;
            // 
            // Toplama
            // 
            this.Toplama.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Toplama.Controls.Add(this.txt_birincisayi);
            this.Toplama.Controls.Add(this.btn_toplama);
            this.Toplama.Controls.Add(this.lbl_birincisayi);
            this.Toplama.Controls.Add(this.txt_sonuc);
            this.Toplama.Controls.Add(this.lbl_ikincisayi);
            this.Toplama.Controls.Add(this.txt_ikincisayi);
            this.Toplama.Controls.Add(this.lbl_soncu);
            this.Toplama.Location = new System.Drawing.Point(4, 25);
            this.Toplama.Name = "Toplama";
            this.Toplama.Padding = new System.Windows.Forms.Padding(3);
            this.Toplama.Size = new System.Drawing.Size(357, 279);
            this.Toplama.TabIndex = 0;
            this.Toplama.Text = "Toplama";
            this.Toplama.UseVisualStyleBackColor = true;
            // 
            // Frm_Toplama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 308);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_Toplama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Toplama";
            this.Load += new System.EventHandler(this.Frm_Toplama_Load);
            this.tabControl1.ResumeLayout(false);
            this.Toplama.ResumeLayout(false);
            this.Toplama.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_birincisayi;
        private System.Windows.Forms.Label lbl_ikincisayi;
        private System.Windows.Forms.Label lbl_soncu;
        private System.Windows.Forms.TextBox txt_birincisayi;
        private System.Windows.Forms.TextBox txt_ikincisayi;
        private System.Windows.Forms.TextBox txt_sonuc;
        private System.Windows.Forms.Button btn_toplama;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Toplama;
    }
}