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
            LogBox = new TextBox();
            PasBox = new TextBox();
            RegButton = new PictureBox();
            Go1Button = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)RegButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Go1Button).BeginInit();
            SuspendLayout();
            // 
            // LogBox
            // 
            LogBox.BorderStyle = BorderStyle.None;
            LogBox.Font = new Font("Segoe UI", 29F);
            LogBox.Location = new Point(606, 405);
            LogBox.MaxLength = 20;
            LogBox.Name = "LogBox";
            LogBox.Size = new Size(579, 52);
            LogBox.TabIndex = 0;
            LogBox.KeyPress += LogBox_KeyPress;
            // 
            // PasBox
            // 
            PasBox.BorderStyle = BorderStyle.None;
            PasBox.Font = new Font("Segoe UI", 29F);
            PasBox.Location = new Point(606, 525);
            PasBox.MaxLength = 20;
            PasBox.Name = "PasBox";
            PasBox.PasswordChar = '*';
            PasBox.Size = new Size(579, 52);
            PasBox.TabIndex = 1;
            PasBox.KeyPress += PasBox_KeyPress;
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
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1904, 1041);
            Controls.Add(Go1Button);
            Controls.Add(RegButton);
            Controls.Add(PasBox);
            Controls.Add(LogBox);
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

        private TextBox LogBox;
        private TextBox PasBox;
        private PictureBox RegButton;
        private PictureBox Go1Button;
    }
}
