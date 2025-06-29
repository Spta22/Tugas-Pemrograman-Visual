namespace RentalPS
{
    partial class FR_Daftarharga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FR_Daftarharga));
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGray;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(386, 208);
            button1.Name = "button1";
            button1.Size = new Size(104, 33);
            button1.TabIndex = 32;
            button1.Text = "Kembali";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Arial Black", 15F);
            label3.Location = new Point(194, 9);
            label3.Name = "label3";
            label3.Size = new Size(190, 28);
            label3.TabIndex = 33;
            label3.Text = "DAFTAR HARGA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(112, 47);
            label4.Name = "label4";
            label4.Size = new Size(122, 30);
            label4.TabIndex = 34;
            label4.Text = "1 Jam : 5000";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(112, 90);
            label5.Name = "label5";
            label5.Size = new Size(122, 30);
            label5.TabIndex = 35;
            label5.Text = "2 Jam : 9000";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(112, 137);
            label6.Name = "label6";
            label6.Size = new Size(133, 30);
            label6.TabIndex = 36;
            label6.Text = "3 Jam : 14000";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.BorderStyle = BorderStyle.Fixed3D;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Segoe UI", 15F);
            label8.Location = new Point(112, 177);
            label8.Name = "label8";
            label8.Size = new Size(133, 30);
            label8.TabIndex = 38;
            label8.Text = "4 Jam : 17000";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.BorderStyle = BorderStyle.Fixed3D;
            label9.FlatStyle = FlatStyle.Flat;
            label9.Font = new Font("Segoe UI", 15F);
            label9.Location = new Point(112, 221);
            label9.Name = "label9";
            label9.Size = new Size(133, 30);
            label9.TabIndex = 39;
            label9.Text = "5 Jam : 20000";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(356, 90);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(166, 96);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 44;
            pictureBox2.TabStop = false;
            // 
            // FR_Daftarharga
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(619, 300);
            Controls.Add(pictureBox2);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Name = "FR_Daftarharga";
            Text = "daftarharga";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}