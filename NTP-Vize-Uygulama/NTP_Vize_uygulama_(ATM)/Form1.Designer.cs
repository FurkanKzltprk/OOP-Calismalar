namespace NTP_Vize_uygulama__ATM_
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
            textBox1 = new TextBox();
            btn_50 = new Button();
            lstDetails = new ListBox();
            btn_100 = new Button();
            btn_10 = new Button();
            btn_20 = new Button();
            btn_200 = new Button();
            btn_paraver = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(126, 27);
            textBox1.TabIndex = 0;
            // 
            // btn_50
            // 
            btn_50.Location = new Point(12, 125);
            btn_50.Name = "btn_50";
            btn_50.Size = new Size(60, 38);
            btn_50.TabIndex = 1;
            btn_50.Text = "50";
            btn_50.UseVisualStyleBackColor = true;
            btn_50.Click += btn_20_Click;
            // 
            // lstDetails
            // 
            lstDetails.FormattingEnabled = true;
            lstDetails.Location = new Point(144, 39);
            lstDetails.Name = "lstDetails";
            lstDetails.Size = new Size(150, 124);
            lstDetails.TabIndex = 2;
            // 
            // btn_100
            // 
            btn_100.Location = new Point(78, 125);
            btn_100.Name = "btn_100";
            btn_100.Size = new Size(60, 38);
            btn_100.TabIndex = 1;
            btn_100.Text = "100";
            btn_100.UseVisualStyleBackColor = true;
            btn_100.Click += btn_20_Click;
            // 
            // btn_10
            // 
            btn_10.Location = new Point(12, 81);
            btn_10.Name = "btn_10";
            btn_10.Size = new Size(60, 38);
            btn_10.TabIndex = 1;
            btn_10.Text = "10";
            btn_10.UseVisualStyleBackColor = true;
            btn_10.Click += btn_20_Click;
            // 
            // btn_20
            // 
            btn_20.Location = new Point(78, 81);
            btn_20.Name = "btn_20";
            btn_20.Size = new Size(60, 38);
            btn_20.TabIndex = 1;
            btn_20.Text = "20";
            btn_20.UseVisualStyleBackColor = true;
            btn_20.Click += btn_20_Click;
            // 
            // btn_200
            // 
            btn_200.Location = new Point(12, 169);
            btn_200.Name = "btn_200";
            btn_200.Size = new Size(60, 38);
            btn_200.TabIndex = 1;
            btn_200.Text = "200";
            btn_200.UseVisualStyleBackColor = true;
            btn_200.Click += btn_20_Click;
            // 
            // btn_paraver
            // 
            btn_paraver.Location = new Point(78, 169);
            btn_paraver.Name = "btn_paraver";
            btn_paraver.Size = new Size(122, 38);
            btn_paraver.TabIndex = 1;
            btn_paraver.Text = "Parayı Ver";
            btn_paraver.UseVisualStyleBackColor = true;
            btn_paraver.Click += btn_paraver_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 236);
            Controls.Add(lstDetails);
            Controls.Add(btn_20);
            Controls.Add(btn_10);
            Controls.Add(btn_paraver);
            Controls.Add(btn_100);
            Controls.Add(btn_200);
            Controls.Add(btn_50);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btn_50;
        private ListBox lstDetails;
        private Button btn_100;
        private Button btn_10;
        private Button btn_20;
        private Button btn_200;
        private Button btn_paraver;
    }
}
