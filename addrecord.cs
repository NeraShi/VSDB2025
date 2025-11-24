using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VSDB2025
{
    public partial class addrecord : Form
    {
        public addrecord()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(SqlConnection conn = new SqlConnection(Data.value))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO dbo.salaries(name, salary) VALUES('" + textBox1.Text + "','" + textBox2.Text + "')", conn))
                    {
                        try
                        {
                            cmd.ExecuteNonQuery();

                            Form1 ff = (Form1)this.Owner;
                            ff.button1_Click(sender, e);

                            MessageBox.Show("Добавлено");
                        }
                        catch (Exception helpExec)
                        {
                            MessageBox.Show(helpExec.Message);
                        }
                    }
                }
                catch (Exception helpConn)
                {
                    MessageBox.Show(helpConn.Message);
                }
            }
        }
    }
}
