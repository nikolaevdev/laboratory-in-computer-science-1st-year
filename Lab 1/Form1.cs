using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class lab1 : Form
    {
        public lab1()
        {
            InitializeComponent();
        }

        private void load_lab(object sender, EventArgs e)
        {
            label1.Visible = label2.Visible = label3.Visible = label4.Visible = false;
        }

        private void Visible_libel1(object sender, EventArgs e)
        {
            label1.Visible = true;
        }

        private void Visible_libel2(object sender, EventArgs e)
        {
            label2.Visible = true;
        }

        private void Visible_libel3(object sender, EventArgs e)
        {
            label3.Visible = true;
        }

        private void Visible_libel4(object sender, EventArgs e)
        {
            label4.Visible = true;
        }

    }
}
