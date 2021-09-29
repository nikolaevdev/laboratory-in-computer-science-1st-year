using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x;
            double y;
            double z;

            if (textBox1.Text.Length==0)
            {
                MessageBox.Show("Введите x");

            } else if (textBox2.Text.Length == 0) {
                MessageBox.Show("Введите y");
            } else if (textBox3.Text.Length == 0) {
                MessageBox.Show("Введите z");
            } else {
                x = double.Parse(textBox1.Text);
                y = double.Parse(textBox2.Text);
                z = double.Parse(textBox3.Text);

                double b = (Math.Sqrt(10 * (Math.Pow(Math.Sqrt(x), 1 / 3f) + Math.Pow(x, y + 2)))) * (Math.Pow(Math.Acos(z), 2) - Math.Abs(x - y));

                textBox4.Text = b.ToString();
            }
        }
    }
}
