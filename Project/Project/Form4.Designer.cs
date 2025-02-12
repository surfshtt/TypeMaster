namespace Project
{
    partial class FallingLetters
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
            BackButton = new PictureBox();
            StartButton = new PictureBox();
            timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)BackButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StartButton).BeginInit();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.Image = Properties.Resources.BackButtonNP;
            BackButton.Location = new Point(1784, 30);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(108, 110);
            BackButton.TabIndex = 0;
            BackButton.TabStop = false;
            BackButton.Click += BackButton_Click;
            BackButton.MouseEnter += BackButton_MouseEnter;
            BackButton.MouseLeave += BackButton_MouseLeave;
            // 
            // StartButton
            // 
            StartButton.Image = Properties.Resources.StartButton;
            StartButton.Location = new Point(800, 719);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(328, 109);
            StartButton.TabIndex = 1;
            StartButton.TabStop = false;
            StartButton.Click += StartButton_Click;
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // FallingLetters
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FallingLettersForm;
            ClientSize = new Size(1904, 1041);
            Controls.Add(StartButton);
            Controls.Add(BackButton);
            DoubleBuffered = true;
            Name = "FallingLetters";
            Text = "TypeMaster";
            WindowState = FormWindowState.Maximized;
            FormClosed += FallingLetters_FormClosed;
            KeyPress += FallingLetters_KeyPress;
            ((System.ComponentModel.ISupportInitialize)BackButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)StartButton).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox BackButton;
        private PictureBox StartButton;
        private System.Windows.Forms.Timer timer;
    }
}