namespace NTP_H5_Form_ArabaGaleri
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
            txt_marka = new TextBox();
            txt_model = new TextBox();
            txt_renk = new TextBox();
            lbl_marka = new Label();
            lbl_Model = new Label();
            lbl_renk = new Label();
            btn_ekle = new Button();
            btn_listele = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // txt_marka
            // 
            txt_marka.Location = new Point(68, 18);
            txt_marka.Name = "txt_marka";
            txt_marka.Size = new Size(229, 27);
            txt_marka.TabIndex = 0;
            // 
            // txt_model
            // 
            txt_model.Location = new Point(70, 69);
            txt_model.Name = "txt_model";
            txt_model.Size = new Size(229, 27);
            txt_model.TabIndex = 0;
            // 
            // txt_renk
            // 
            txt_renk.Location = new Point(68, 127);
            txt_renk.Name = "txt_renk";
            txt_renk.Size = new Size(229, 27);
            txt_renk.TabIndex = 0;
            // 
            // lbl_marka
            // 
            lbl_marka.AutoSize = true;
            lbl_marka.Location = new Point(12, 25);
            lbl_marka.Name = "lbl_marka";
            lbl_marka.Size = new Size(50, 20);
            lbl_marka.TabIndex = 1;
            lbl_marka.Text = "Marka";
            // 
            // lbl_Model
            // 
            lbl_Model.AutoSize = true;
            lbl_Model.Location = new Point(12, 76);
            lbl_Model.Name = "lbl_Model";
            lbl_Model.Size = new Size(52, 20);
            lbl_Model.TabIndex = 1;
            lbl_Model.Text = "Model";
            // 
            // lbl_renk
            // 
            lbl_renk.AutoSize = true;
            lbl_renk.Location = new Point(12, 134);
            lbl_renk.Name = "lbl_renk";
            lbl_renk.Size = new Size(41, 20);
            lbl_renk.TabIndex = 1;
            lbl_renk.Text = "Renk";
            // 
            // btn_ekle
            // 
            btn_ekle.Location = new Point(68, 178);
            btn_ekle.Name = "btn_ekle";
            btn_ekle.Size = new Size(231, 29);
            btn_ekle.TabIndex = 2;
            btn_ekle.Text = "Ekle";
            btn_ekle.UseVisualStyleBackColor = true;
            btn_ekle.Click += btn_ekle_Click;
            // 
            // btn_listele
            // 
            btn_listele.Location = new Point(35, 239);
            btn_listele.Name = "btn_listele";
            btn_listele.Size = new Size(313, 29);
            btn_listele.TabIndex = 3;
            btn_listele.Text = "Listele";
            btn_listele.UseVisualStyleBackColor = true;
            btn_listele.Click += btn_listele_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(35, 315);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(301, 204);
            listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 600);
            Controls.Add(listBox1);
            Controls.Add(btn_listele);
            Controls.Add(btn_ekle);
            Controls.Add(lbl_renk);
            Controls.Add(lbl_Model);
            Controls.Add(lbl_marka);
            Controls.Add(txt_renk);
            Controls.Add(txt_model);
            Controls.Add(txt_marka);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_marka;
        private TextBox txt_model;
        private TextBox txt_renk;
        private Label lbl_marka;
        private Label lbl_Model;
        private Label lbl_renk;
        private Button btn_ekle;
        private Button btn_listele;
        private ListBox listBox1;
    }
}
