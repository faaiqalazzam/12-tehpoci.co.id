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
           
        }

        public StudentGrade()
        {
            InitializeComponent();
            
        }

        //private void LoadNilaiCards()
        //{
        //    if (currentUser != null)
        //    {
 
        //        DataTable dt = userRepository.GetNilaiSiswa(currentUser.Id);


        //        foreach (DataRow row in dt.Rows)
        //        {
        //            string mataPelajaran = row["Mata Pelajaran"].ToString();
        //            string nilai = row["Nilai"].ToString();
        //            string keterangan = row["Keterangan"].ToString();


        //            AddNilaiCard(mataPelajaran, nilai, keterangan);
        //        }
        //    }
        //}

        private void AddNilaiCard(string mapel, string score, string ket)
        {

            Panel card = new Panel();
            card.Size = new Size(500, 70); // Sesuaikan ukuran lebar & tinggi card
            card.BackColor = Color.White;
            card.Margin = new Padding(5);

            // 2. Label untuk Mata Pelajaran
            Label lblMapel = new Label();
            lblMapel.Text = mapel;
            lblMapel.ForeColor = Color.Black;
            lblMapel.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblMapel.Location = new Point(15, 10);
            lblMapel.AutoSize = true;

            // 3. Label untuk Keterangan / Deskripsi
            Label lblKet = new Label();
            lblKet.Text = ket;
            lblKet.ForeColor = Color.Gray;
            lblKet.Font = new Font("Segoe UI", 8, FontStyle.Regular);
            lblKet.Location = new Point(15, 35);
            lblKet.AutoSize = true;

            // 4. Label untuk Nilai (Score) di sebelah kanan
            Label lblScore = new Label();
            lblScore.Text = score;
            lblScore.ForeColor = Color.FromArgb(139, 0, 0); // Warna merah tema poci/akademik
            lblScore.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblScore.TextAlign = ContentAlignment.MiddleRight;
            lblScore.Size = new Size(100, 40);
            lblScore.Location = new Point(380, 15);

            // Masukkan semua label ke dalam card panel
            card.Controls.Add(lblMapel);
            card.Controls.Add(lblKet);
            card.Controls.Add(lblScore);


            flowLayoutPanelNilai.Controls.Add(card);
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
    }
}
