namespace Project
{
    public partial class LoginForm : Form
    {
        public LoginForm _instance;

        public LoginForm()
        {
            InitializeComponent();

            LogBox.BackColor = ColorTranslator.FromHtml("#312D2D");
            LogBox.ForeColor = ColorTranslator.FromHtml("#E4E4E4");
            PasBox.BackColor = ColorTranslator.FromHtml("#312D2D");
            PasBox.ForeColor = ColorTranslator.FromHtml("#E4E4E4");

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
            MainForm mainMenu = new MainForm(_instance, "username");
            mainMenu.Show();
            this.Hide();
        }
    }
}
