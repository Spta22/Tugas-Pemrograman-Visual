namespace RentalPS
{
    partial class FR_Promo
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15F);
            textBox1.Location = new Point(23, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(304, 34);
            textBox1.TabIndex = 4;
            textBox1.Text = "Diskon 10% pada jam 14:00-16:00 ";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 15F);
            textBox2.Location = new Point(23, 201);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(304, 34);
            textBox2.TabIndex = 5;
            textBox2.Text = "Diskon 80% pada jam 02:00-02:30 ";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 15F);
            textBox3.Location = new Point(23, 140);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(304, 34);
            textBox3.TabIndex = 6;
            textBox3.Text = "Diskon 30% pada jam 21:00-22:00 ";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 15F);
            textBox4.Location = new Point(23, 89);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(304, 34);
            textBox4.TabIndex = 7;
            textBox4.Text = "Diskon 15% pada jam 18:00-19:00 ";
            // 
            // button1
            // 
            button1.Location = new Point(423, 109);
            button1.Name = "button1";
            button1.Size = new Size(119, 44);
            button1.TabIndex = 13;
            button1.Text = "Kembali";
            button1.UseVisualStyleBackColor = true;
            // 
            // promo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 280);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "promo";
            Text = "promo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
    }
}