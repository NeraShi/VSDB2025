using System.Data.SqlClient;

namespace VSDB2025
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label4 = new Label();
            textBox4 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(15, 262);
            button1.Name = "button1";
            button1.Size = new Size(236, 49);
            button1.TabIndex = 20;
            button1.Text = "Соединиться";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(25, 198);
            label4.Name = "label4";
            label4.Size = new Size(226, 28);
            label4.TabIndex = 19;
            label4.Text = "Пароль пользователя";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(15, 229);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(236, 27);
            textBox4.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(33, 133);
            label3.Name = "label3";
            label3.Size = new Size(196, 28);
            label3.TabIndex = 17;
            label3.Text = "Имя пользователя";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(15, 164);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(236, 27);
            textBox3.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(37, 70);
            label2.Name = "label2";
            label2.Size = new Size(190, 28);
            label2.TabIndex = 15;
            label2.Text = "Имя базы данных";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(15, 101);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(236, 27);
            textBox2.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(37, 9);
            label1.Name = "label1";
            label1.Size = new Size(192, 28);
            label1.TabIndex = 13;
            label1.Text = "Адрес сервера БД";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(15, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(236, 27);
            textBox1.TabIndex = 12;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(260, 322);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "login";
            Text = "login";
            Load += login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SqlConnection conn;

        private Button button1;
        private Label label4;
        private TextBox textBox4;
        private Label label3;
        private TextBox textBox3;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
    }
}