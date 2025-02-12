using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class FallingLetters : Form
    {
        LoginForm _logInstance;
        MainForm _mainInstance;
        int mode;
        int currentTotal = 0;
        int timerCh = 0;

        public FallingLetters(LoginForm loginst, MainForm maininst, int m)
        {
            InitializeComponent();

            _logInstance = loginst;
            _mainInstance = maininst;
            mode = m;
        }

        private void FallingLetters_FormClosed(object sender, FormClosedEventArgs e)
        {
            _logInstance.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            _logInstance.Show();
        }

        private void BackButton_MouseEnter(object sender, EventArgs e)
        {
            BackButton.Image = Image.FromFile($"pics/BackButtonP.png");
        }

        private void BackButton_MouseLeave(object sender, EventArgs e)
        {
            BackButton.Image = Image.FromFile($"pics/BackButtonNP.png");
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            currentTotal = 0;

            switch (mode)
            {
                case 1:
                    timer.Interval = 60;
                    break;

                case 2:
                    timer.Interval = 40;
                    break;

                case 3:
                    timer.Interval = 20;
                    break;
            }

            timer.Enabled = true;
            StartButton.Visible = false;
        }
    }
}
