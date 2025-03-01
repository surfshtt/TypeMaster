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

            LoginBox.BackColor = ColorTranslator.FromHtml("#312D2D");
            LoginBox.ForeColor = ColorTranslator.FromHtml("#E4E4E4");
            PasswordBox.BackColor = ColorTranslator.FromHtml("#312D2D");
            PasswordBox.ForeColor = ColorTranslator.FromHtml("#E4E4E4");

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

        private void Go1Button_Click(object sender, EventArgs e)
        {
            // Проверка, что все поля заполнены.
            if (LoginBox.Text.Equals("") || PasswordBox.Text.Equals("") || RepeatPasswordBox.Text.Equals(""))
            {
                Warn.Text = "Не все поля заполнены!";
                Warn.Visible = true;
            }
            // Проверка, что пароли совпадают.
            else if (PasswordBox.Text.Equals(RepeatPasswordBox.Text))
            {
                // Проверка, существует ли уже аккаунт с таким логином.
                if (!isExist(LoginBox.Text.ToLower()))
                {
                    Warn.Visible = false;

                    string filePath = "Users.txt";
                    string content = LoginBox.Text.ToLower() + "$" + PasswordBox.Text.ToLower() + "$" + 0 + "$" + 0 + "$" + 0;

                    // Запись текста в файл
                    File.AppendAllText(filePath, content + Environment.NewLine);

                    MessageBox.Show("Вы успешно зарегистрированы!");
                    _logIns.Show();
                    this.Hide();
                }
                else
                {
                    Warn.Text = "Аккаунт с таким логином уже существует!";
                    Warn.Visible = true;
                }
            }
            else
            {
                Warn.Text = "Пароли не совпадают!";
                Warn.Visible = true;
            }
        }

        // Проверка, существует ли пользователь с заданным userName.
        public static bool isExist(string userName)
        {
            try
            {
                using (StreamReader sr = new StreamReader("Users.txt"))
                {
                    string line;
                    string[] groupOfUsers;
                    while ((line = sr.ReadLine()) != null)
                    {
                        groupOfUsers = line.Split('$');
                        if (userName.Equals(groupOfUsers[0]))
                        {
                            return true;
                        }
                    }
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return true;
            }
        }
    }
}
