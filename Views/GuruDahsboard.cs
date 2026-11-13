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
        }
        public void DisplayUserData(UserModel user)
        {
            FlowLayoutPanelJadwal.Controls.Clear();
            NewJadwal("07.00 - 09.15 | ", "XI RPL 2");
            NewJadwal("09.15 - 11.15 | ", "XI RPL 3");
        }
        public void NewJadwal(string jam, string mapel) 
        {
            Panel Jadwal = new Panel();
            Jadwal.BackColor = Color.WhiteSmoke;
            Jadwal.Size = new Size(300, 30);

            Label lblJam = new Label();
            lblJam.Text = jam;
            lblJam.BackColor = Color.FromArgb(139, 0, 0);
            lblJam.ForeColor = Color.White;
            lblJam.Font = new Font("Segoe UI", 6, FontStyle.Bold);
            lblJam.TextAlign = ContentAlignment.MiddleCenter;
            lblJam.Size = new Size(115, 30);
            lblJam.Location = new Point(5, 5);

            Label lblmapel = new Label();
            lblmapel.Text = mapel;
            lblmapel.TextAlign = ContentAlignment.MiddleLeft;
            lblmapel.BackColor = Color.White;
            lblmapel.ForeColor = Color.Black;
            lblmapel.Font = new Font("Segoe UI", 6, FontStyle.Bold);
            lblmapel.Size = new Size(115, 30);
            lblmapel.Location = new Point(130, 5);

            Jadwal.Controls.Add(lblJam);
            Jadwal.Controls.Add(lblmapel);
            FlowLayoutPanelJadwal.Controls.Add(Jadwal);




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
    }
}
