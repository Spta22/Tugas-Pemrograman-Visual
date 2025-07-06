namespace RentalPS
{
    partial class FR_Buatakun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FR_Buatakun));
            label3 = new Label();
            txtPassword = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtUsername = new TextBox();
            txtNama = new TextBox();
            label5 = new Label();
            btndaftar = new Button();
            btnkembali = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Silver;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(133, 131);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 11;
            label3.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(253, 131);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(241, 25);
            txtPassword.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Silver;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(133, 94);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 9;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 25F);
            label1.Location = new Point(264, 23);
            label1.Name = "label1";
            label1.Size = new Size(165, 42);
            label1.TabIndex = 8;
            label1.Text = "BUAT AKUN";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(253, 94);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(241, 27);
            txtUsername.TabIndex = 7;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(253, 175);
            txtNama.Multiline = true;
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(241, 25);
            txtNama.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Silver;
            label5.Font = new Font("Segoe UI", 13F);
            label5.Location = new Point(133, 175);
            label5.Name = "label5";
            label5.Size = new Size(59, 25);
            label5.TabIndex = 17;
            label5.Text = "Nama";
            // 
            // btndaftar
            // 
            btndaftar.BackColor = Color.DarkGray;
            btndaftar.FlatAppearance.BorderSize = 0;
            btndaftar.FlatStyle = FlatStyle.Flat;
            btndaftar.Image = (Image)resources.GetObject("btndaftar.Image");
            btndaftar.ImageAlign = ContentAlignment.MiddleLeft;
            btndaftar.Location = new Point(397, 242);
            btndaftar.Name = "btndaftar";
            btndaftar.Size = new Size(97, 32);
            btndaftar.TabIndex = 19;
            btndaftar.Text = "Daftar";
            btndaftar.UseVisualStyleBackColor = false;
            btndaftar.Click += btndaftar_Click;
            // 
            // btnkembali
            // 
            btnkembali.BackColor = Color.DarkGray;
            btnkembali.FlatAppearance.BorderSize = 0;
            btnkembali.FlatStyle = FlatStyle.Flat;
            btnkembali.Image = (Image)resources.GetObject("btnkembali.Image");
            btnkembali.ImageAlign = ContentAlignment.MiddleLeft;
            btnkembali.Location = new Point(133, 242);
            btnkembali.Name = "btnkembali";
            btnkembali.Size = new Size(108, 32);
            btnkembali.TabIndex = 20;
            btnkembali.Text = "Kembali";
            btnkembali.UseVisualStyleBackColor = false;
            btnkembali.Click += btnkembali_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(655, 329);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // FR_Buatakun
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 327);
            Controls.Add(btnkembali);
            Controls.Add(btndaftar);
            Controls.Add(label5);
            Controls.Add(txtNama);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUsername);
            Controls.Add(pictureBox1);
            Name = "FR_Buatakun";
            Text = "BuatAkun";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private TextBox txtPassword;
        private Label label2;
        private Label label1;
        private TextBox txtUsername;
        private TextBox textBox4;
        private TextBox txtNama;
        private Label label5;
        private Button btndaftar;
        private Button btnkembali;
        private PictureBox pictureBox1;
    }
}