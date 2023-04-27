using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace puasson1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long Fact(long n)
            {
                if (n == 0)
                    return 1;
                else
                    return n * Fact(n - 1);
            }
            chart1.Series[0].Points.Clear();
            for (int i = 0; i < int.Parse(textBox2.Text); i++)
            {
                chart1.Series[0].Points.AddXY(i, Math.Pow(int.Parse(textBox1.Text), i)*Math.Exp(-int.Parse(textBox1.Text))/Fact(i));
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
