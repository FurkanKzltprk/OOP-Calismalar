namespace NTP_Ders_H2_Formlab
{
    partial class Form2
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
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.txt_1 = new System.Windows.Forms.TextBox();
            this.btn_donustur = new System.Windows.Forms.Button();
            this.lbl_sonuc = new System.Windows.Forms.Label();
            this.btn_hexa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_0
            // 
            this.btn_0.Location = new System.Drawing.Point(12, 133);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(81, 70);
            this.btn_0.TabIndex = 0;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(120, 133);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(81, 70);
            this.btn_1.TabIndex = 0;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            // 
            // txt_1
            // 
            this.txt_1.Location = new System.Drawing.Point(12, 89);
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(189, 22);
            this.txt_1.TabIndex = 1;
            // 
            // btn_donustur
            // 
            this.btn_donustur.Location = new System.Drawing.Point(253, 46);
            this.btn_donustur.Name = "btn_donustur";
            this.btn_donustur.Size = new System.Drawing.Size(142, 65);
            this.btn_donustur.TabIndex = 2;
            this.btn_donustur.Text = "Dönüştür decimal";
            this.btn_donustur.UseVisualStyleBackColor = true;
            this.btn_donustur.Click += new System.EventHandler(this.btn_donustur_Click);
            // 
            // lbl_sonuc
            // 
            this.lbl_sonuc.AutoSize = true;
            this.lbl_sonuc.Location = new System.Drawing.Point(30, 46);
            this.lbl_sonuc.Name = "lbl_sonuc";
            this.lbl_sonuc.Size = new System.Drawing.Size(95, 16);
            this.lbl_sonuc.TabIndex = 3;
            this.lbl_sonuc.Text = "Decmal Sonuç";
            // 
            // btn_hexa
            // 
            this.btn_hexa.Location = new System.Drawing.Point(253, 140);
            this.btn_hexa.Name = "btn_hexa";
            this.btn_hexa.Size = new System.Drawing.Size(142, 63);
            this.btn_hexa.TabIndex = 4;
            this.btn_hexa.Text = "Dönüştür Hexa";
            this.btn_hexa.UseVisualStyleBackColor = true;
            this.btn_hexa.Click += new System.EventHandler(this.btn_hexa_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 302);
            this.Controls.Add(this.btn_hexa);
            this.Controls.Add(this.lbl_sonuc);
            this.Controls.Add(this.btn_donustur);
            this.Controls.Add(this.txt_1);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_0);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.TextBox txt_1;
        private System.Windows.Forms.Button btn_donustur;
        private System.Windows.Forms.Label lbl_sonuc;
        private System.Windows.Forms.Button btn_hexa;
    }
}