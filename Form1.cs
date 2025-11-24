using System.Data.SqlClient;

namespace VSDB2025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void соединитьсяСБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logwin = new login();
            logwin.ShowDialog();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            updateTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addrec = new addrecord();
            addrec.Owner = this;
            addrec.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                using (DataGridViewRow row = dataGridView1.Rows[e.RowIndex])
                {
                    textBox1.Text = row.Cells["name"].Value.ToString();
                    textBox2.Text = row.Cells["salary"].Value.ToString();

                    if (row.Cells["id"].Value != null && row.Cells["id"].Value != DBNull.Value)
                    {
                        Data.clicked_object_id = (int)row.Cells["id"].Value;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Data.value))
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE dbo.salaries SET name = '" + textBox1.Text + "', salary = '" + textBox2.Text.Replace(',', '.') + "' WHERE id = " + Data.clicked_object_id.ToString(), conn))
                {
                    conn.Open();

                    try
                    {
                        cmd.ExecuteNonQuery();
                        textBox1.Clear();
                        textBox2.Clear();
                        updateTable();
                    }
                    catch (Exception help)
                    {
                        MessageBox.Show(help.Message);
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Data.value))
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM dbo.salaries WHERE id = " + Data.clicked_object_id, conn))
                {
                    conn.Open();

                    try
                    {
                        if (MessageBox.Show("Вы действительно хотите удалить запись?", "Предупреждение", 
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                        {
                            cmd.ExecuteNonQuery();
                            textBox1.Clear();
                            textBox2.Clear();
                            updateTable();
                        }
                    }
                    catch (Exception help)
                    {
                        MessageBox.Show(help.Message);
                    }
                }
            }
        }
    }
}
