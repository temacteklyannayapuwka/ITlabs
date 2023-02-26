using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_idz1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            textBox4.Text = "Лабораторная работа 2(Баканов А.В.)" + Environment.NewLine + "Индивидуальное задание 3";
             double x = double.Parse(textBox1.Text); // Считывание значение X
                textBox4.Text += Environment.NewLine + "X = " + x.ToString(); // Вывод значения X в окно
            double y = double.Parse(textBox2.Text); // Cчитывание значение Y
                textBox4.Text += Environment.NewLine + "Y = " + y.ToString(); // Вывод значения Y в окно
            double z = double.Parse(textBox3.Text); // Считывание значение Z
                textBox4.Text += Environment.NewLine + "Z = " + z.ToString(); // Вывод значения Z в окно
                double q = 1 + (Math.Sin(x + y) * Math.Sin(x + y));
                double b = (q / (Math.Abs(x - (2*y / (1 + (Math.Pow(x, 2) * Math.Pow(y, 2)))))));
                double c = Math.Pow(Math.Cos(Math.Atan(1 / z)), 2);
                double n = Math.Pow(x, (Math.Abs(y)));
                double v = (b * n) + c;
             textBox4.Text += Environment.NewLine + "Результат = " + v.ToString(); // Вывод значения V в окно
        }
        }
    }
}
