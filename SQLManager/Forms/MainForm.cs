using SQLManager.Dal;
using SQLManager.Models;
using System.Data;

namespace SQLManager.Forms
{
    public partial class MainForm : Form
    {
        private readonly IRepository? repository;

        public MainForm()
        {
            InitializeComponent();
            repository = RepositoryFactory.GetRepository();
        }

        private void MainForm_Load(object sender, EventArgs e) => cbDatabases.DataSource = repository?.GetDatabases().ToList();

        private void BtnExecute_Click(object sender, EventArgs e) => ExecuteQuery();

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();

        private void TbQuery_TextChanged(object sender, EventArgs e) => btnExecute.Enabled = !string.IsNullOrWhiteSpace(tbQuery.Text.Trim());

        private void TbQuery_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                ExecuteQuery();
            }
        }

        private void ExecuteQuery()
        {
            try
            {
                dynamic? result = repository?.ExecuteQuery((Database)cbDatabases.SelectedItem, tbQuery.Text);
                if (result is not null && result is DataTable)
                {
                    dgResults.DataSource = result;
                }
                else
                {
                    MessageBox.Show(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
