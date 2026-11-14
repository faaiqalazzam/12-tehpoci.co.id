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
            LoadJadwal(user);

            lblNamaSiswa.Text = user.Name;
            lblKelasSiswa.Text = user.Kelas;
            lbPoinJiwa.Text = user.Jiwa.ToString();
            lbPelanggaran1.Text = user.Pelanggaran.ToString();
            lbKehadiran.Text = user.Kehadiran.ToString() + "%";

            ;
        }

        public void LoadJadwal(UserModel user)
        {
            UserRepository repo = new UserRepository();

            List<UserModel> Jadwal = repo.GetSchedules(user.Id, user.Role, user.Kelas);

            dataGridViewJadwal.Columns.Clear();
            dataGridViewJadwal.AutoGenerateColumns = false;

            dataGridViewJadwal.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "SubjectName",
                HeaderText = "Mata Pelajaran",
                DataPropertyName = "SubjectName",
                Width = 220
            });

            if (user.Role == "Siswa")
            {
                dataGridViewJadwal.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = "TeacherName",
                    HeaderText = "Guru",
                    DataPropertyName = "TeacherName",
                    Width = 200
                });
            }
            else
            {
                dataGridViewJadwal.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = "ClassName",
                    HeaderText = "Keleas",
                    DataPropertyName = "ClassName",
                    Width = 200
                });
            }
            dataGridViewJadwal.DataSource = Jadwal;
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

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewJadwal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}