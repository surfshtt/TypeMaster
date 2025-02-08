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
            PasBox = new TextBox();
            LogBox = new TextBox();
            SuspendLayout();
            // 
            // PasBox
            // 
            PasBox.BorderStyle = BorderStyle.None;
            PasBox.Font = new Font("Segoe UI", 29F);
            PasBox.Location = new Point(608, 526);
            PasBox.MaxLength = 20;
            PasBox.Name = "PasBox";
            PasBox.PasswordChar = '*';
            PasBox.Size = new Size(579, 52);
            PasBox.TabIndex = 3;
            PasBox.KeyPress += PasBox_KeyPress;
            // 
            // LogBox
            // 
            LogBox.BorderStyle = BorderStyle.None;
            LogBox.Font = new Font("Segoe UI", 29F);
            LogBox.Location = new Point(608, 406);
            LogBox.MaxLength = 20;
            LogBox.Name = "LogBox";
            LogBox.Size = new Size(579, 52);
            LogBox.TabIndex = 2;
            LogBox.KeyPress += LogBox_KeyPress;
            // 
            // RegForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1904, 1041);
            Controls.Add(PasBox);
            Controls.Add(LogBox);
            DoubleBuffered = true;
            Name = "RegForm";
            Text = "TypeMaster";
            WindowState = FormWindowState.Maximized;
            FormClosed += RegForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox PasBox;
        private TextBox LogBox;
    }
}