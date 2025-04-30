namespace RentalPS
{
    partial class FR_Dashboard
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(339, 54);
            button1.Name = "button1";
            button1.Size = new Size(81, 33);
            button1.TabIndex = 0;
            button1.Text = "Booking";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(328, 151);
            button2.Name = "button2";
            button2.Size = new Size(107, 33);
            button2.TabIndex = 1;
            button2.Text = "Daftar Harga";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(319, 199);
            button3.Name = "button3";
            button3.Size = new Size(127, 33);
            button3.TabIndex = 2;
            button3.Text = " Kontak WA Admin";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(339, 252);
            button4.Name = "button4";
            button4.Size = new Size(81, 33);
            button4.TabIndex = 3;
            button4.Text = "Kembali";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 25F);
            label1.Location = new Point(290, 9);
            label1.Name = "label1";
            label1.Size = new Size(183, 42);
            label1.TabIndex = 4;
            label1.Text = "DASHBOARD";
            // 
            // button5
            // 
            button5.Location = new Point(339, 101);
            button5.Name = "button5";
            button5.Size = new Size(81, 33);
            button5.TabIndex = 5;
            button5.Text = "Promo";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(452, 54);
            button6.Name = "button6";
            button6.Size = new Size(109, 33);
            button6.TabIndex = 6;
            button6.Text = "Data Booking";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // FR_Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 310);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FR_Dashboard";
            Text = "Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Button button5;
        private Button button6;
    }
}