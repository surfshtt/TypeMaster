namespace Project
{
    partial class AboutForm
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
            BackButton = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)BackButton).BeginInit();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.Image = Properties.Resources.BackButtonNP;
            BackButton.Location = new Point(1784, 23);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(108, 110);
            BackButton.TabIndex = 1;
            BackButton.TabStop = false;
            BackButton.Click += BackButton_Click;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.AboutForm;
            ClientSize = new Size(1904, 1041);
            Controls.Add(BackButton);
            DoubleBuffered = true;
            Name = "AboutForm";
            Text = "TypeMaster";
            WindowState = FormWindowState.Maximized;
            FormClosed += AboutForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)BackButton).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox BackButton;
    }
}