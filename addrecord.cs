using System.Data.SqlClient;

namespace VSDB2025
{
    public partial class Addrecord : Form
    {
        [Obsolete]
        public Addrecord()
        {
            InitializeComponent();
        }

        [Obsolete]
        private void AddDataRecord(object sender, EventArgs e)
        {
            using SqlConnection conn = new(Data.Value);
            try
            {
                conn.Open();
                using SqlCommand cmd = new("INSERT INTO dbo.salaries(name, salary) VALUES('"
                    + textBoxName.Text + "','" + 
                    textBoxSalary.Text + "')", conn);
                try
                {
                    cmd.ExecuteNonQuery();

                    Form1? ff = Owner as Form1;
                    ff?.ShowDataTable(sender, e);

                    MessageBox.Show("Запись успешно добавлена");
                }
                catch (Exception helpExec)
                {
                    MessageBox.Show(helpExec.Message);
                }
            }
            catch (Exception helpConn)
            {
                MessageBox.Show(helpConn.Message);
            }
        }
    }
}
