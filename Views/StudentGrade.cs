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

            dataGridViewNilai.AutoGenerateColumns = false;
            dataGridViewNilai.Columns.Clear();

            List<UserModel> DataNilai = repo.GetNilai(0, "", user.ClassName ,user.Role);

            dataGridViewNilai.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SubjectName",
                HeaderText = "Mapel",
                DataPropertyName = "SubjectName",
                Width = 550,
            });

            dataGridViewNilai.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Nilai",
                HeaderText = "Nilai",
                DataPropertyName = "Nilai",
                Width = 150,
            });

            dataGridViewNilai.DataSource = DataNilai;
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
    }
}
