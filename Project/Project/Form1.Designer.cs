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
            SuspendLayout();
            // 
            // LogBox
            // 
            LogBox.BorderStyle = BorderStyle.None;
            LogBox.Font = new Font("Segoe UI", 29F);
            LogBox.Location = new Point(598, 406);
            LogBox.Name = "LogBox";
            LogBox.Size = new Size(478, 52);
            LogBox.TabIndex = 0;
            // 
            // PasBox
            // 
            PasBox.BorderStyle = BorderStyle.None;
            PasBox.Font = new Font("Segoe UI", 29F);
            PasBox.Location = new Point(598, 526);
            PasBox.Name = "PasBox";
            PasBox.PasswordChar = '*';
            PasBox.Size = new Size(478, 52);
            PasBox.TabIndex = 1;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1904, 1041);
            Controls.Add(PasBox);
            Controls.Add(LogBox);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LoginForm";
            Text = "TypeMaster";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LogBox;
        private TextBox PasBox;
    }
}
