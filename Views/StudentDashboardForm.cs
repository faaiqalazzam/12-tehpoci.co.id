using Project_KLP_12.Models;
using Project_KLP_12.Presenters;
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
            userName1.Text = user.Name;
            lblNamaSiswa.Text = user.Name;
            lblKelasSiswa.Text = user.Kelas;
            lblPoinSiswa.Text = user.Jiwa.ToString();

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
    }
}