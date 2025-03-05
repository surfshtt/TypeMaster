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
    public partial class AboutForm : Form
    {
        LoginForm _instatnceLog;
        MainForm _instanceMain;

        public AboutForm(LoginForm _inst, MainForm _main)
        {
            _instatnceLog = _inst;
            _instanceMain = _main;
            InitializeComponent();
        }

        private void AboutForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instatnceLog.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            _instanceMain.Show();
            this.Hide();
        }
    }
}
