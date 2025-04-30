namespace RentalPS
{
    partial class FR_Kontakwa
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
            linkLabel1 = new LinkLabel();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F);
            linkLabel1.Location = new Point(233, 132);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(228, 21);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "https://wa.me/6281654902946";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15F);
            textBox1.Location = new Point(254, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 34);
            textBox1.TabIndex = 1;
            textBox1.Text = "Kontak Wa Admin";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.Location = new Point(295, 182);
            button1.Name = "button1";
            button1.Size = new Size(106, 35);
            button1.TabIndex = 14;
            button1.Text = "Kembali";
            button1.UseVisualStyleBackColor = true;
            // 
            // FR_Kontakwa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 266);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(linkLabel1);
            Name = "FR_Kontakwa";
            Text = "kontakwa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private TextBox textBox1;
        private Button button1;
    }
}