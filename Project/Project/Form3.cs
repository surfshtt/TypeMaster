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
    public partial class MainForm : Form
    {
        LoginForm _instatnceLog;
        private static int[] radioButInfo = new int[2];
        string us;

        public MainForm(LoginForm _inst, string us)
        {
            InitializeComponent();

            this._instatnceLog = _inst;
            this.us = us;

            RadioModeButton1.Image = Image.FromFile($"pics/RadioButtonCMode.png");
            RadioModeButton2.Image = Image.FromFile($"pics/RadioButtonNCMode.png");
            RadioModeButton3.Image = Image.FromFile($"pics/RadioButtonNCMode.png");
            radioButInfo[0] = 1;

            RadioModeButton11.Image = Image.FromFile($"pics/RadioButtonCMode.png");
            RadioModeButton22.Image = Image.FromFile($"pics/RadioButtonNCMode.png");
            RadioModeButton33.Image = Image.FromFile($"pics/RadioButtonNCMode.png");
            radioButInfo[1] = 1;
        }


        private void RadioModeButton_Click(object sender, EventArgs e)
        {
            try
            {
                PictureBox clickedButton = sender as PictureBox;

                if (clickedButton.Name == "RadioModeButton1")
                {
                    RadioModeButton1.Image = Image.FromFile($"pics/RadioButtonCMode.png");
                    RadioModeButton2.Image = Image.FromFile($"pics/RadioButtonNCMode.png");
                    RadioModeButton3.Image = Image.FromFile($"pics/RadioButtonNCMode.png");
                    radioButInfo[0] = 1;
                }
                else if (clickedButton.Name == "RadioModeButton2")
                {
                    RadioModeButton2.Image = Image.FromFile($"pics/RadioButtonCMode.png");
                    RadioModeButton1.Image = Image.FromFile($"pics/RadioButtonNCMode.png");
                    RadioModeButton3.Image = Image.FromFile($"pics/RadioButtonNCMode.png");
                    radioButInfo[0] = 2;
                }
                else if (clickedButton.Name == "RadioModeButton3")
                {
                    RadioModeButton3.Image = Image.FromFile($"pics/RadioButtonCMode.png");
                    RadioModeButton1.Image = Image.FromFile($"pics/RadioButtonNCMode.png");
                    RadioModeButton2.Image = Image.FromFile($"pics/RadioButtonNCMode.png");
                    radioButInfo[0] = 3;
                }

                if (clickedButton.Name == "RadioModeButton11")
                {
                    RadioModeButton11.Image = Image.FromFile($"pics/RadioButtonCMode.png");
                    RadioModeButton22.Image = Image.FromFile($"pics/RadioButtonNCMode.png");
                    RadioModeButton33.Image = Image.FromFile($"pics/RadioButtonNCMode.png");
                    radioButInfo[1] = 1;
                }
                else if (clickedButton.Name == "RadioModeButton22")
                {
                    RadioModeButton22.Image = Image.FromFile($"pics/RadioButtonCMode.png");
                    RadioModeButton11.Image = Image.FromFile($"pics/RadioButtonNCMode.png");
                    RadioModeButton33.Image = Image.FromFile($"pics/RadioButtonNCMode.png");
                    radioButInfo[1] = 2;
                }
                else if (clickedButton.Name == "RadioModeButton33")
                {
                    RadioModeButton33.Image = Image.FromFile($"pics/RadioButtonCMode.png");
                    RadioModeButton11.Image = Image.FromFile($"pics/RadioButtonNCMode.png");
                    RadioModeButton22.Image = Image.FromFile($"pics/RadioButtonNCMode.png");
                    radioButInfo[1] = 3;
                }
            }
            catch { }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instatnceLog.Close();
        }

        private void GoPlay1Button_Click(object sender, EventArgs e)
        {
            FallingLetters fl = new FallingLetters(_instatnceLog, this, radioButInfo[0]);
            fl.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FallingWords fw = new FallingWords(_instatnceLog, this, radioButInfo[1]);
            fw.Show();
            this.Hide();
        }

        private void StatButton_Click(object sender, EventArgs e)
        {
            StatForm sf = new StatForm(_instatnceLog, this, us);
            sf.Show();
            this.Hide();
        }

        private void AboutFormButton_Click(object sender, EventArgs e)
        {
            AboutForm af = new AboutForm(_instatnceLog, this);
            af.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SpeedTestForm spd = new SpeedTestForm(_instatnceLog, this, us, 15);
            spd.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SpeedTestForm spd = new SpeedTestForm(_instatnceLog, this, us, 30);
            spd.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SpeedTestForm spd = new SpeedTestForm(_instatnceLog, this, us, 60);
            spd.Show();
            this.Hide();
        }
    }
}
