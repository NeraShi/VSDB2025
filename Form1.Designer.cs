using System.Data;
using System.Data.SqlClient;

namespace VSDB2025
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            менюToolStripMenuItem = new ToolStripMenuItem();
            соединитьсяСБДToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { менюToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(841, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            менюToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { соединитьсяСБДToolStripMenuItem });
            менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            менюToolStripMenuItem.Size = new Size(65, 24);
            менюToolStripMenuItem.Text = "Меню";
            // 
            // соединитьсяСБДToolStripMenuItem
            // 
            соединитьсяСБДToolStripMenuItem.Name = "соединитьсяСБДToolStripMenuItem";
            соединитьсяСБДToolStripMenuItem.Size = new Size(216, 26);
            соединитьсяСБДToolStripMenuItem.Text = "Соединиться с БД";
            соединитьсяСБДToolStripMenuItem.Click += соединитьсяСБДToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(577, 235);
            dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Location = new Point(12, 272);
            button1.Name = "button1";
            button1.Size = new Size(577, 42);
            button1.TabIndex = 2;
            button1.Text = "Вывести данные";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(595, 31);
            button2.Name = "button2";
            button2.Size = new Size(236, 29);
            button2.TabIndex = 3;
            button2.Text = "Добавить данные";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 327);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private login logwin;
        private addrecord addrec;

        public void updateTable()
        {
            // объект с данными, прикрепляемый к DataGridView
            using (DataTable dt = new DataTable())
            {
                // объект подключения к базе данных
                using (SqlConnection conn = new SqlConnection(Data.value))
                {
                    // объект с результатом выполнения процедуры после данного подключения
                    using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dbo.salaries ORDER BY id ASC", conn))
                    {
                        try
                        {
                            da.Fill(dt);
                        }
                        catch (Exception helpExec)
                        {
                            MessageBox.Show("Требуется подключение к базе данных!");
                        }
                        
                    }
                }

                dataGridView1.DataSource = dt;
            }
        }

        private MenuStrip menuStrip1;
        private ToolStripMenuItem менюToolStripMenuItem;
        private ToolStripMenuItem соединитьсяСБДToolStripMenuItem;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
    }
}
