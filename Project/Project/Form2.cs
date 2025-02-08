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
    public partial class RegForm : Form
    {
        LoginForm _logIns;
        public RegForm(LoginForm _logInstance)
        {
            InitializeComponent();

            LogBox.BackColor = ColorTranslator.FromHtml("#312D2D");
            LogBox.ForeColor = ColorTranslator.FromHtml("#E4E4E4");
            PasBox.BackColor = ColorTranslator.FromHtml("#312D2D");
            PasBox.ForeColor = ColorTranslator.FromHtml("#E4E4E4");

            _logIns = _logInstance;
        }

        private void LogBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | Char.IsLetter(e.KeyChar) | (Char.IsPunctuation(e.KeyChar) | e.KeyChar == '\b'))
                return;
            else
                e.Handled = true;
        }

        private void PasBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | Char.IsLetter(e.KeyChar) | (Char.IsPunctuation(e.KeyChar) | e.KeyChar == '\b'))
                return;
            else
                e.Handled = true;
        }

        private void RegForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _logIns.Close();
        }
    }
}
