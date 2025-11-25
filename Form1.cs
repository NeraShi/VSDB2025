using Microsoft.Office.Interop.Word;
using System.Data.SqlClient;

namespace VSDB2025
{
    public partial class Form1 : Form
    {
        [Obsolete]
        public Form1()
        {
            InitializeComponent();
            SetButtonsState(false);
            SetTextFieldsState(false);
        }

        // switching buttons state
        public void SetButtonsState(bool isEnabled)
        {
            buttonShowDataTable.Enabled = isEnabled;
            buttonAddDataRecord.Enabled = isEnabled;
            buttonEditDataRecord.Enabled = isEnabled;
            buttonDeleteDataRecord.Enabled = isEnabled;
            buttonCreateDataReport.Enabled = isEnabled;

            dataGridView1.Enabled = isEnabled;
        }

        // switching text fields state
        public void SetTextFieldsState(bool isEnabled)
        {
            textBoxClientName.Text = "";
            textBoxClientSalary.Text = "";
            textBoxClientName.Enabled = isEnabled;
            textBoxClientSalary.Enabled = isEnabled;
        }

        // connecting to the DB
        [Obsolete]
        private void ConnectToDB(object sender, EventArgs e)
        {
            logwin = new Login();
            if (logwin.ShowDialog() == DialogResult.OK)
            {
                buttonShowDataTable.Enabled = true;
            }
        }

        // data retrieving from the connected DB
        [Obsolete]
        public void ShowDataTable(object sender, EventArgs e)
        {
            updateTable();
            SetButtonsState(true);
        }

        // creating new data object in the connected DB
        [Obsolete]
        private void AddData(object sender, EventArgs e)
        {
            addrec = new Addrecord();
            addrec.Owner = this;
            addrec.ShowDialog();
        }

        // retrieving info about chosen object from the table
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                SetTextFieldsState(true);

                textBoxClientName.Text = row.Cells["name"].Value?.ToString() ?? "";
                textBoxClientSalary.Text = row.Cells["salary"].Value?.ToString() ?? "";

                if (row.Cells["id"].Value != null && row.Cells["id"].Value != DBNull.Value)
                {
                    Data.Clicked_object_id = (int)row.Cells["id"].Value;
                }
            }
        }

        // data object edition
        [Obsolete]
        private void EditDataRecord(object sender, EventArgs e)
        {
            using SqlConnection conn = new(Data.Value);
            using SqlCommand cmd = new("UPDATE dbo.salaries SET name = '" + textBoxClientName.Text + 
                "', salary = '" + textBoxClientSalary.Text.Replace(',', '.') + 
                "' WHERE id = " + Data.Clicked_object_id.ToString(), conn);
            conn.Open();

            try
            {
                cmd.ExecuteNonQuery();
                textBoxClientName.Clear();
                textBoxClientSalary.Clear();
                updateTable();
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message);
            }
        }

        // deleting the chosen object from the table and connected DB
        [Obsolete]
        private void DeleteDataRecord(object sender, EventArgs e)
        {
            using SqlConnection conn = new(Data.Value);
            using SqlCommand cmd = new("DELETE FROM dbo.salaries WHERE id = " + 
                Data.Clicked_object_id, conn);
            conn.Open();

            try
            {
                if (MessageBox.Show("Вы действительно хотите удалить запись?", "Предупреждение",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    cmd.ExecuteNonQuery();
                    textBoxClientName.Clear();
                    textBoxClientSalary.Clear();
                    updateTable();
                }
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message);
            }
        }

        // creating a Word report about DB data
        [Obsolete]
        private void CreateDataReport(object sender, EventArgs e)
        {
            // creating a Word document
            Microsoft.Office.Interop.Word.Application app = new();
            Document doc = app.Documents.Add(Visible: true);
            Microsoft.Office.Interop.Word.Range r = doc.Range();

            // adding a table for DB data into the document
            Table t = doc.Tables.Add(r, 1, 3);
            t.Borders.Enable = 1;

            // establishing DB connection and retrieving all DB data into the table
            using SqlConnection conn = new(Data.Value);
            try
            {
                conn.Open();
                using (SqlCommand cmd = new("SELECT * FROM dbo.salaries", conn))
                {
                    using SqlDataReader reader = cmd.ExecuteReader();
                    int j = 1;

                    while (reader.Read())
                    {
                        t.Rows.Add();
                        for (int i = 1; i <= reader.FieldCount; i++)
                        {
                            t.Cell(j, i).Range.Text = reader.GetValue(i - 1).ToString();
                        }
                        j++;
                    }
                }

                t.Rows.Last.Delete();
                doc.Save();
                try
                {
                    doc.Close();
                    app.Quit();
                }
                catch (Exception help)
                {
                    MessageBox.Show(help.Message);
                }
            }
            catch (Exception help)
            {
                MessageBox.Show(help.Message);
            }
        }
    }
}
