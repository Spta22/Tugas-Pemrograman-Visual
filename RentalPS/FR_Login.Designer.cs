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
            textUsername = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textPassword = new TextBox();
            btnLogin = new Button();
            btnBuatakun = new Button();
            SuspendLayout();
            // 
            // textUsername
            // 
            textUsername.Location = new Point(224, 127);
            textUsername.Multiline = true;
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(241, 37);
            textUsername.TabIndex = 0;
            textUsername.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 25F);
            label1.Location = new Point(277, 43);
            label1.Name = "label1";
            label1.Size = new Size(96, 42);
            label1.TabIndex = 1;
            label1.Text = "LOGIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(115, 127);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(115, 193);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // textPassword
            // 
            textPassword.Location = new Point(224, 193);
            textPassword.Multiline = true;
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(241, 37);
            textPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(378, 256);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(87, 32);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnBuatakun
            // 
            btnBuatakun.Location = new Point(124, 256);
            btnBuatakun.Name = "btnBuatakun";
            btnBuatakun.Size = new Size(111, 32);
            btnBuatakun.TabIndex = 8;
            btnBuatakun.Text = "Buat Akun";
            btnBuatakun.UseVisualStyleBackColor = true;
            btnBuatakun.Click += btnBuatakun_Click;
            // 
            // Formlogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 450);
            Controls.Add(btnBuatakun);
            Controls.Add(btnLogin);
            Controls.Add(label3);
            Controls.Add(textPassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textUsername);
            Name = "Formlogin";
            Text = "Form1";
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
    }
}
