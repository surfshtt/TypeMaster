namespace Project
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            LogBox.BackColor = ColorTranslator.FromHtml("#312D2D");
            LogBox.ForeColor = ColorTranslator.FromHtml("#E4E4E4");
            PasBox.BackColor = ColorTranslator.FromHtml("#312D2D");
            PasBox.ForeColor = ColorTranslator.FromHtml("#E4E4E4");
        }
    }
}
