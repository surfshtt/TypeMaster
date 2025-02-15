namespace Project
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            GoPlay1Button = new PictureBox();
            RadioModeButton1 = new PictureBox();
            RadioModeButton2 = new PictureBox();
            RadioModeButton3 = new PictureBox();
            RadioModeButton33 = new PictureBox();
            RadioModeButton22 = new PictureBox();
            RadioModeButton11 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)GoPlay1Button).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RadioModeButton1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RadioModeButton2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RadioModeButton3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RadioModeButton33).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RadioModeButton22).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RadioModeButton11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // GoPlay1Button
            // 
            GoPlay1Button.Image = Properties.Resources.Go1Button;
            GoPlay1Button.Location = new Point(990, 285);
            GoPlay1Button.Name = "GoPlay1Button";
            GoPlay1Button.Size = new Size(231, 111);
            GoPlay1Button.TabIndex = 0;
            GoPlay1Button.TabStop = false;
            GoPlay1Button.Click += GoPlay1Button_Click;
            // 
            // RadioModeButton1
            // 
            RadioModeButton1.Image = Properties.Resources.RadioButtonNCMode;
            RadioModeButton1.Location = new Point(667, 332);
            RadioModeButton1.Name = "RadioModeButton1";
            RadioModeButton1.Size = new Size(33, 33);
            RadioModeButton1.TabIndex = 1;
            RadioModeButton1.TabStop = false;
            RadioModeButton1.Click += RadioModeButton_Click;
            // 
            // RadioModeButton2
            // 
            RadioModeButton2.Image = Properties.Resources.RadioButtonNCMode;
            RadioModeButton2.Location = new Point(796, 332);
            RadioModeButton2.Name = "RadioModeButton2";
            RadioModeButton2.Size = new Size(33, 33);
            RadioModeButton2.TabIndex = 2;
            RadioModeButton2.TabStop = false;
            RadioModeButton2.Click += RadioModeButton_Click;
            // 
            // RadioModeButton3
            // 
            RadioModeButton3.Image = Properties.Resources.RadioButtonNCMode;
            RadioModeButton3.Location = new Point(918, 332);
            RadioModeButton3.Name = "RadioModeButton3";
            RadioModeButton3.Size = new Size(33, 33);
            RadioModeButton3.TabIndex = 3;
            RadioModeButton3.TabStop = false;
            RadioModeButton3.Click += RadioModeButton_Click;
            // 
            // RadioModeButton33
            // 
            RadioModeButton33.Image = Properties.Resources.RadioButtonNCMode;
            RadioModeButton33.Location = new Point(1581, 332);
            RadioModeButton33.Name = "RadioModeButton33";
            RadioModeButton33.Size = new Size(33, 33);
            RadioModeButton33.TabIndex = 6;
            RadioModeButton33.TabStop = false;
            RadioModeButton33.Click += RadioModeButton_Click;
            // 
            // RadioModeButton22
            // 
            RadioModeButton22.Image = Properties.Resources.RadioButtonNCMode;
            RadioModeButton22.Location = new Point(1459, 332);
            RadioModeButton22.Name = "RadioModeButton22";
            RadioModeButton22.Size = new Size(33, 33);
            RadioModeButton22.TabIndex = 5;
            RadioModeButton22.TabStop = false;
            RadioModeButton22.Click += RadioModeButton_Click;
            // 
            // RadioModeButton11
            // 
            RadioModeButton11.Image = Properties.Resources.RadioButtonNCMode;
            RadioModeButton11.Location = new Point(1330, 332);
            RadioModeButton11.Name = "RadioModeButton11";
            RadioModeButton11.Size = new Size(33, 33);
            RadioModeButton11.TabIndex = 4;
            RadioModeButton11.TabStop = false;
            RadioModeButton11.Click += RadioModeButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Go1Button;
            pictureBox1.Location = new Point(1648, 285);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(231, 111);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1904, 1041);
            Controls.Add(pictureBox1);
            Controls.Add(RadioModeButton33);
            Controls.Add(RadioModeButton22);
            Controls.Add(RadioModeButton11);
            Controls.Add(RadioModeButton3);
            Controls.Add(RadioModeButton2);
            Controls.Add(RadioModeButton1);
            Controls.Add(GoPlay1Button);
            DoubleBuffered = true;
            Name = "MainForm";
            Text = "TypeMaster";
            WindowState = FormWindowState.Maximized;
            FormClosed += MainForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)GoPlay1Button).EndInit();
            ((System.ComponentModel.ISupportInitialize)RadioModeButton1).EndInit();
            ((System.ComponentModel.ISupportInitialize)RadioModeButton2).EndInit();
            ((System.ComponentModel.ISupportInitialize)RadioModeButton3).EndInit();
            ((System.ComponentModel.ISupportInitialize)RadioModeButton33).EndInit();
            ((System.ComponentModel.ISupportInitialize)RadioModeButton22).EndInit();
            ((System.ComponentModel.ISupportInitialize)RadioModeButton11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox GoPlay1Button;
        private PictureBox RadioModeButton1;
        private PictureBox RadioModeButton2;
        private PictureBox RadioModeButton3;
        private PictureBox RadioModeButton33;
        private PictureBox RadioModeButton22;
        private PictureBox RadioModeButton11;
        private PictureBox pictureBox1;
    }
}