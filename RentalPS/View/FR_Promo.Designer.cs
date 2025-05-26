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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FR_Promo));
            button1 = new Button();
            label1 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGray;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(268, 213);
            button1.Name = "button1";
            button1.Size = new Size(104, 34);
            button1.TabIndex = 13;
            button1.Text = "Kembali";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gray;
            label1.Enabled = false;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(176, 79);
            label1.Name = "label1";
            label1.Size = new Size(289, 28);
            label1.TabIndex = 14;
            label1.Text = "Diskon 1000 jika main 3 jam";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI Black", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(251, 20);
            label4.Name = "label4";
            label4.Size = new Size(151, 46);
            label4.TabIndex = 19;
            label4.Text = "PROMO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Gray;
            label6.Enabled = false;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(174, 160);
            label6.Name = "label6";
            label6.Size = new Size(291, 28);
            label6.TabIndex = 21;
            label6.Text = "Diskon 3000 jika main 5 jam";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Gray;
            label7.Enabled = false;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(176, 119);
            label7.Name = "label7";
            label7.Size = new Size(291, 28);
            label7.TabIndex = 22;
            label7.Text = "Diskon 2000 jika main 4 jam";
            // 
            // FR_Promo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(629, 280);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "FR_Promo";
            Text = "promo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label1;
        private Label label4;
        private Label label6;
        private Label label7;
    }
}