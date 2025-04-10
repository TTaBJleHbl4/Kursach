using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double lowerBound = double.Parse(textBox1.Text);
                double upperBound = double.Parse(textBox2.Text);
                int intervals = int.Parse(textBox3.Text);

                // Проверяем, что количество интервалов больше 0
                if (intervals <= 0)
                {
                    MessageBox.Show("Количество интервалов должно быть больше 0.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double rightResult = RightRectangleMethod(lowerBound, upperBound, intervals);
                textBox4.Text = $"{rightResult}";
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ошибка ввода: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private double Function(double x)
        {
            // Пример функции f(x) = x^2; вы можете изменить это на свою функцию
            return x * x;
        }
        private double RightRectangleMethod(double a, double b, int n)
        {
            double result = 0.0;
            double deltaX = (b - a) / n;

            for (int i = 1; i <= n; i++)
            {
                result += Function(a + i * deltaX) * deltaX;
            }
            return result;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double lowerBound = double.Parse(textBox1.Text);
                double upperBound = double.Parse(textBox2.Text);
                int intervals = int.Parse(textBox3.Text);

                // Проверяем, что количество интервалов больше 0
                if (intervals <= 0)
                {
                    MessageBox.Show("Количество интервалов должно быть больше 0.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Вычисляем интегрл
                double middleResult = MiddleRectangleMethod(lowerBound, upperBound, intervals);

                // Отображение результатов
                textBox4.Text = $"{middleResult}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка ввода: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double Function1(double x)
        {
            // Пример функции f(x) = x^2; вы можете изменить это на свою функцию
            return x * x;
        }
        private double MiddleRectangleMethod(double a, double b, int n)
        {
            double result = 0.0;
            double deltaX = (b - a) / n;

            for (int i = 0; i < n; i++)
            {
                result += Function1(a + (i + 0.5) * deltaX) * deltaX;
            }
            return result;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double lowerBound = double.Parse(textBox1.Text);
                double upperBound = double.Parse(textBox2.Text);
                int intervals = int.Parse(textBox3.Text);

                // Проверяем, что количество интервалов больше 0
                if (intervals <= 0)
                {
                    MessageBox.Show("Количество интервалов должно быть больше 0.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Вычисляем интегрл
                double leftResult = LeftRectangleMethod(lowerBound, upperBound, intervals);

                // Отображение результатов
                textBox4.Text = $" {leftResult}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка ввода: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private double Function2(double x)
        {
            // Пример функции f(x) = x^2; вы можете изменить это на свою функцию
            return x * x;
        }
        private double LeftRectangleMethod(double a, double b, int n)
        {
            double result = 0.0;
            double deltaX = (b - a) / n;

            for (int i = 0; i < n; i++)
            {
                result += Function(a + i * deltaX) * deltaX;
            }
            return result;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}




