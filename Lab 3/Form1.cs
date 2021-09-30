using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            string tmp = textBox1.Text.Trim();
            string outS = string.Empty;
            bool zapyataya = true;
            foreach (char ch in tmp)

                if (Char.IsDigit(ch) | Char.IsLetter(ch) || (ch == ',' && zapyataya))
                {
                    outS += ch;
                    if (ch == ',')
                        zapyataya = false;
                }

            textBox1.Text = outS;
            textBox1.SelectionStart = outS.Length;

            if (str.Contains("."))
            {
                string s = str.Replace(".", ",");
                textBox1.Clear();
                textBox1.AppendText(str.Replace(".", ","));

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string str = textBox2.Text;
            string tmp = textBox2.Text.Trim();
            string outS = string.Empty;
            bool zapyataya = true;
            foreach (char ch in tmp)

                if (Char.IsDigit(ch) | Char.IsLetter(ch) || (ch == ',' && zapyataya))
                {
                    outS += ch;
                    if (ch == ',')
                        zapyataya = false;
                }

            textBox2.Text = outS;
            textBox2.SelectionStart = outS.Length;

            if (str.Contains("."))
            {
                string s = str.Replace(".", ",");
                textBox2.Clear();
                textBox2.AppendText(str.Replace(".", ","));

            }
        }

        private double f(double a)
        {
            return Math.Pow(a, 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double x = 0;
            double b = 0;
            double g = 0;

            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Введите x");
            }
            else if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("Введите y");
            } else {

                x = double.Parse(textBox1.Text);
                b = double.Parse(textBox2.Text);

                if((0.5 < x*b) && (x*b < 10))
                {
                    g = Math.Exp(f(x) - Math.Abs(b));

                } else if ((0.1 < x*b) && (x*b < 0.5))
                {
                    g = Math.Sqrt(Math.Abs(f(x) + b));
                } else
                {
                    g = 2 * Math.Pow(f(x), 2);
                }

                textBox4.Text = "Результаты работы программы " + Environment.NewLine;
                textBox4.Text += "При X =" + textBox1.Text + Environment.NewLine;
                textBox4.Text += "При Y =" + textBox2.Text + Environment.NewLine;
                textBox4.Text += "g =" + g.ToString();

            }

        }
    }
}
