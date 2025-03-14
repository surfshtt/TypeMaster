namespace Project
{
    partial class resultMenu
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
            speed = new Label();
            acc = new Label();
            times = new Label();
            BackButton = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)BackButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // speed
            // 
            speed.AutoSize = true;
            speed.BackColor = Color.Transparent;
            speed.Font = new Font("Segoe UI", 30F);
            speed.ForeColor = Color.White;
            speed.Location = new Point(939, 516);
            speed.Name = "speed";
            speed.Size = new Size(45, 54);
            speed.TabIndex = 3;
            speed.Text = "0";
            // 
            // acc
            // 
            acc.AutoSize = true;
            acc.BackColor = Color.Transparent;
            acc.Font = new Font("Segoe UI", 30F);
            acc.ForeColor = Color.White;
            acc.Location = new Point(1014, 433);
            acc.Name = "acc";
            acc.Size = new Size(45, 54);
            acc.TabIndex = 4;
            acc.Text = "0";
            // 
            // times
            // 
            times.AutoSize = true;
            times.BackColor = Color.Transparent;
            times.Font = new Font("Segoe UI", 30F);
            times.ForeColor = Color.White;
            times.Location = new Point(680, 345);
            times.Name = "times";
            times.Size = new Size(45, 54);
            times.TabIndex = 5;
            times.Text = "0";
            // 
            // BackButton
            // 
            BackButton.Image = Properties.Resources.BackButtonNP;
            BackButton.Location = new Point(1784, 31);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(108, 110);
            BackButton.TabIndex = 6;
            BackButton.TabStop = false;
            BackButton.Click += BackButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Rectangle_11;
            pictureBox1.Location = new Point(488, 635);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(605, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // resultMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.CongratForm2;
            ClientSize = new Size(1904, 1041);
            Controls.Add(pictureBox1);
            Controls.Add(BackButton);
            Controls.Add(times);
            Controls.Add(acc);
            Controls.Add(speed);
            DoubleBuffered = true;
            Name = "resultMenu";
            Text = "TypeMaster";
            WindowState = FormWindowState.Maximized;
            FormClosed += resultMenu_FormClosed;
            ((System.ComponentModel.ISupportInitialize)BackButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label speed;
        private Label acc;
        private Label times;
        private PictureBox BackButton;
        private PictureBox pictureBox1;
    }
}