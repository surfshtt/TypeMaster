namespace Project
{
    public partial class LoginForm : Form
    {
        public LoginForm _instance;

        public LoginForm()
        {
            InitializeComponent();

            LoginBox.BackColor = ColorTranslator.FromHtml("#312D2D");
            LoginBox.ForeColor = ColorTranslator.FromHtml("#E4E4E4");
            PasswordBox.BackColor = ColorTranslator.FromHtml("#312D2D");
            PasswordBox.ForeColor = ColorTranslator.FromHtml("#E4E4E4");

            _instance = this;
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            RegForm mainMenu = new RegForm(_instance);
            mainMenu.Show();
            this.Hide();
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

        private void Go1Button_Click(object sender, EventArgs e)
        {
            //Проверка корректности значений
            if (!(LoginBox.Text.Equals("") || PasswordBox.Text.Equals("")))
            {

                //Логика входа в программу
                if (correctData(LoginBox.Text.ToLower(), PasswordBox.Text))
                {

                    MainForm mainMenu = new MainForm(_instance, LoginBox.Text);
                    mainMenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Проверьте введеные вами данные!");
                }
            }
        }

        private bool correctData(string login, string password)
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
                        if (login.Equals(groupOfUsers[0]) && password.Equals(groupOfUsers[1]))
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
                return false;
            }
        }
    }
}
