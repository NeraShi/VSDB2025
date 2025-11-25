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
        [Obsolete]
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            менюToolStripMenuItem = new ToolStripMenuItem();
            соединитьсяСБДToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            buttonShowDataTable = new Button();
            buttonAddDataRecord = new Button();
            textBoxClientName = new TextBox();
            textBoxClientSalary = new TextBox();
            label1 = new Label();
            label2 = new Label();
            buttonEditDataRecord = new Button();
            buttonDeleteDataRecord = new Button();
            buttonCreateDataReport = new Button();
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
            menuStrip1.Size = new Size(882, 28);
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
            соединитьсяСБДToolStripMenuItem.Click += ConnectToDB;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.DarkGray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 31);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(600, 235);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += DataGridView1_CellClick;
            // 
            // button1
            // 
            buttonShowDataTable.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonShowDataTable.Location = new Point(12, 268);
            buttonShowDataTable.Name = "button1";
            buttonShowDataTable.Size = new Size(600, 42);
            buttonShowDataTable.TabIndex = 2;
            buttonShowDataTable.Text = "Вывести данные";
            buttonShowDataTable.UseVisualStyleBackColor = true;
            buttonShowDataTable.Click += ShowDataTable;
            // 
            // button2
            // 
            buttonAddDataRecord.Location = new Point(12, 316);
            buttonAddDataRecord.Name = "button2";
            buttonAddDataRecord.Size = new Size(200, 30);
            buttonAddDataRecord.TabIndex = 3;
            buttonAddDataRecord.Text = "Добавить";
            buttonAddDataRecord.UseVisualStyleBackColor = true;
            buttonAddDataRecord.Click += AddData;
            // 
            // textBox1
            // 
            textBoxClientName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            textBoxClientName.Location = new Point(634, 62);
            textBoxClientName.Name = "textBox1";
            textBoxClientName.Size = new Size(236, 34);
            textBoxClientName.TabIndex = 4;
            // 
            // textBox2
            // 
            textBoxClientSalary.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            textBoxClientSalary.Location = new Point(634, 130);
            textBoxClientSalary.Name = "textBox2";
            textBoxClientSalary.Size = new Size(236, 34);
            textBoxClientSalary.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(681, 31);
            label1.Name = "label1";
            label1.Size = new Size(140, 28);
            label1.TabIndex = 6;
            label1.Text = "Имя клиента";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(663, 99);
            label2.Name = "label2";
            label2.Size = new Size(158, 28);
            label2.TabIndex = 7;
            label2.Text = "Годовой доход";
            // 
            // button3
            // 
            buttonEditDataRecord.Location = new Point(218, 316);
            buttonEditDataRecord.Name = "button3";
            buttonEditDataRecord.Size = new Size(200, 30);
            buttonEditDataRecord.TabIndex = 8;
            buttonEditDataRecord.Text = "Изменить";
            buttonEditDataRecord.UseVisualStyleBackColor = true;
            buttonEditDataRecord.Click += EditDataRecord;
            // 
            // button4
            // 
            buttonDeleteDataRecord.Location = new Point(424, 316);
            buttonDeleteDataRecord.Name = "button4";
            buttonDeleteDataRecord.Size = new Size(188, 30);
            buttonDeleteDataRecord.TabIndex = 9;
            buttonDeleteDataRecord.Text = "Удалить";
            buttonDeleteDataRecord.UseVisualStyleBackColor = true;
            buttonDeleteDataRecord.Click += DeleteDataRecord;
            // 
            // button5
            // 
            buttonCreateDataReport.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonCreateDataReport.Location = new Point(634, 268);
            buttonCreateDataReport.Name = "button5";
            buttonCreateDataReport.Size = new Size(236, 78);
            buttonCreateDataReport.TabIndex = 10;
            buttonCreateDataReport.Text = "Создать отчёт";
            buttonCreateDataReport.UseVisualStyleBackColor = true;
            buttonCreateDataReport.Click += CreateDataReport;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(882, 353);
            Controls.Add(buttonCreateDataReport);
            Controls.Add(buttonDeleteDataRecord);
            Controls.Add(buttonEditDataRecord);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxClientSalary);
            Controls.Add(textBoxClientName);
            Controls.Add(buttonAddDataRecord);
            Controls.Add(buttonShowDataTable);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Login logwin;
        private Addrecord addrec;

        [Obsolete]
        public void updateTable()
        {
            // объект с данными, прикрепляемый к DataGridView
            using (DataTable dt = new DataTable())
            {
                // объект подключения к базе данных
                using (SqlConnection conn = new SqlConnection(Data.Value))
                {
                    // объект с результатом выполнения процедуры после данного подключения
                    using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dbo.salaries ORDER BY id ASC", conn))
                    {
                        try
                        {
                            da.Fill(dt);
                        }
                        catch
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
        private Button buttonShowDataTable;
        private Button buttonAddDataRecord;
        private TextBox textBoxClientName;
        private TextBox textBoxClientSalary;
        private Label label1;
        private Label label2;
        private Button buttonEditDataRecord;
        private Button buttonDeleteDataRecord;
        private Button buttonCreateDataReport;
    }
}
