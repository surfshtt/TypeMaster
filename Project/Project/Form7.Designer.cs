namespace Project
{
    partial class StatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatForm));
            helloLabel = new Label();
            slovo1 = new Label();
            slovo2 = new Label();
            slovo3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            rec3 = new Label();
            rec2 = new Label();
            rec1 = new Label();
            BackButton = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)BackButton).BeginInit();
            SuspendLayout();
            // 
            // helloLabel
            // 
            helloLabel.AutoSize = true;
            helloLabel.Font = new Font("Segoe UI Semibold", 54.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            helloLabel.Location = new Point(509, 159);
            helloLabel.Name = "helloLabel";
            helloLabel.Size = new Size(381, 98);
            helloLabel.TabIndex = 0;
            helloLabel.Text = "helloLabel";
            // 
            // slovo1
            // 
            slovo1.AutoSize = true;
            slovo1.Font = new Font("Segoe UI Semibold", 44.75F, FontStyle.Bold);
            slovo1.ForeColor = Color.White;
            slovo1.Location = new Point(528, 428);
            slovo1.Name = "slovo1";
            slovo1.Size = new Size(190, 81);
            slovo1.TabIndex = 1;
            slovo1.Text = "label1";
            // 
            // slovo2
            // 
            slovo2.AutoSize = true;
            slovo2.Font = new Font("Segoe UI Semibold", 44.75F, FontStyle.Bold);
            slovo2.ForeColor = Color.White;
            slovo2.Location = new Point(528, 545);
            slovo2.Name = "slovo2";
            slovo2.Size = new Size(190, 81);
            slovo2.TabIndex = 2;
            slovo2.Text = "label1";
            // 
            // slovo3
            // 
            slovo3.AutoSize = true;
            slovo3.Font = new Font("Segoe UI Semibold", 44.75F, FontStyle.Bold);
            slovo3.ForeColor = Color.White;
            slovo3.Location = new Point(528, 662);
            slovo3.Name = "slovo3";
            slovo3.Size = new Size(190, 81);
            slovo3.TabIndex = 3;
            slovo3.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 44.75F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(798, 662);
            label1.Name = "label1";
            label1.Size = new Size(309, 81);
            label1.TabIndex = 6;
            label1.Text = "60 секунд";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 44.75F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(798, 545);
            label2.Name = "label2";
            label2.Size = new Size(309, 81);
            label2.TabIndex = 5;
            label2.Text = "30 секунд";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 44.75F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(798, 428);
            label3.Name = "label3";
            label3.Size = new Size(300, 81);
            label3.TabIndex = 4;
            label3.Text = "15 секунд";
            // 
            // rec3
            // 
            rec3.AutoSize = true;
            rec3.Font = new Font("Segoe UI Semibold", 44.75F, FontStyle.Bold);
            rec3.ForeColor = Color.White;
            rec3.Location = new Point(1171, 662);
            rec3.Name = "rec3";
            rec3.Size = new Size(66, 81);
            rec3.TabIndex = 9;
            rec3.Text = "а";
            // 
            // rec2
            // 
            rec2.AutoSize = true;
            rec2.Font = new Font("Segoe UI Semibold", 44.75F, FontStyle.Bold);
            rec2.ForeColor = Color.White;
            rec2.Location = new Point(1171, 545);
            rec2.Name = "rec2";
            rec2.Size = new Size(66, 81);
            rec2.TabIndex = 8;
            rec2.Text = "а";
            // 
            // rec1
            // 
            rec1.AutoSize = true;
            rec1.Font = new Font("Segoe UI Semibold", 44.75F, FontStyle.Bold);
            rec1.ForeColor = Color.White;
            rec1.Location = new Point(1171, 428);
            rec1.Name = "rec1";
            rec1.Size = new Size(66, 81);
            rec1.TabIndex = 7;
            rec1.Text = "а";
            // 
            // BackButton
            // 
            BackButton.Image = Properties.Resources.BackButtonNP;
            BackButton.Location = new Point(1784, 31);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(108, 110);
            BackButton.TabIndex = 10;
            BackButton.TabStop = false;
            BackButton.Click += BackButton_Click;
            // 
            // StatForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1904, 1041);
            Controls.Add(BackButton);
            Controls.Add(rec3);
            Controls.Add(rec2);
            Controls.Add(rec1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(slovo3);
            Controls.Add(slovo2);
            Controls.Add(slovo1);
            Controls.Add(helloLabel);
            DoubleBuffered = true;
            Name = "StatForm";
            Text = "TypeMaster";
            WindowState = FormWindowState.Maximized;
            FormClosed += StatForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)BackButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label helloLabel;
        private Label slovo1;
        private Label slovo2;
        private Label slovo3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label rec3;
        private Label rec2;
        private Label rec1;
        private PictureBox BackButton;
    }
}