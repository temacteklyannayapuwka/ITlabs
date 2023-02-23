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
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "")
            {
                Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
                Application.Exit();
            }
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            { 
            textBox4.Text = "";
            double a = 0;
            textBox4.Text = "Лабораторная работа 2(Баканов А.В.)" + Environment.NewLine + "Индивидуальное задание 3";
            double x = double.Parse(textBox1.Text);
            double y = double.Parse(textBox2.Text);
            double z = double.Parse(textBox3.Text);
            a = z + x + y;
            textBox4.Text += Environment.NewLine + "X = " + x.ToString() + Environment.NewLine + "Y = " + y.ToString() + Environment.NewLine + "Z = " + z.ToString() + Environment.NewLine + "Результат = " + a.ToString();
        }
        }
    }
}
