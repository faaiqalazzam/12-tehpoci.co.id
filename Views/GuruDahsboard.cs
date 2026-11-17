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
    public partial class GuruDahsboard : Form
    {
        private UserModel currentUser;
        public GuruDahsboard(UserModel user)
        {
            InitializeComponent();
            currentUser = user;
            DisplayUserData(currentUser);
            Kompeten(currentUser);
        }
        public void DisplayUserData(UserModel user)
        {
            UserRepository repo = new UserRepository();
            List<UserModel> Jadwal = repo.GetSchedules(user.Id, user.Role, user.Kelas);

            lblKode.Text = user.teacherCode;
            lblNama.Text = user.Name;
            

            


            

            if (dataGridView1 != null)
            {

                dataGridView1.Columns.Clear();
                dataGridView1.AutoGenerateColumns = false;

                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "SubjectName",
                    HeaderText = "Mapel",
                    DataPropertyName = "SubjectName",
                    Width = 200
                });

                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "ClassName",
                    HeaderText = "Kelas",
                    DataPropertyName = "ClassName",
                    Width = 200
                });

                dataGridView1.DataSource = Jadwal;
            } 
        }
        private void Kompeten(UserModel user)
        {
            if (user.Kompetensi >= 90)
            {
                lbStatus.Text = "Sangat Kompeten";
            }
            else if (user.Kompetensi >= 75)
            {
                lbStatus.Text = "Kompeten";
            }
            else
            {
                lbStatus.Text = "Tidak Kompeten";
            }


        }
        private void teacherSubject(UserModel user)
        {
            
        }

            
                
        private void GuruDahsboard_Load(object sender, EventArgs e)
        {

        }

        private void lblNamaSiswa_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblKelasSiswa_TextChanged(object sender, EventArgs e)
        {

        }

        private void FlowLayoutPanelJadwal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lbPelanggaran1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbSiswaAll_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
