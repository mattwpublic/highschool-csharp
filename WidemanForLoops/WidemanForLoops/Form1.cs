using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WidemanForLoops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x;
            listBox1.Items.Clear();
            for(x = 5; x <101; x+=5)
            {
                listBox1.Items.Add(x);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x;
            string str = "";
            listBox1.Items.Clear();
            for(x=0;x<10;x++)
            {
                str += "*";
                listBox1.Items.Add(str);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x;
            listBox1.Items.Clear();
            for(x=1;x<10;x++)
            {
                listBox1.Items.Add(x);
            }
        }

        private void problem2_Click(object sender, EventArgs e)
        {
            int x;
            listBox1.Items.Clear();
            for (x=1; x<20;x+=3)
            {
                listBox1.Items.Add(x);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void problem3_Click(object sender, EventArgs e)
        {
            double x;
            listBox1.Items.Clear();
            for(x=1.2;x<9;x+=1.2)
            {
                listBox1.Items.Add(x);
            }
        }

        private void problem4_Click(object sender, EventArgs e)
        {
            int x;
            listBox1.Items.Clear();
            for(x=20; x>=0; x-=2)
            {
                listBox1.Items.Add(x);
            }
        }

        private void problem5_Click(object sender, EventArgs e)
        {
            int x;
            string str = "";
            listBox1.Items.Clear();
            for(x=0;x<10;x++)
            {
                str += "x";
                listBox1.Items.Add(str);
            }
        }

        private void problem6_Click(object sender, EventArgs e)
        {
            string str = "x";
            string blank = " ";
            int x;
            listBox1.Items.Clear();
            for (x = 0; x < 10; x++)
            {
                blank += " ";
                listBox1.Items.Add(blank + str);
            }
        }

    }
}
