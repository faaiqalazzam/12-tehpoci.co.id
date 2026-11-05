using Project_KLP_12.Views;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.ComponentModel;

namespace Project_KLP_12
{
    public partial class Form1 : Form, ILoginView
    {
        public Form1()
        {
            InitializeComponent();

            cmbRole.SelectedItem = "Siswa";
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
            LoginEvent?.Invoke(this, EventArgs.Empty);
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
    }
}