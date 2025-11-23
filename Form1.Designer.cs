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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox5 = new TextBox();
            label3 = new Label();
            textBox6 = new TextBox();
            label4 = new Label();
            textBox7 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(236, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(34, 9);
            label1.Name = "label1";
            label1.Size = new Size(192, 28);
            label1.TabIndex = 4;
            label1.Text = "Адрес сервера БД";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(34, 70);
            label2.Name = "label2";
            label2.Size = new Size(190, 28);
            label2.TabIndex = 6;
            label2.Text = "Имя базы данных";
            label2.Click += label2_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(12, 101);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(236, 27);
            textBox5.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(30, 133);
            label3.Name = "label3";
            label3.Size = new Size(196, 28);
            label3.TabIndex = 8;
            label3.Text = "Имя пользователя";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(12, 164);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(236, 27);
            textBox6.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(22, 198);
            label4.Name = "label4";
            label4.Size = new Size(226, 28);
            label4.TabIndex = 10;
            label4.Text = "Пароль пользователя";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(12, 229);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(236, 27);
            textBox7.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(12, 262);
            button1.Name = "button1";
            button1.Size = new Size(236, 49);
            button1.TabIndex = 11;
            button1.Text = "Соединиться";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(263, 325);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(textBox7);
            Controls.Add(label3);
            Controls.Add(textBox6);
            Controls.Add(label2);
            Controls.Add(textBox5);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox5;
        private Label label3;
        private TextBox textBox6;
        private Label label4;
        private TextBox textBox7;
        private Button button1;
    }
}
