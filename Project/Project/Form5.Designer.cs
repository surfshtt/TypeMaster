namespace Project
{
    partial class FallingWords
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
            timer = new System.Windows.Forms.Timer(components);
            BackButton = new PictureBox();
            StartButton = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)BackButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StartButton).BeginInit();
            SuspendLayout();
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // BackButton
            // 
            BackButton.Image = Properties.Resources.BackButtonNP;
            BackButton.Location = new Point(1784, 27);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(108, 110);
            BackButton.TabIndex = 1;
            BackButton.TabStop = false;
            BackButton.Click += BackButton_Click;
            // 
            // StartButton
            // 
            StartButton.Image = Properties.Resources.StartButton;
            StartButton.Location = new Point(800, 719);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(328, 109);
            StartButton.TabIndex = 2;
            StartButton.TabStop = false;
            StartButton.Click += StartButton_Click;
            // 
            // FallingWords
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FallingLettersForm;
            ClientSize = new Size(1904, 1041);
            Controls.Add(StartButton);
            Controls.Add(BackButton);
            DoubleBuffered = true;
            Name = "FallingWords";
            Text = "TypeMaster";
            WindowState = FormWindowState.Maximized;
            FormClosed += FallingWords_FormClosed;
            KeyPress += FallingWords_KeyPress;
            ((System.ComponentModel.ISupportInitialize)BackButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)StartButton).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private PictureBox BackButton;
        private PictureBox StartButton;
    }
}