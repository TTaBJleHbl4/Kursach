namespace Kursach
{
    partial class Form2
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
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 17F);
            label1.ForeColor = Color.Cyan;
            label1.Location = new Point(263, 9);
            label1.Name = "label1";
            label1.Size = new Size(275, 31);
            label1.TabIndex = 0;
            label1.Text = "Метод прямоугольников";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ScrollBar;
            button1.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            button1.Location = new Point(170, 352);
            button1.Name = "button1";
            button1.Size = new Size(115, 38);
            button1.TabIndex = 1;
            button1.Text = "Формула левых прямоугольникв";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(43, 131);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(52, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(43, 211);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(52, 23);
            textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(101, 131);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(52, 23);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ScrollBar;
            button2.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            button2.Location = new Point(334, 352);
            button2.Name = "button2";
            button2.Size = new Size(115, 38);
            button2.TabIndex = 6;
            button2.Text = "Формула средних прямоугольников";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ScrollBar;
            button3.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            button3.Location = new Point(490, 352);
            button3.Name = "button3";
            button3.Size = new Size(116, 38);
            button3.TabIndex = 7;
            button3.Text = "Формула правых прямоугольников";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = Color.Cyan;
            label2.Location = new Point(43, 102);
            label2.Name = "label2";
            label2.Size = new Size(198, 20);
            label2.TabIndex = 8;
            label2.Text = "Пределы интегрирования";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = Color.Cyan;
            label3.Location = new Point(43, 183);
            label3.Name = "label3";
            label3.Size = new Size(266, 20);
            label3.TabIndex = 9;
            label3.Text = "Количество интервалов разбиения";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.Cyan;
            label4.Location = new Point(511, 107);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 10;
            label4.Text = "Результат";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(511, 131);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(95, 23);
            textBox4.TabIndex = 11;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1709254794_oir_mobi_p_fon_dlya_prilozheniya_68;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Метод прямоугольников";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button button2;
        private Button button3;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox4;
    }
}