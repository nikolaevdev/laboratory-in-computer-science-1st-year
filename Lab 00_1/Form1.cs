using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_00_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double f(double a)
        {
            return Math.Pow(a, 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Введите x");
            }
            else if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("Введите y");
            }
            else
            {

                double x = Convert.ToDouble(textBox1.Text);
                double y = Convert.ToDouble(textBox2.Text);

                double o = 0;

                if ((x/y) > 0)
                {
                    o = Math.Log(f(x)) + Math.Pow((Math.Pow(f(x), 2) + y), 3);
                } else if((x/y) < 0)
                {
                    o = Math.Log(Math.Abs(f(x) / y)) + Math.Pow((f(x) + y), 3);
                } else if (x == 0)
                {
                    o = Math.Pow((Math.Pow(f(x), 2) + y), 3);
                } else if (y == 0)
                {
                    o = 0;
                }

                textBox3.Text = "Результаты работы программы " + Environment.NewLine;
                textBox3.Text += "X= " + textBox1.Text + Environment.NewLine;
                textBox3.Text += "Y= " + textBox2.Text + Environment.NewLine;
                textBox3.Text += "U = " + o.ToString() + Environment.NewLine;


            }
        }
    }
}
