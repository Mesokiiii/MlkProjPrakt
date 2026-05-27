using Mb.UI.Login;

namespace Mb;

public partial class MainMenu : Form
{
    public MainMenu()
    {
        InitializeComponent();
    }

private void pnlDatabase_Click(object sender, EventArgs e)
    {
        // string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["HospitalDB"].ConnectionString;

        // DbManager dbManager = new DbManager(connectionString);

        // if (dbManager.TestConnection())
        // {
        //     MessageBox.Show("Успешно", "УСПЕХ!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        // } else
        // {
        //     MessageBox.Show("уВЫ");
        // }
        LoginForm loginForm = new LoginForm();

        loginForm.Show();
    }
}
