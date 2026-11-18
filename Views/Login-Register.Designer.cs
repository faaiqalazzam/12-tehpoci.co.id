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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnLogin = new Button();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            cmbRole = new ComboBox();
            userRepositoryBindingSource = new BindingSource(components);
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)userRepositoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.MintCream;
            btnLogin.BackgroundImage = (Image)resources.GetObject("btnLogin.BackgroundImage");
            btnLogin.BackgroundImageLayout = ImageLayout.Zoom;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = SystemColors.ButtonHighlight;
            btnLogin.Location = new Point(40, 256);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(240, 48);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += button1_Click;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.ForeColor = SystemColors.WindowText;
            txtEmail.Location = new Point(8, 10);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(208, 16);
            txtEmail.TabIndex = 1;
            txtEmail.Text = "okta@sekolah.com";
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.ForeColor = SystemColors.WindowText;
            txtPassword.Location = new Point(8, 10);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(200, 16);
            txtPassword.TabIndex = 2;
            txtPassword.Text = "12345";
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // cmbRole
            // 
            cmbRole.BackColor = SystemColors.ActiveBorder;
            cmbRole.DataBindings.Add(new Binding("SelectedItem", userRepositoryBindingSource, "", true));
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.FlatStyle = FlatStyle.System;
            cmbRole.ForeColor = SystemColors.WindowText;
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Siswa", "Guru", "Operator" });
            cmbRole.Location = new Point(40, 208);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(232, 23);
            cmbRole.TabIndex = 3;
            cmbRole.SelectedIndexChanged += cmbRole_SelectedIndexChanged;
            // 
            // userRepositoryBindingSource
            // 
            userRepositoryBindingSource.DataSource = typeof(Models.IUserRepository);
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(-23, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(831, 450);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkRed;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(cmbRole);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(488, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(368, 400);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(40, 64);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(176, 16);
            textBox4.TabIndex = 5;
            textBox4.Text = "Please Fill Out The Forms Below.";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(40, 24);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(152, 36);
            textBox3.TabIndex = 4;
            textBox3.Text = "Welcome!";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FloralWhite;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Controls.Add(txtEmail);
            panel2.Location = new Point(40, 104);
            panel2.Name = "panel2";
            panel2.Size = new Size(232, 40);
            panel2.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FloralWhite;
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Controls.Add(txtPassword);
            panel3.Location = new Point(40, 152);
            panel3.Name = "panel3";
            panel3.Size = new Size(232, 40);
            panel3.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)userRepositoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
        private BindingSource userRepositoryBindingSource;
        private Panel panel2;
        private Panel panel3;
    }
}