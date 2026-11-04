namespace Project_KLP_12
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SKIBIDI = new Button();
            SuspendLayout();
            // 
            // SKIBIDI
            // 
            SKIBIDI.Location = new Point(273, 51);
            SKIBIDI.Name = "SKIBIDI";
            SKIBIDI.Size = new Size(242, 38);
            SKIBIDI.TabIndex = 0;
            SKIBIDI.Text = "SKIBIDI";
            SKIBIDI.UseVisualStyleBackColor = true;
            SKIBIDI.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SKIBIDI);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button SKIBIDI;
    }
}
