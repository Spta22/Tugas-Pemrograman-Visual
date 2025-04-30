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
            label3 = new Label();
            txtPassword = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtUsername = new TextBox();
            label4 = new Label();
            txtNama = new TextBox();
            label5 = new Label();
            cmboRole = new ComboBox();
            btndaftar = new Button();
            btnkembali = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(182, 131);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 11;
            label3.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(291, 131);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(241, 25);
            txtPassword.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(182, 94);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 9;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 25F);
            label1.Location = new Point(319, 31);
            label1.Name = "label1";
            label1.Size = new Size(165, 42);
            label1.TabIndex = 8;
            label1.Text = "BUAT AKUN";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(291, 92);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(241, 27);
            txtUsername.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.Location = new Point(182, 162);
            label4.Name = "label4";
            label4.Size = new Size(46, 25);
            label4.TabIndex = 15;
            label4.Text = "Role";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(291, 193);
            txtNama.Multiline = true;
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(241, 25);
            txtNama.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F);
            label5.Location = new Point(182, 193);
            label5.Name = "label5";
            label5.Size = new Size(59, 25);
            label5.TabIndex = 17;
            label5.Text = "Nama";
            // 
            // cmboRole
            // 
            cmboRole.FormattingEnabled = true;
            cmboRole.Items.AddRange(new object[] { "Admin", "Users" });
            cmboRole.Location = new Point(291, 164);
            cmboRole.Name = "cmboRole";
            cmboRole.Size = new Size(121, 23);
            cmboRole.TabIndex = 18;
            // 
            // btndaftar
            // 
            btndaftar.Location = new Point(445, 242);
            btndaftar.Name = "btndaftar";
            btndaftar.Size = new Size(87, 32);
            btndaftar.TabIndex = 19;
            btndaftar.Text = "Daftar";
            btndaftar.UseVisualStyleBackColor = true;
            btndaftar.Click += btndaftar_Click;
            // 
            // btnkembali
            // 
            btnkembali.Location = new Point(182, 242);
            btnkembali.Name = "btnkembali";
            btnkembali.Size = new Size(87, 32);
            btnkembali.TabIndex = 20;
            btnkembali.Text = "Kembali";
            btnkembali.UseVisualStyleBackColor = true;
            btnkembali.Click += btnkembali_Click;
            // 
            // FR_Buatakun
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 327);
            Controls.Add(btnkembali);
            Controls.Add(btndaftar);
            Controls.Add(cmboRole);
            Controls.Add(label5);
            Controls.Add(txtNama);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUsername);
            Name = "FR_Buatakun";
            Text = "BuatAkun";
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
        private Label label4;
        private TextBox txtNama;
        private Label label5;
        private ComboBox cmboRole;
        private Button btndaftar;
        private Button btnkembali;
    }
}