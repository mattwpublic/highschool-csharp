using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WidemanCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void muliplyButton_Click(object sender, EventArgs e)
        {
            double n1 = System.Convert.ToDouble(NumberBox1.Text);
            double n2 = System.Convert.ToDouble(NumberBox2.Text);
            Number1Box.Text = "" + (n1 * n2);
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            double n1 = System.Convert.ToDouble(NumberBox1.Text);
            double n2 = System.Convert.ToDouble(NumberBox2.Text);
            Number1Box.Text = "" + (n1 / n2);
        }

        private void powerButton_Click(object sender, EventArgs e)
        {
            double n1 = System.Convert.ToDouble(NumberBox1.Text);
            double n2 = System.Convert.ToDouble(NumberBox2.Text);
            Number1Box.Text = "" + (Math.Pow(n1, n2));
        }

        private void plusButton_Click_1(object sender, EventArgs e)
        {
            double n1 = System.Convert.ToDouble(NumberBox1.Text);
            double n2 = System.Convert.ToDouble(NumberBox2.Text);
            Number1Box.Text = "" + (n1 + n2);
        }

        private void minusButton_Click_1(object sender, EventArgs e)
        {
            double n1 = System.Convert.ToDouble(NumberBox1.Text);
            double n2 = System.Convert.ToDouble(NumberBox2.Text);
            Number1Box.Text = "" + (n1 - n2);
        }
    }
}
