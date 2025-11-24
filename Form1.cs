namespace VSDB2025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ñîåäèíèòüñÿÑÁÄToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
