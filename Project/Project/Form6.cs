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
    public partial class CongratForm : Form
    {
        MainForm _mainInstance;
        LoginForm _logInstance;

        public CongratForm(MainForm m, LoginForm l, int time, int mode, int ncrt, string us)
        {
            InitializeComponent();
            _mainInstance = m;
            _logInstance = l;

            this.BackgroundImage = Image.FromFile($"pics/CongratForm1.png"); 
        }

        public CongratForm(MainForm m, LoginForm l, int time, int speed, int ncrt, string us, int tt)
        {
            InitializeComponent();
            _mainInstance = m;
            _logInstance = l;

            this.BackgroundImage = Image.FromFile($"pics/CongratForm2.png");
        }

        private void CongratForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _logInstance.Close();
        }
    }
}
