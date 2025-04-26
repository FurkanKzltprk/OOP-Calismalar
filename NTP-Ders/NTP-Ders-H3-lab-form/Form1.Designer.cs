namespace NTP_Ders_H3_lab_form
{
    partial class Form1
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
            this.txt_veri = new System.Windows.Forms.TextBox();
            this.btn_vericek = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.txt_temizveri = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_veri
            // 
            this.txt_veri.Location = new System.Drawing.Point(75, 41);
            this.txt_veri.Multiline = true;
            this.txt_veri.Name = "txt_veri";
            this.txt_veri.Size = new System.Drawing.Size(525, 161);
            this.txt_veri.TabIndex = 0;
            // 
            // btn_vericek
            // 
            this.btn_vericek.Location = new System.Drawing.Point(616, 74);
            this.btn_vericek.Name = "btn_vericek";
            this.btn_vericek.Size = new System.Drawing.Size(159, 93);
            this.btn_vericek.TabIndex = 1;
            this.btn_vericek.Text = "Dosyayı oku";
            this.btn_vericek.UseVisualStyleBackColor = true;
            this.btn_vericek.Click += new System.EventHandler(this.btn_vericek_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(616, 305);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(150, 83);
            this.btn_temizle.TabIndex = 2;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // txt_temizveri
            // 
            this.txt_temizveri.Location = new System.Drawing.Point(75, 283);
            this.txt_temizveri.Multiline = true;
            this.txt_temizveri.Name = "txt_temizveri";
            this.txt_temizveri.Size = new System.Drawing.Size(525, 128);
            this.txt_temizveri.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 514);
            this.Controls.Add(this.txt_temizveri);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_vericek);
            this.Controls.Add(this.txt_veri);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_veri;
        private System.Windows.Forms.Button btn_vericek;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.TextBox txt_temizveri;
    }
}

