namespace NTP_Vize_s3
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
            lbl_ort = new Label();
            lbl_top = new Label();
            txtBox = new TextBox();
            btn_topla = new Button();
            SuspendLayout();
            // 
            // lbl_ort
            // 
            lbl_ort.AutoSize = true;
            lbl_ort.Location = new Point(40, 88);
            lbl_ort.Name = "lbl_ort";
            lbl_ort.Size = new Size(74, 20);
            lbl_ort.TabIndex = 0;
            lbl_ort.Text = "Ortalama:";
            // 
            // lbl_top
            // 
            lbl_top.AutoSize = true;
            lbl_top.Location = new Point(40, 125);
            lbl_top.Name = "lbl_top";
            lbl_top.Size = new Size(62, 20);
            lbl_top.TabIndex = 1;
            lbl_top.Text = "Toplam:";
            // 
            // txtBox
            // 
            txtBox.Location = new Point(40, 46);
            txtBox.Name = "txtBox";
            txtBox.Size = new Size(125, 27);
            txtBox.TabIndex = 2;
            // 
            // btn_topla
            // 
            btn_topla.Location = new Point(192, 46);
            btn_topla.Name = "btn_topla";
            btn_topla.Size = new Size(94, 29);
            btn_topla.TabIndex = 3;
            btn_topla.Text = "TOPLA";
            btn_topla.UseVisualStyleBackColor = true;
            btn_topla.Click += btn_topla_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 264);
            Controls.Add(btn_topla);
            Controls.Add(txtBox);
            Controls.Add(lbl_top);
            Controls.Add(lbl_ort);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_ort;
        private Label lbl_top;
        private TextBox txtBox;
        private Button btn_topla;
    }
}
