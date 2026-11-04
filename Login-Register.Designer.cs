namespace Project_KLP_12
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnLogin = new Button();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            cmbRole = new ComboBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Maroon;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.ForeColor = SystemColors.ButtonFace;
            btnLogin.Location = new Point(47, 311);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(227, 38);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += button1_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(47, 188);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(227, 23);
            txtEmail.TabIndex = 1;
            txtEmail.Text = "\r\n";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(47, 229);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(227, 23);
            txtPassword.TabIndex = 2;
            txtPassword.Text = "\r\n";
            txtPassword.UseSystemPasswordChar = true;
            // 
            // cmbRole
            // 
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Siswa", "Guru", "Operator" });
            cmbRole.Location = new Point(47, 267);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(227, 23);
            cmbRole.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.School_Of_Digital_Era_1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(-3, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(758, 450);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(cmbRole);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(btnLogin);
            panel1.Location = new Point(506, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(294, 450);
            panel1.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(47, 106);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(176, 16);
            textBox4.TabIndex = 5;
            textBox4.Text = "Please Fill Out The Forms Below.";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Trebuchet MS", 19.75F, FontStyle.Bold);
            textBox3.Location = new Point(47, 73);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(152, 31);
            textBox3.TabIndex = 4;
            textBox3.Text = "Welcome!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogin;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private ComboBox cmbRole;
        private PictureBox pictureBox1;
        private Panel panel1;
        private TextBox textBox4;
        private TextBox textBox3;
    }
}