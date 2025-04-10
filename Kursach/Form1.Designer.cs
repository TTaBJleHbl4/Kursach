namespace Kursach
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
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ScrollBar;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.Location = new Point(487, 171);
            button1.Name = "button1";
            button1.Size = new Size(152, 71);
            button1.TabIndex = 0;
            button1.Text = "Метод Трапеции";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ScrollBar;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.Location = new Point(161, 171);
            button2.Name = "button2";
            button2.Size = new Size(152, 71);
            button2.TabIndex = 1;
            button2.Text = "Метод Прямоугольников";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1709254794_oir_mobi_p_fon_dlya_prilozheniya_68;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Выбор метода";
            ResumeLayout(false);
        }

        public class FormSwitcher
        {
            public static void SwitchMainForm(Form Form1,Form Form2)
            {
                Form2 newForm = new Form2();
                Form1.Hide();
                Form2.Show();
                Form2.FormClosed += (s, args) => Form1.Show();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            FormSwitcher.SwitchMainForm(this, newForm);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            FormSwitcher.SwitchMainForm(this, newForm);
        }



        #endregion

        private Button button1;
        private Button button2;
    }
}
