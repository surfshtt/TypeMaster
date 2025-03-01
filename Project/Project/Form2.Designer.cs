namespace Project
{
    partial class RegForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegForm));
            PasswordBox = new TextBox();
            LoginBox = new TextBox();
            Go1Button = new PictureBox();
            RepeatPasswordBox = new TextBox();
            Warn = new Label();
            ((System.ComponentModel.ISupportInitialize)Go1Button).BeginInit();
            SuspendLayout();
            // 
            // PasswordBox
            // 
            PasswordBox.BorderStyle = BorderStyle.None;
            PasswordBox.Font = new Font("Segoe UI", 29F);
            PasswordBox.Location = new Point(608, 467);
            PasswordBox.MaxLength = 20;
            PasswordBox.Name = "PasswordBox";
            PasswordBox.PasswordChar = '*';
            PasswordBox.Size = new Size(579, 52);
            PasswordBox.TabIndex = 3;
            PasswordBox.KeyPress += PasBox_KeyPress;
            // 
            // LoginBox
            // 
            LoginBox.BorderStyle = BorderStyle.None;
            LoginBox.Font = new Font("Segoe UI", 29F);
            LoginBox.Location = new Point(608, 347);
            LoginBox.MaxLength = 20;
            LoginBox.Name = "LoginBox";
            LoginBox.Size = new Size(579, 52);
            LoginBox.TabIndex = 2;
            LoginBox.KeyPress += LogBox_KeyPress;
            // 
            // Go1Button
            // 
            Go1Button.Image = Properties.Resources.Go1Button;
            Go1Button.Location = new Point(1139, 692);
            Go1Button.Name = "Go1Button";
            Go1Button.Size = new Size(230, 111);
            Go1Button.TabIndex = 4;
            Go1Button.TabStop = false;
            Go1Button.Click += Go1Button_Click;
            // 
            // RepeatPasswordBox
            // 
            RepeatPasswordBox.BorderStyle = BorderStyle.None;
            RepeatPasswordBox.Font = new Font("Segoe UI", 29F);
            RepeatPasswordBox.Location = new Point(608, 597);
            RepeatPasswordBox.MaxLength = 20;
            RepeatPasswordBox.Name = "RepeatPasswordBox";
            RepeatPasswordBox.PasswordChar = '*';
            RepeatPasswordBox.Size = new Size(579, 52);
            RepeatPasswordBox.TabIndex = 5;
            // 
            // Warn
            // 
            Warn.AutoSize = true;
            Warn.Font = new Font("Segoe UI", 19F);
            Warn.ForeColor = Color.IndianRed;
            Warn.Location = new Point(608, 682);
            Warn.Name = "Warn";
            Warn.Size = new Size(0, 36);
            Warn.TabIndex = 6;
            // 
            // RegForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1904, 1041);
            Controls.Add(Warn);
            Controls.Add(RepeatPasswordBox);
            Controls.Add(Go1Button);
            Controls.Add(PasswordBox);
            Controls.Add(LoginBox);
            DoubleBuffered = true;
            Name = "RegForm";
            Text = "TypeMaster";
            WindowState = FormWindowState.Maximized;
            FormClosed += RegForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)Go1Button).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox PasswordBox;
        private TextBox LoginBox;
        private PictureBox Go1Button;
        private TextBox RepeatPasswordBox;
        private Label Warn;
    }
}