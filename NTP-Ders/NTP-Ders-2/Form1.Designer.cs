namespace NTP_Ders_2
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
            this.btn_topla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_birincisayi = new System.Windows.Forms.TextBox();
            this.txt_ikincisayi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_topla
            // 
            this.btn_topla.BackColor = System.Drawing.Color.Black;
            this.btn_topla.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_topla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_topla.ForeColor = System.Drawing.Color.Lime;
            this.btn_topla.Location = new System.Drawing.Point(0, 140);
            this.btn_topla.Name = "btn_topla";
            this.btn_topla.Size = new System.Drawing.Size(346, 193);
            this.btn_topla.TabIndex = 0;
            this.btn_topla.Text = "TOPLA";
            this.btn_topla.UseVisualStyleBackColor = false;
            this.btn_topla.Click += new System.EventHandler(this.btn_topla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(11, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Birinci sayı :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(7, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "İkinci sayı : ";
            // 
            // txt_birincisayi
            // 
            this.txt_birincisayi.Location = new System.Drawing.Point(167, 35);
            this.txt_birincisayi.Name = "txt_birincisayi";
            this.txt_birincisayi.Size = new System.Drawing.Size(161, 22);
            this.txt_birincisayi.TabIndex = 4;
            // 
            // txt_ikincisayi
            // 
            this.txt_ikincisayi.Location = new System.Drawing.Point(167, 92);
            this.txt_ikincisayi.Name = "txt_ikincisayi";
            this.txt_ikincisayi.Size = new System.Drawing.Size(162, 22);
            this.txt_ikincisayi.TabIndex = 5;
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_topla;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(346, 333);
            this.Controls.Add(this.txt_ikincisayi);
            this.Controls.Add(this.txt_birincisayi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_topla);
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "ilk toplama işlemi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_topla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_birincisayi;
        private System.Windows.Forms.TextBox txt_ikincisayi;
    }
}

