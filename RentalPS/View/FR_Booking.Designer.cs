namespace RentalPS
{
    partial class FR_Booking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FR_Booking));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textNama = new TextBox();
            textTelepon = new TextBox();
            comboMeja = new ComboBox();
            label6 = new Label();
            dateTanggal = new DateTimePicker();
            button1 = new Button();
            btnkembali = new Button();
            jamMulai = new DateTimePicker();
            jamSelesai = new DateTimePicker();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(29, 35);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 0;
            label1.Text = "Nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(29, 91);
            label2.Name = "label2";
            label2.Size = new Size(63, 21);
            label2.TabIndex = 1;
            label2.Text = "Telepon";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(29, 145);
            label3.Name = "label3";
            label3.Size = new Size(44, 21);
            label3.TabIndex = 2;
            label3.Text = "Meja";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(412, 37);
            label4.Name = "label4";
            label4.Size = new Size(63, 21);
            label4.TabIndex = 3;
            label4.Text = "Tanggal";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(437, 91);
            label5.Name = "label5";
            label5.Size = new Size(38, 21);
            label5.TabIndex = 4;
            label5.Text = "Jam";
            // 
            // textNama
            // 
            textNama.Location = new Point(107, 37);
            textNama.Multiline = true;
            textNama.Name = "textNama";
            textNama.Size = new Size(179, 23);
            textNama.TabIndex = 5;
            // 
            // textTelepon
            // 
            textTelepon.Location = new Point(107, 91);
            textTelepon.Multiline = true;
            textTelepon.Name = "textTelepon";
            textTelepon.Size = new Size(179, 21);
            textTelepon.TabIndex = 6;
            // 
            // comboMeja
            // 
            comboMeja.FormattingEnabled = true;
            comboMeja.Items.AddRange(new object[] { "Meja 1", "Meja 2", "Meja 3", "Meja 4", "Meja 5", "Meja 6" });
            comboMeja.Location = new Point(107, 145);
            comboMeja.Name = "comboMeja";
            comboMeja.Size = new Size(92, 23);
            comboMeja.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(560, 91);
            label6.Name = "label6";
            label6.Size = new Size(16, 21);
            label6.TabIndex = 10;
            label6.Text = "-";
            // 
            // dateTanggal
            // 
            dateTanggal.Format = DateTimePickerFormat.Short;
            dateTanggal.Location = new Point(481, 37);
            dateTanggal.Name = "dateTanggal";
            dateTanggal.Size = new Size(140, 23);
            dateTanggal.TabIndex = 11;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(532, 145);
            button1.Name = "button1";
            button1.Size = new Size(102, 27);
            button1.TabIndex = 12;
            button1.Text = "Booking";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnkembali
            // 
            btnkembali.BackColor = Color.DarkGray;
            btnkembali.FlatAppearance.BorderSize = 0;
            btnkembali.FlatStyle = FlatStyle.Flat;
            btnkembali.Image = (Image)resources.GetObject("btnkembali.Image");
            btnkembali.ImageAlign = ContentAlignment.MiddleLeft;
            btnkembali.Location = new Point(29, 196);
            btnkembali.Name = "btnkembali";
            btnkembali.Size = new Size(100, 29);
            btnkembali.TabIndex = 21;
            btnkembali.Text = "Kembali";
            btnkembali.UseVisualStyleBackColor = false;
            btnkembali.Click += btnkembali_Click;
            // 
            // jamMulai
            // 
            jamMulai.Format = DateTimePickerFormat.Time;
            jamMulai.Location = new Point(483, 91);
            jamMulai.Name = "jamMulai";
            jamMulai.Size = new Size(71, 23);
            jamMulai.TabIndex = 22;
            // 
            // jamSelesai
            // 
            jamSelesai.Format = DateTimePickerFormat.Time;
            jamSelesai.Location = new Point(582, 91);
            jamSelesai.Name = "jamSelesai";
            jamSelesai.Size = new Size(71, 23);
            jamSelesai.TabIndex = 23;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGray;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(532, 145);
            button2.Name = "button2";
            button2.Size = new Size(102, 28);
            button2.TabIndex = 24;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Gray;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(252, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 201);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // FR_Booking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(697, 272);
            Controls.Add(button2);
            Controls.Add(jamSelesai);
            Controls.Add(jamMulai);
            Controls.Add(btnkembali);
            Controls.Add(button1);
            Controls.Add(dateTanggal);
            Controls.Add(label6);
            Controls.Add(comboMeja);
            Controls.Add(textTelepon);
            Controls.Add(textNama);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "FR_Booking";
            Text = "booking";
            Load += FR_Booking_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textNama;
        private TextBox textTelepon;
        private ComboBox comboMeja;
        private Label label6;
        private DateTimePicker dateTanggal;
        private Button button1;
        private Button btnkembali;
        private DateTimePicker jamMulai;
        private DateTimePicker jamSelesai;
        private Button button2;
        private PictureBox pictureBox1;
    }
}