using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project
{
    public partial class SpeedTestForm : Form
    {

        private static int i = 0; //переменная счетчик для закрашивания введеного текста

        static int clickedTime;
        static int time = 0;

        static int incorrectType = 0;

        static string userName;
        static LoginForm loginForm;
        static MainForm mainForm;

        public SpeedTestForm(LoginForm _instLog, MainForm _instMain, string us, int ct)
        {

            InitializeComponent();

            loginForm = _instLog;
            mainForm = _instMain;
            userName = us;
            clickedTime = ct;

            getText();
            paintText();

            RichTextBox1.BackColor = ColorTranslator.FromHtml("#E4E4E4");

            timer1.Enabled = true;
        }

        //Функция проверяющая на пустой текст и отображения текста в основном меню
        private void getText()
        {
            string text = "";

            while (text.Length < 3)
            {
                text = randomText();
            }

            RichTextBox1.Text = text;
        }

        //Функция осуществляющая выбор рандомного текста из файла
        private string randomText()
        {
            string text;

            try
            {
                var lines = File.ReadAllLines("Texts.txt");
                var random = new Random();
                text = lines[random.Next(lines.Length) - 1];
                return text;
            }
            catch (Exception e)
            {
                return "abc";
            }
        }

        private void SpeedTestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginForm.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            TimeLabel.Text = time.ToString();

            if (time == clickedTime)
            {
                timer1.Enabled = false;

                int record = findRec(clickedTime);//поиск рекорда пользователя в указанном времени

                if (record < countSymbInSec(time, i))//сравнение рекорда пользователя с текущим 
                {
                    newRec(clickedTime, countSymbInSec(time, i));//запись нового рекорда
                }

                resultMenu resMenu = new resultMenu(loginForm, mainForm, countSymbInSec(time, i), (int)(100 - (incorrectType * 100 / RichTextBox1.Text.Length)), clickedTime);

                TimeLabel.Text = "Время";
                i = 0;
                clickedTime = 0;
                getText();
                paintText();

                resMenu.Show();
                this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer1.Enabled = true;
            TimeLabel.Text = "0";
            i = 0;
            clickedTime = 0;
            getText();
            paintText();
        }

        private void paintText()// покраска всего текста в серый
        {
            RichTextBox1.SelectionStart = 0; // начальная позиция
            RichTextBox1.SelectionLength = RichTextBox1.Text.Length; // длина текста
            RichTextBox1.SelectionColor = ColorTranslator.FromHtml("#717171");// серый цвет
            RichTextBox1.DeselectAll();
        }

        private int findRec(int clickedTime)
        {
            int record = 0;
            using (StreamReader sr = new StreamReader("Users.txt"))
            {
                string line;
                string[] groupOfUsers;

                while ((line = sr.ReadLine()) != null)
                {
                    groupOfUsers = line.Split('$');
                    if (userName.Equals(groupOfUsers[0]))
                    {
                        switch (clickedTime)
                        {
                            case 15:
                                record = int.Parse(groupOfUsers[2]);
                                break;
                            case 30:
                                record = int.Parse(groupOfUsers[3]);
                                break;
                            case 60:
                                record = int.Parse(groupOfUsers[4]);
                                break;
                        }
                    }
                }
            }
            return record;
        }

        private void newRec(int clickedTime, int record)    //Запись нового рекорда
        {
            var newFile = new List<string>();
            using (StreamReader sr = new StreamReader("Users.txt"))
            {
                string line;
                string[] groupOfUsers;
                while ((line = sr.ReadLine()) != null)
                {
                    groupOfUsers = line.Split('$');
                    if (!userName.Equals(groupOfUsers[0]))
                    {
                        newFile.Add(line);
                    }
                    else
                    {
                        switch (clickedTime)
                        {
                            case 15:
                                groupOfUsers[2] = record.ToString();
                                break;

                            case 30:
                                groupOfUsers[3] = record.ToString();
                                break;

                            case 60:
                                groupOfUsers[4] = record.ToString();
                                break;
                        }
                        newFile.Add(groupOfUsers[0] + "$" + groupOfUsers[1] + "$" + groupOfUsers[2] + "$" + groupOfUsers[3] + "$" + groupOfUsers[4]);
                    }
                }
            }
            File.WriteAllLines("Users.txt", newFile);
        }

        private int countSymbInSec(int time, int countSymbols) //Функция для подсчета символов в секунду
        {
            double result = 0;
            double t = time / 60.0;

            result = countSymbols / t;
            return (int)Math.Round(result, 0);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            timer1.Enabled = false;
            TimeLabel.Text = "0";
            i = 0;
            clickedTime = 0;
            getText();
            paintText();
            mainForm.Show();
        }

        private void RichTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (clickedTime == 0)
                {
                    MessageBox.Show("Сначало выберите время!");
                    e.Handled = true;
                    RichTextBox1.DeselectAll();
                    return;
                }

                RichTextBox1.Select(i, 1);
                if (e.KeyChar == RichTextBox1.Text[i])
                {
                    RichTextBox1.SelectionColor = Color.Green;
                    i++;
                    e.Handled = true;
                    RichTextBox1.DeselectAll();
                    int currentPosition = RichTextBox1.SelectionStart;
                    RichTextBox1.Select(currentPosition + 1, 0);
                }
                else if (char.IsLetter(e.KeyChar) || e.KeyChar == ' ')
                {
                    incorrectType++;
                    RichTextBox1.SelectionColor = Color.Red;
                    i++;
                    e.Handled = true;
                    RichTextBox1.DeselectAll();
                    int currentPosition = RichTextBox1.SelectionStart;
                    RichTextBox1.Select(currentPosition + 1, 0);
                }
                else
                {
                    e.Handled = true;
                    RichTextBox1.DeselectAll();
                }
            }
            catch
            {
            }
        }

        private void RichTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back && i != 0)
                {
                    i--;
                    RichTextBox1.Select(i, 1);
                    RichTextBox1.SelectionColor = ColorTranslator.FromHtml("#717171");
                    e.Handled = true; // Помечаем событие как обработанное
                    e.SuppressKeyPress = true; //Скажем НЕТ удалению!
                    RichTextBox1.DeselectAll();
                    return;
                }
                else if (e.KeyCode == Keys.Back && i == 0)
                {
                    e.Handled = true; // Помечаем событие как обработанное
                    e.SuppressKeyPress = true; //Скажем НЕТ удалению!
                    RichTextBox1.DeselectAll();
                    return;
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }
        }
    }
}
