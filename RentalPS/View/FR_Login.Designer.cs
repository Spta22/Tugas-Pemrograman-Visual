namespace RentalPS
{
    partial class Formlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formlogin));
            textUsername = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textPassword = new TextBox();
            btnLogin = new Button();
            btnBuatakun = new Button();
            pictureLogin = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureLogin).BeginInit();
            SuspendLayout();
            // 
            // textUsername
            // 
            textUsername.BackColor = SystemColors.Window;
            textUsername.Location = new Point(280, 186);
            textUsername.Multiline = true;
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(241, 22);
            textUsername.TabIndex = 0;
            textUsername.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 22F);
            label1.Location = new Point(317, 120);
            label1.Name = "label1";
            label1.Size = new Size(86, 37);
            label1.TabIndex = 1;
            label1.Text = "LOGIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Silver;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(177, 186);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Silver;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(177, 229);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // textPassword
            // 
            textPassword.Location = new Point(280, 232);
            textPassword.Multiline = true;
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(241, 24);
            textPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DarkGray;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Image = (Image)resources.GetObject("btnLogin.Image");
            btnLogin.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogin.Location = new Point(434, 282);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(87, 32);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnBuatakun
            // 
            btnBuatakun.BackColor = Color.DarkGray;
            btnBuatakun.FlatAppearance.BorderSize = 0;
            btnBuatakun.FlatStyle = FlatStyle.Flat;
            btnBuatakun.Image = (Image)resources.GetObject("btnBuatakun.Image");
            btnBuatakun.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuatakun.Location = new Point(177, 282);
            btnBuatakun.Name = "btnBuatakun";
            btnBuatakun.Size = new Size(111, 32);
            btnBuatakun.TabIndex = 8;
            btnBuatakun.Text = "Buat Akun";
            btnBuatakun.UseVisualStyleBackColor = false;
            btnBuatakun.Click += btnBuatakun_Click;
            // 
            // pictureLogin
            // 
            pictureLogin.Image = Properties.Resources.WhatsApp_Image_2025_04_25_at_17_37_56;
            pictureLogin.Location = new Point(2, 2);
            pictureLogin.Name = "pictureLogin";
            pictureLogin.Size = new Size(693, 366);
            pictureLogin.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureLogin.TabIndex = 9;
            pictureLogin.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 25F);
            label4.Location = new Point(177, 22);
            label4.Name = "label4";
            label4.Size = new Size(385, 42);
            label4.TabIndex = 10;
            label4.Text = "Aplikasi Rental Playstation";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 20F);
            label5.Location = new Point(249, 64);
            label5.Name = "label5";
            label5.Size = new Size(233, 34);
            label5.TabIndex = 11;
            label5.Text = "MEIINSYAALLAH PS 5";
            // 
            // Formlogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(692, 363);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnBuatakun);
            Controls.Add(btnLogin);
            Controls.Add(textPassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textUsername);
            Controls.Add(pictureLogin);
            Name = "Formlogin";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)pictureLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textUsername;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textPassword;
        private Button btnLogin;
        private Button btnBuatakun;
        private PictureBox pictureLogin;
        private Label label4;
        private Label label5;
    }
}
