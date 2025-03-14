namespace Project
{
    partial class SpeedTestForm
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
            RichTextBox1 = new RichTextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            TimeLabel = new Label();
            BackButton = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BackButton).BeginInit();
            SuspendLayout();
            // 
            // RichTextBox1
            // 
            RichTextBox1.Font = new Font("Segoe UI", 35F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RichTextBox1.Location = new Point(170, 155);
            RichTextBox1.Name = "RichTextBox1";
            RichTextBox1.Size = new Size(1596, 498);
            RichTextBox1.TabIndex = 0;
            RichTextBox1.Text = "";
            RichTextBox1.KeyDown += RichTextBox1_KeyDown;
            RichTextBox1.KeyPress += RichTextBox1_KeyPress;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Group_6;
            pictureBox1.Location = new Point(915, 679);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 90);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // TimeLabel
            // 
            TimeLabel.AutoSize = true;
            TimeLabel.BackColor = Color.Transparent;
            TimeLabel.Font = new Font("Segoe UI", 30F);
            TimeLabel.ForeColor = Color.White;
            TimeLabel.Location = new Point(937, 931);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new Size(45, 54);
            TimeLabel.TabIndex = 2;
            TimeLabel.Text = "0";
            // 
            // BackButton
            // 
            BackButton.Image = Properties.Resources.BackButtonNP;
            BackButton.Location = new Point(1784, 23);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(108, 110);
            BackButton.TabIndex = 3;
            BackButton.TabStop = false;
            BackButton.Click += BackButton_Click;
            // 
            // SpeedTestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.SpeedTestForm;
            ClientSize = new Size(1904, 1041);
            Controls.Add(BackButton);
            Controls.Add(TimeLabel);
            Controls.Add(pictureBox1);
            Controls.Add(RichTextBox1);
            DoubleBuffered = true;
            Name = "SpeedTestForm";
            Text = "TypeMaster";
            WindowState = FormWindowState.Maximized;
            FormClosed += SpeedTestForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)BackButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox RichTextBox1;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
        private Label TimeLabel;
        private PictureBox BackButton;
    }
}