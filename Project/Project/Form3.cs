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

        public MainForm(LoginForm _inst, string us)
        {
            InitializeComponent();

            _instatnceLog = _inst;

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
    }
}
