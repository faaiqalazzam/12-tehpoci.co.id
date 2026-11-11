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
        public GuruDahsboard()
        {
            InitializeComponent();
        }
        public void LoadJadwal()
        {
            Panel Jadwal = new Panel();
            Jadwal.BackColor = Color.WhiteSmoke;
            Jadwal.Size = new Size(300, 30);

            Label lblJam = new Label();
            
            

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
    }
}
