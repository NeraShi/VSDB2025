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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
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
            menuStrip1.Size = new Size(866, 28);
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
            dataGridView1.Size = new Size(600, 235);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Location = new Point(12, 268);
            button1.Name = "button1";
            button1.Size = new Size(600, 42);
            button1.TabIndex = 2;
            button1.Text = "Вывести данные";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 316);
            button2.Name = "button2";
            button2.Size = new Size(200, 30);
            button2.TabIndex = 3;
            button2.Text = "Добавить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            textBox1.Location = new Point(618, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(236, 34);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            textBox2.Location = new Point(618, 130);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(236, 34);
            textBox2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(672, 31);
            label1.Name = "label1";
            label1.Size = new Size(140, 28);
            label1.TabIndex = 6;
            label1.Text = "Имя клиента";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(654, 99);
            label2.Name = "label2";
            label2.Size = new Size(158, 28);
            label2.TabIndex = 7;
            label2.Text = "Годовой доход";
            // 
            // button3
            // 
            button3.Location = new Point(218, 316);
            button3.Name = "button3";
            button3.Size = new Size(200, 30);
            button3.TabIndex = 8;
            button3.Text = "Изменить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(424, 316);
            button4.Name = "button4";
            button4.Size = new Size(188, 30);
            button4.TabIndex = 9;
            button4.Text = "Удалить";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button5.Location = new Point(618, 268);
            button5.Name = "button5";
            button5.Size = new Size(236, 78);
            button5.TabIndex = 10;
            button5.Text = "Создать отчёт";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 367);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
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
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
