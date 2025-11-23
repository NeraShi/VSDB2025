using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VSDB2025
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();

            textBox1.Text = "HOME-PC\\SQLEXPRESS";
            textBox2.Text = "TEST";
            textBox3.Text = "Sudo";
            textBox4.PasswordChar = '*';
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (conn = new System.Data.SqlClient.SqlConnection(
                "Server=tcp:" + textBox1.Text + ";Database=" + textBox2.Text + ";uid=" + textBox3.Text + ";pwd=" + textBox4.Text + ""
                )
            )
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("Соединено");

                    Data.value = "Server=tcp:" + textBox1.Text + ";Database=" + textBox2.Text + ";uid=" + textBox3.Text + ";pwd=" + textBox4.Text + "";
                    this.Close();
                }
                catch (Exception help)
                {
                    MessageBox.Show(help.Message);
                }
            }
        }
    }
}
