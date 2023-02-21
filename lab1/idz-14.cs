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

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        int x = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;

            label3.Visible = true;
            label4.Visible = true;
            x++;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Visible = false;

            label4.Visible = false;
            x++;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = true;
            label3.Visible = false;
            x++;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = false;

            label4.Visible = false;
            x++;

        }

        private void button5_Click(object sender, EventArgs e)
        {

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            x = 0;

        }
        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (x == 5)
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                x = 0;

                MessageBox.Show(
        "Выберите один из вариантов",
        "Все хорошо?",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button1,
        MessageBoxOptions.DefaultDesktopOnly);
            }
        }
    }
}
