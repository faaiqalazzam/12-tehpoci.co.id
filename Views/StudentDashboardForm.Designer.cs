namespace Project_KLP_12
{
    partial class StudentDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentDashboardForm));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            btnLogout = new Button();
            btnMenuKalender = new Button();
            btnMenuAbsensi = new Button();
            btnMenuNilai = new Button();
            btnMenuJadwal = new Button();
            btnMenuDashboard = new Button();
            textBox1 = new TextBox();
            userName1 = new TextBox();
            lblNamaSiswa = new TextBox();
            button8 = new Button();
            lblNilaiRataRata = new TextBox();
            lblPoinSiswa = new TextBox();
            button7 = new Button();
            lblPersenKehadiran = new TextBox();
            button9 = new Button();
            pictureBox1 = new PictureBox();
            lblKelasSiswa = new TextBox();
            panel2 = new Panel();
            textBox8 = new TextBox();
            panel3 = new Panel();
            textBox9 = new TextBox();
            dgvKelasHariIni = new DataGridView();
            panel4 = new Panel();
            textBox10 = new TextBox();
            panel5 = new Panel();
            textBox11 = new TextBox();
            dgvDaftarKursus = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKelasHariIni).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDaftarKursus).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnMenuKalender);
            panel1.Controls.Add(btnMenuAbsensi);
            panel1.Controls.Add(btnMenuNilai);
            panel1.Controls.Add(btnMenuJadwal);
            panel1.Controls.Add(btnMenuDashboard);
            panel1.Location = new Point(-2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(112, 453);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Maroon;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(14, 18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(82, 33);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // btnLogout
            // 
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Trebuchet MS", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.ControlLightLight;
            btnLogout.Location = new Point(27, 401);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(85, 36);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "Log Out";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += button5_Click;
            // 
            // btnMenuKalender
            // 
            btnMenuKalender.FlatAppearance.BorderSize = 0;
            btnMenuKalender.FlatStyle = FlatStyle.Flat;
            btnMenuKalender.Font = new Font("Trebuchet MS", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenuKalender.ForeColor = SystemColors.ControlLightLight;
            btnMenuKalender.Location = new Point(24, 228);
            btnMenuKalender.Name = "btnMenuKalender";
            btnMenuKalender.Size = new Size(85, 36);
            btnMenuKalender.TabIndex = 8;
            btnMenuKalender.Text = "Kalender";
            btnMenuKalender.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuKalender.UseVisualStyleBackColor = true;
            btnMenuKalender.Click += button6_Click;
            // 
            // btnMenuAbsensi
            // 
            btnMenuAbsensi.FlatAppearance.BorderSize = 0;
            btnMenuAbsensi.FlatStyle = FlatStyle.Flat;
            btnMenuAbsensi.Font = new Font("Trebuchet MS", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenuAbsensi.ForeColor = SystemColors.ControlLightLight;
            btnMenuAbsensi.Location = new Point(24, 186);
            btnMenuAbsensi.Name = "btnMenuAbsensi";
            btnMenuAbsensi.Size = new Size(85, 36);
            btnMenuAbsensi.TabIndex = 5;
            btnMenuAbsensi.Text = "Absensi";
            btnMenuAbsensi.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuAbsensi.UseVisualStyleBackColor = true;
            // 
            // btnMenuNilai
            // 
            btnMenuNilai.FlatAppearance.BorderSize = 0;
            btnMenuNilai.FlatStyle = FlatStyle.Flat;
            btnMenuNilai.Font = new Font("Trebuchet MS", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenuNilai.ForeColor = SystemColors.ControlLightLight;
            btnMenuNilai.Location = new Point(24, 144);
            btnMenuNilai.Name = "btnMenuNilai";
            btnMenuNilai.Size = new Size(85, 36);
            btnMenuNilai.TabIndex = 4;
            btnMenuNilai.Text = "Nilai";
            btnMenuNilai.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuNilai.UseVisualStyleBackColor = true;
            // 
            // btnMenuJadwal
            // 
            btnMenuJadwal.FlatAppearance.BorderSize = 0;
            btnMenuJadwal.FlatStyle = FlatStyle.Flat;
            btnMenuJadwal.Font = new Font("Trebuchet MS", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenuJadwal.ForeColor = SystemColors.ControlLightLight;
            btnMenuJadwal.Location = new Point(24, 102);
            btnMenuJadwal.Name = "btnMenuJadwal";
            btnMenuJadwal.Size = new Size(85, 36);
            btnMenuJadwal.TabIndex = 3;
            btnMenuJadwal.Text = "PoinJiwa";
            btnMenuJadwal.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuJadwal.UseVisualStyleBackColor = true;
            // 
            // btnMenuDashboard
            // 
            btnMenuDashboard.FlatAppearance.BorderSize = 0;
            btnMenuDashboard.FlatStyle = FlatStyle.Flat;
            btnMenuDashboard.Font = new Font("Trebuchet MS", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenuDashboard.ForeColor = SystemColors.ControlLightLight;
            btnMenuDashboard.Location = new Point(24, 60);
            btnMenuDashboard.Name = "btnMenuDashboard";
            btnMenuDashboard.Size = new Size(85, 36);
            btnMenuDashboard.TabIndex = 2;
            btnMenuDashboard.Text = "Dashboard";
            btnMenuDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuDashboard.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(132, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 16);
            textBox1.TabIndex = 1;
            textBox1.Text = "Selamat Datang, ";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // userName1
            // 
            userName1.BackColor = SystemColors.Control;
            userName1.BorderStyle = BorderStyle.None;
            userName1.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userName1.Location = new Point(238, 36);
            userName1.Name = "userName1";
            userName1.Size = new Size(100, 16);
            userName1.TabIndex = 2;
            userName1.Text = "username";
            userName1.TextChanged += textBox2_TextChanged;
            // 
            // lblNamaSiswa
            // 
            lblNamaSiswa.BackColor = SystemColors.Control;
            lblNamaSiswa.BorderStyle = BorderStyle.None;
            lblNamaSiswa.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNamaSiswa.Location = new Point(643, 22);
            lblNamaSiswa.Name = "lblNamaSiswa";
            lblNamaSiswa.Size = new Size(100, 16);
            lblNamaSiswa.TabIndex = 3;
            lblNamaSiswa.Text = "username";
            lblNamaSiswa.TextAlign = HorizontalAlignment.Right;
            lblNamaSiswa.TextChanged += textBox3_TextChanged;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(64, 0, 0);
            button8.BackgroundImageLayout = ImageLayout.None;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Trebuchet MS", 8.75F);
            button8.ForeColor = SystemColors.ControlLightLight;
            button8.Location = new Point(132, 69);
            button8.Name = "button8";
            button8.Size = new Size(146, 89);
            button8.TabIndex = 8;
            button8.Text = "Nilai Rata-Rata";
            button8.TextAlign = ContentAlignment.TopLeft;
            button8.UseVisualStyleBackColor = false;
            // 
            // lblNilaiRataRata
            // 
            lblNilaiRataRata.BackColor = Color.FromArgb(64, 0, 0);
            lblNilaiRataRata.BorderStyle = BorderStyle.None;
            lblNilaiRataRata.Font = new Font("Yu Gothic", 18.75F, FontStyle.Bold);
            lblNilaiRataRata.ForeColor = SystemColors.Info;
            lblNilaiRataRata.Location = new Point(142, 103);
            lblNilaiRataRata.Name = "lblNilaiRataRata";
            lblNilaiRataRata.Size = new Size(56, 41);
            lblNilaiRataRata.TabIndex = 9;
            lblNilaiRataRata.Text = "85,6";
            lblNilaiRataRata.TextChanged += lblNilaiRataRata_TextChanged;
            // 
            // lblPoinSiswa
            // 
            lblPoinSiswa.BackColor = Color.FromArgb(64, 0, 0);
            lblPoinSiswa.BorderStyle = BorderStyle.None;
            lblPoinSiswa.Font = new Font("Yu Gothic", 18.75F, FontStyle.Bold);
            lblPoinSiswa.ForeColor = SystemColors.Info;
            lblPoinSiswa.Location = new Point(303, 103);
            lblPoinSiswa.Name = "lblPoinSiswa";
            lblPoinSiswa.Size = new Size(56, 41);
            lblPoinSiswa.TabIndex = 11;
            lblPoinSiswa.Text = "761";
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(64, 0, 0);
            button7.BackgroundImageLayout = ImageLayout.None;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Trebuchet MS", 8.75F);
            button7.ForeColor = SystemColors.ControlLightLight;
            button7.Location = new Point(293, 69);
            button7.Name = "button7";
            button7.Size = new Size(146, 89);
            button7.TabIndex = 10;
            button7.Text = "Poin Jiwa";
            button7.TextAlign = ContentAlignment.TopLeft;
            button7.UseVisualStyleBackColor = false;
            // 
            // lblPersenKehadiran
            // 
            lblPersenKehadiran.BackColor = Color.FromArgb(64, 0, 0);
            lblPersenKehadiran.BorderStyle = BorderStyle.None;
            lblPersenKehadiran.Font = new Font("Yu Gothic", 18.75F, FontStyle.Bold);
            lblPersenKehadiran.ForeColor = SystemColors.Info;
            lblPersenKehadiran.Location = new Point(464, 103);
            lblPersenKehadiran.Name = "lblPersenKehadiran";
            lblPersenKehadiran.Size = new Size(80, 41);
            lblPersenKehadiran.TabIndex = 13;
            lblPersenKehadiran.Text = "99.1%";
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(64, 0, 0);
            button9.BackgroundImageLayout = ImageLayout.None;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Trebuchet MS", 8.75F);
            button9.ForeColor = SystemColors.ControlLightLight;
            button9.Location = new Point(454, 69);
            button9.Name = "button9";
            button9.Size = new Size(146, 89);
            button9.TabIndex = 12;
            button9.Text = "Kehadiran";
            button9.TextAlign = ContentAlignment.TopLeft;
            button9.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.School_Of_Digital_Era___3_;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(758, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblKelasSiswa
            // 
            lblKelasSiswa.BackColor = SystemColors.Control;
            lblKelasSiswa.BorderStyle = BorderStyle.None;
            lblKelasSiswa.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKelasSiswa.Location = new Point(643, 36);
            lblKelasSiswa.Name = "lblKelasSiswa";
            lblKelasSiswa.Size = new Size(100, 16);
            lblKelasSiswa.TabIndex = 17;
            lblKelasSiswa.Text = "XI RPL 2";
            lblKelasSiswa.TextAlign = HorizontalAlignment.Right;
            lblKelasSiswa.TextChanged += textBox7_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(textBox8);
            panel2.Location = new Point(616, 69);
            panel2.Name = "panel2";
            panel2.Size = new Size(172, 207);
            panel2.TabIndex = 18;
            // 
            // textBox8
            // 
            textBox8.BackColor = SystemColors.ControlLightLight;
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox8.Location = new Point(12, 4);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 16);
            textBox8.TabIndex = 19;
            textBox8.Text = "Kalender";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.Controls.Add(textBox9);
            panel3.Location = new Point(616, 293);
            panel3.Name = "panel3";
            panel3.Size = new Size(172, 145);
            panel3.TabIndex = 20;
            // 
            // textBox9
            // 
            textBox9.BackColor = SystemColors.ControlLightLight;
            textBox9.BorderStyle = BorderStyle.None;
            textBox9.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox9.Location = new Point(12, 4);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(100, 16);
            textBox9.TabIndex = 20;
            textBox9.Text = "Berita";
            // 
            // dgvKelasHariIni
            // 
            dgvKelasHariIni.AllowUserToAddRows = false;
            dgvKelasHariIni.BackgroundColor = SystemColors.ControlLightLight;
            dgvKelasHariIni.BorderStyle = BorderStyle.None;
            dgvKelasHariIni.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKelasHariIni.Dock = DockStyle.Fill;
            dgvKelasHariIni.GridColor = SystemColors.ControlDarkDark;
            dgvKelasHariIni.Location = new Point(0, 0);
            dgvKelasHariIni.Name = "dgvKelasHariIni";
            dgvKelasHariIni.ReadOnly = true;
            dgvKelasHariIni.Size = new Size(468, 99);
            dgvKelasHariIni.TabIndex = 21;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlLightLight;
            panel4.Controls.Add(textBox10);
            panel4.Controls.Add(dgvKelasHariIni);
            panel4.Location = new Point(132, 177);
            panel4.Name = "panel4";
            panel4.Size = new Size(468, 99);
            panel4.TabIndex = 21;
            // 
            // textBox10
            // 
            textBox10.BackColor = SystemColors.ControlLightLight;
            textBox10.BorderStyle = BorderStyle.None;
            textBox10.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox10.Location = new Point(10, 3);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(136, 16);
            textBox10.TabIndex = 22;
            textBox10.Text = "Pelajaran Mendatang";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ControlLightLight;
            panel5.Controls.Add(textBox11);
            panel5.Controls.Add(dgvDaftarKursus);
            panel5.Location = new Point(132, 293);
            panel5.Name = "panel5";
            panel5.Size = new Size(468, 145);
            panel5.TabIndex = 23;
            // 
            // textBox11
            // 
            textBox11.BackColor = SystemColors.ControlLightLight;
            textBox11.BorderStyle = BorderStyle.None;
            textBox11.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox11.Location = new Point(10, 3);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(136, 16);
            textBox11.TabIndex = 22;
            textBox11.Text = "Kursus";
            // 
            // dgvDaftarKursus
            // 
            dgvDaftarKursus.AllowUserToAddRows = false;
            dgvDaftarKursus.BackgroundColor = SystemColors.ControlLightLight;
            dgvDaftarKursus.BorderStyle = BorderStyle.None;
            dgvDaftarKursus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDaftarKursus.Dock = DockStyle.Fill;
            dgvDaftarKursus.GridColor = SystemColors.ControlDarkDark;
            dgvDaftarKursus.Location = new Point(0, 0);
            dgvDaftarKursus.Name = "dgvDaftarKursus";
            dgvDaftarKursus.ReadOnly = true;
            dgvDaftarKursus.Size = new Size(468, 145);
            dgvDaftarKursus.TabIndex = 21;
            // 
            // StudentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Controls.Add(lblPersenKehadiran);
            Controls.Add(button9);
            Controls.Add(lblPoinSiswa);
            Controls.Add(button7);
            Controls.Add(lblNilaiRataRata);
            Controls.Add(button8);
            Controls.Add(lblNamaSiswa);
            Controls.Add(userName1);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Controls.Add(lblKelasSiswa);
            Controls.Add(panel4);
            Name = "StudentDashboardForm";
            Text = "StudentDashboardForm";
            Load += StudentDashboardForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKelasHariIni).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDaftarKursus).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnMenuDashboard;
        private Button btnLogout;
        private Button btnMenuKalender;
        private Button btnMenuAbsensi;
        private Button btnMenuNilai;
        private Button btnMenuJadwal;
        private TextBox textBox1;
        private TextBox userName1;
        private TextBox lblNamaSiswa;
        private PictureBox pictureBox2;
        private Button button8;
        private TextBox lblNilaiRataRata;
        private TextBox lblPoinSiswa;
        private Button button7;
        private TextBox lblPersenKehadiran;
        private Button button9;
        private PictureBox pictureBox1;
        private TextBox lblKelasSiswa;
        private Panel panel2;
        private TextBox textBox8;
        private Panel panel3;
        private TextBox textBox9;
        private DataGridView dgvKelasHariIni;
        private Panel panel4;
        private TextBox textBox10;
        private Panel panel5;
        private TextBox textBox11;
        private DataGridView dgvDaftarKursus;
    }
}