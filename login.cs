namespace VSDB2025
{
    public partial class Login : Form
    {
        [Obsolete]
        public Login()
        {
            InitializeComponent();

            // test DB login data
            textBoxDBServer.Text = "HOME-PC\\SQLEXPRESS";
            textBoxDBName.Text = "TEST";
            textBoxID.Text = "Sudo";
            textBoxPassword.PasswordChar = '*';
        }

        // establishing connection with DB
        [Obsolete]
        private void ConnectToDB(object sender, EventArgs e)
        {
            try
            {
                using (conn = new System.Data.SqlClient.SqlConnection(
                    "Server=tcp:" + textBoxDBServer.Text + 
                    ";Database=" + textBoxDBName.Text + 
                    ";uid=" + textBoxID.Text + 
                    ";pwd=" + textBoxPassword.Text
                    )
                )
                {
                    conn.Open();
                    MessageBox.Show("Подключение к БД установлено!");

                    Data.Value = "Server=tcp:" + textBoxDBServer.Text + 
                        ";Database=" + textBoxDBName.Text + 
                        ";uid=" + textBoxID.Text + 
                        ";pwd=" + textBoxPassword.Text + "";
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            catch
            {
                MessageBox.Show("Проверьте правильность введённых данных!");
            }
        }
    }
}
