using Project_KLP_12.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project_KLP_12.Views
{
    public partial class StudentGrade : Form
    {
        private UserModel currentUser;
        private UserRepository userRepository = new UserRepository();


        public StudentGrade(UserModel user)
        {
            InitializeComponent();
            currentUser = user;
            LoadNilai(currentUser);

        }

        private void LoadNilai(UserModel user)
        {
            UserRepository repo = new UserRepository();

            lblNamaSiswa.Text = user.Name;
            lblKelasSiswa.Text = user.Kelas;



            dataGridViewNilai.AutoGenerateColumns = false;
            dataGridViewNilai.Columns.Clear();

            List<UserModel> DataNilai = repo.GetNilai(0, "", user.ClassName, user.Role);

            dataGridViewNilai.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SubjectName",
                HeaderText = "Mapel",
                DataPropertyName = "SubjectName",
                Width = 350,
            });

            dataGridViewNilai.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Nilai",
                HeaderText = "Nilai",
                DataPropertyName = "Nilai",
                Width = 150,
            });
            dataGridViewNilai.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Teacher_Name",
                HeaderText = "Guru",
                DataPropertyName = "Teacher_Name",
                Width = 100
            });

            dataGridViewNilai.DataSource = DataNilai;

            double rataRata = DataNilai.Average(x => x.Nilai);

            int MapelCount = DataNilai.Count;

            MapelTxt.Text = MapelCount.ToString();
            rataRatatxt.Text = rataRata.ToString();
        }

        private void StudentGrade_Load(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (currentUser != null)
            {
                StudentDashboardForm dashboard = new StudentDashboardForm(currentUser);
                dashboard.Show();
                this.Hide();
            }
        }

        private void flowLayoutPanelNilai_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewNilai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PoinAkademik akademik = new PoinAkademik(currentUser);
            akademik.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentDashboardForm student = new StudentDashboardForm(currentUser);
            student.Show();
            this.Hide();
        }

        private void rataRatatxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void MapelTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void StudentGrade_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
