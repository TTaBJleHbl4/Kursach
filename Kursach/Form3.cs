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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем значения из текстовых полей
                double lowerBound = double.Parse(textBox1.Text);
                double upperBound = double.Parse(textBox2.Text);
                int intervals = int.Parse(textBox3.Text);

                // Вычисляем интеграл методом трапеций
                double result = TrapezoidalIntegration(lowerBound, upperBound, intervals);

                // Выводим результат в текстовое поле
                textBox4.Text = $"{result}"; // Форматируем до 4 знаков после запятой
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, убедитесь, что вы вводите числовые значения.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Метод для вычисления интеграла методом трапеций
        private double TrapezoidalIntegration(double a, double b, int n)
        {
            double h = (b - a) / n; // Ширина подынтервала
            double sum = 0.5 * (Function(a) + Function(b)); // Начальная сумма с учетом концов

            for (int i = 1; i < n; i++)
            {
                double x = a + i * h; // Точка в текущем интервале
                sum += Function(x); // Добавляем значение функции в точке x
            }

            return sum * h; // Умножаем на ширину интервала
        }

        // Пример функции, можно изменить на вашу
        private double Function(double x)
        {
            // Например, интегрируем функцию f(x) = x^2
            return x * x;
        }
    }
}

