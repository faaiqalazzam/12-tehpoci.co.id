using Project_KLP_12.Models;
using Project_KLP_12.Presenters;
using Project_KLP_12.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project_KLP_12
{
    public partial class StudentDashboardForm : Form
    {

        private UserModel currentUser;
        public void DisplayUserData(UserModel user)
        {

            lblNamaSiswa.Text = user.Name;
            lblKelasSiswa.Text = user.Kelas;
            lbPoinJiwa.Text = user.Jiwa.ToString();
            lbPelanggaran1.Text = user.Pelanggaran.ToString();
            lbKehadiran.Text = user.Kehadiran.ToString() + "%";
            LoadJadwal();

        }

        public void LoadJadwal()
        {
            AddJadwalCard("07:15 - 09:30", "Pemrograman Web & Perangkat Bergerak");
            AddJadwalCard("09:45 - 11:30", "Pemrograman Berorientasi Objek");
            AddJadwalCard("12:30 - 14:00", "Basis Data");
            AddJadwalCard("14:00 - 15:30", "PKK");
        }

        public StudentDashboardForm(UserModel user)
        {
            InitializeComponent();
            currentUser = user;
            DisplayUserData(currentUser);

        }
        private void StudentDashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();

        }

        // Tambahkan ini untuk mengatasi error button6_Click
        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblNilaiRataRata_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void AddJadwalCard(string jam, string mapel)
        {

            Panel card = new Panel();
            card.Size = new Size(300, 30);
            card.BackColor = Color.WhiteSmoke;

            Label lblJam = new Label();
            lblJam.Text = jam;
            lblJam.BackColor = Color.FromArgb(139, 0, 0);
            lblJam.ForeColor = Color.White;
            lblJam.Font = new Font("Segoe UI", 6, FontStyle.Bold);
            lblJam.TextAlign = ContentAlignment.MiddleCenter;
            lblJam.Size = new Size(115, 30);
            lblJam.Location = new Point(5, 5);

            Label lblMapel = new Label();
            lblMapel.Text = mapel;
            lblMapel.ForeColor = Color.Black;
            lblMapel.Font = new Font("Segoe UI", 6, FontStyle.Regular);
            lblMapel.AutoSize = true;
            lblMapel.Location = new Point(130, 15);


            card.Controls.Add(lblJam);
            card.Controls.Add(lblMapel);

            FlowLayoutPanelJadwal.Controls.Add(card);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentGrade nilai = new StudentGrade();
            nilai.Show();
            this.Hide();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbPoinJiwa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}