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
    public partial class resultMenu : Form
    {

        private LoginForm logmenu;
        private MainForm mainmenu;
        private int speedOfType;
        private int accuracy;
        private int time;

        public resultMenu(LoginForm logmenu, MainForm mainmenu, int speedOfType, int accuracy, int time)
        {
            InitializeComponent();

            this.logmenu = logmenu;
            this.mainmenu = mainmenu;

            speed.Text = speedOfType.ToString();
            acc.Text = (100 - accuracy).ToString() + "%";
            times.Text = time.ToString() + " сек";
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainmenu.Show();
        }

        private void resultMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            logmenu.Close();
        }
    }
}
