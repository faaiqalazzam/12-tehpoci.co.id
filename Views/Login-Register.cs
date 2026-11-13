using Project_KLP_12.Models;
using Project_KLP_12.Views;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_KLP_12
{
    public partial class Form1 : Form, ILoginView
    {
        public Form1()
        {
            InitializeComponent();

            cmbRole.SelectedItem = "Guru";
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Email
        {
            get => txtEmail.Text.Trim();
            set => txtEmail.Text = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Password
        {
            get => txtPassword.Text.Trim();
            set => txtPassword.Text = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Role
        {
            get => cmbRole.SelectedItem?.ToString() ?? "";
            set => cmbRole.SelectedItem = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Message
        {
            get => "";
            set => MessageBox.Show(value);
        }


        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsLoginSuccessful { get; set; }

        public event EventHandler LoginEvent;

        private void button1_Click(object sender, EventArgs e)
        {
            UserRepository repo = new UserRepository();
            UserModel user = repo.Authenticate(txtEmail.Text, txtPassword.Text, cmbRole.Text);

            if (cmbRole.Text == "Siswa")
            {
                StudentDashboardForm dashboard = new StudentDashboardForm(user);
                dashboard.Show();
                this.Hide();
            }
            if (cmbRole.Text == "Guru")
            {
                GuruDahsboard dashboards = new GuruDahsboard(user);
                dashboards.Show();
                this.Hide();
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

    }
}