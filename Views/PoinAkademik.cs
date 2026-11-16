using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class PoinAkademik : Form
    {
        private UserModel currentUser;
        public PoinAkademik(UserModel user)
        {
            InitializeComponent();
            currentUser = user;
            LoadData(currentUser);
            

        }

        private void LoadData(UserModel user)
        {
            Jiwa.Text = user.Jiwa.ToString() + " / 200";
            lblPelanggaran.Text = user.Pelanggaran.ToString();
            lblKehadiran.Text = user.Kehadiran.ToString();
            EkskulTxt.Text = user.Ekskul;

            LoadJiwa(currentUser);
            LoadPelanggaran(currentUser);
            

            

        }

        private void LoadJiwa(UserModel user)
        {
            if (user.Jiwa < 200)
            {
                JiwaCategory.Text = "Poin Jiwa Kurang";
                JiwaCategory.ForeColor = Color.Red;
            }
            else if (user.Jiwa >= 200)
            {
                JiwaCategory.Text = "Poin Jiwa Aman!";
                JiwaCategory.ForeColor = Color.Green;
            }
        }

        private void LoadPelanggaran(UserModel user)
        {
            if (user.Pelanggaran < 10)
            {
                PPCategory.Text = "Aman";
                PPCategory.ForeColor = Color.Green;
            }
            else if (user.Pelanggaran >= 50)
            {
                PPCategory.Text = "Poin Kamu Tinggi!";
                PPCategory.ForeColor = Color.Yellow;
            }
            else if(user.Pelanggaran >= 75)
            {
                PPCategory.Text = "Potensi DO!";
                PPCategory.ForeColor = Color.Red;
            }
        }

        private void LoadKehadiran(UserModel user)
        {
            
        }


        private void PoinAkademik_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentDashboardForm student = new StudentDashboardForm(currentUser);
            student.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentGrade grade = new StudentGrade(currentUser);
            grade.Show();
            this.Close();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblKehadiran_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
