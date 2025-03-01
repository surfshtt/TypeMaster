namespace Project
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            LoginBox = new TextBox();
            PasswordBox = new TextBox();
            RegButton = new PictureBox();
            Go1Button = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)RegButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Go1Button).BeginInit();
            SuspendLayout();
            // 
            // LoginBox
            // 
            LoginBox.BorderStyle = BorderStyle.None;
            LoginBox.Font = new Font("Segoe UI", 29F);
            LoginBox.Location = new Point(606, 405);
            LoginBox.MaxLength = 20;
            LoginBox.Name = "LoginBox";
            LoginBox.Size = new Size(579, 52);
            LoginBox.TabIndex = 0;
            LoginBox.KeyPress += LogBox_KeyPress;
            // 
            // PasswordBox
            // 
            PasswordBox.BorderStyle = BorderStyle.None;
            PasswordBox.Font = new Font("Segoe UI", 29F);
            PasswordBox.Location = new Point(606, 525);
            PasswordBox.MaxLength = 20;
            PasswordBox.Name = "PasswordBox";
            PasswordBox.PasswordChar = '*';
            PasswordBox.Size = new Size(579, 52);
            PasswordBox.TabIndex = 1;
            PasswordBox.KeyPress += PasBox_KeyPress;
            // 
            // RegButton
            // 
            RegButton.Image = Properties.Resources.RegButton;
            RegButton.Location = new Point(823, 637);
            RegButton.Name = "RegButton";
            RegButton.Size = new Size(219, 63);
            RegButton.TabIndex = 2;
            RegButton.TabStop = false;
            RegButton.Click += RegButton_Click;
            // 
            // Go1Button
            // 
            Go1Button.Image = Properties.Resources.Go1Button;
            Go1Button.Location = new Point(1136, 613);
            Go1Button.Name = "Go1Button";
            Go1Button.Size = new Size(230, 111);
            Go1Button.TabIndex = 3;
            Go1Button.TabStop = false;
            Go1Button.Click += Go1Button_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1904, 1041);
            Controls.Add(Go1Button);
            Controls.Add(RegButton);
            Controls.Add(PasswordBox);
            Controls.Add(LoginBox);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LoginForm";
            Text = "TypeMaster";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)RegButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)Go1Button).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LoginBox;
        private TextBox PasswordBox;
        private PictureBox RegButton;
        private PictureBox Go1Button;
    }
}
