using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project
{
    public partial class StatForm : Form
    {
        LoginForm _instanceLog;
        MainForm _instanceMain;

        public StatForm(LoginForm instanceLog, MainForm instanceMain, string userName)
        {
            _instanceLog = instanceLog;
            _instanceMain = instanceMain;

            helloLabel.Text = "Привет, " + userName + "!";

            helloLabel.BackColor = ColorTranslator.FromHtml("#131111");
            helloLabel.ForeColor = Color.White;

            slovo1.BackColor = ColorTranslator.FromHtml("#131111");
            slovo2.BackColor = ColorTranslator.FromHtml("#131111");
            slovo3.BackColor = ColorTranslator.FromHtml("#131111");

            label3.BackColor = ColorTranslator.FromHtml("#131111");
            label2.BackColor = ColorTranslator.FromHtml("#131111");
            label1.BackColor = ColorTranslator.FromHtml("#131111");

            rec1.BackColor = ColorTranslator.FromHtml("#131111");
            rec2.BackColor = ColorTranslator.FromHtml("#131111");
            rec3.BackColor = ColorTranslator.FromHtml("#131111");

            rec1.BackColor = ColorTranslator.FromHtml("#131111");
            rec2.BackColor = ColorTranslator.FromHtml("#131111");
            rec3.BackColor = ColorTranslator.FromHtml("#131111");


            int[] rec1Ar = new int[2];
            int[] rec2Ar = new int[2];
            int[] rec3Ar = new int[2];

            using (StreamReader sr = new StreamReader("Users.txt"))
            {
                string line;
                string[] groupOfUsers;

                while ((line = sr.ReadLine()) != null)
                {
                    groupOfUsers = line.Split('$');

                    if (groupOfUsers[0].Equals(userName))
                    {
                        rec1.Text = groupOfUsers[2] + " симв/сек";
                        rec1Ar[0] = int.Parse(groupOfUsers[2]);
                        rec2.Text = groupOfUsers[3] + " симв/сек";
                        rec2Ar[0] = int.Parse(groupOfUsers[3]);
                        rec3.Text = groupOfUsers[4] + " симв/сек";
                        rec3Ar[0] = int.Parse(groupOfUsers[4]);
                        break;
                    }
                }
            }
            using (StreamReader sr = new StreamReader("Users.txt"))
            {
                string line;
                string[] groupOfUsers;
                while ((line = sr.ReadLine()) != null)
                {
                    groupOfUsers = line.Split('$');

                    if (!groupOfUsers[0].Equals(userName))
                    {
                        if (int.Parse(groupOfUsers[2]) > rec1Ar[0])
                            rec1Ar[1]++;
                        if (int.Parse(groupOfUsers[3]) > rec2Ar[0])
                            rec2Ar[1]++;
                        if (int.Parse(groupOfUsers[4]) > rec3Ar[0])
                            rec3Ar[1]++;
                    }
                }

                rec1.Text = (rec1Ar[1] + 1).ToString() + " место";
                rec2.Text = (rec2Ar[1] + 1).ToString() + " место";
                rec3.Text = (rec3Ar[1] + 1).ToString() + " место";

                InitializeComponent();
            }

        }

        private void StatForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instanceLog.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            _instanceMain.Show();
        }
    }
}
