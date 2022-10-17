using SQLManager.Dal;

namespace SQLManager.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm() => InitializeComponent();

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                RepositoryFactory.GetRepository().LogIn(tbServer.Text.Trim(), tbUsername.Text.Trim(), tbPassword.Text.Trim());
                new MainForm().Show();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
