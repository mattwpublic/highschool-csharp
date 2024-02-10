using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WidemanDrawName
{
    public partial class Form1 : Form 
    {
        Image canvas;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            canvas = new Bitmap(800, 800);
            doDrawing();
        }

        private void doDrawing()
        {
            Graphics g = Graphics.FromImage(canvas);
            g.Clear(Color.Black);
        
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.DrawImage(canvas, 0, 0);
            g.DrawLine(Pens.Yellow, 100, 700, 100, 100);
            g.DrawLine(Pens.Yellow, 100, 100, 200, 300);
            g.DrawLine(Pens.Yellow, 200, 300, 300, 100);
            g.DrawLine(Pens.Yellow, 300, 100, 300, 700);
            g.DrawLine(Pens.Yellow, 500, 100, 500, 700);
            g.DrawLine(Pens.Yellow, 500, 700, 600, 500);
            g.DrawLine(Pens.Yellow, 600, 500, 700, 700);
            g.DrawLine(Pens.Yellow, 700, 700, 700, 100);

        }
    }
}
