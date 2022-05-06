using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.DeepSkyBlue);
            Pen pen = new Pen(Color.Black, 1);
            Pen pen1 = new Pen(Color.Black, 3);
            SolidBrush B = new SolidBrush(Color.White);
            SolidBrush A = new SolidBrush(Color.Black);

            g.FillEllipse(B, 100, 140, 150, 150);
            g.DrawEllipse(pen, 100, 140, 150, 150);
            g.FillEllipse(B, 110, 90, 125, 110);
            g.DrawEllipse(pen, 110, 90, 125, 110);
            g.FillEllipse(B, 122, 30, 100, 100); 
            g.DrawEllipse(pen, 122, 30, 100, 100);

            g.DrawLine(pen1, 50, 180, 120,130);
            g.DrawLine(pen1, 220, 130, 290, 180);

            g.FillEllipse(A, 145, 60, 10, 15);
            g.FillEllipse(A, 185, 60, 10, 15);



            int n = 5;              
            double R = 20, r = 50;   
            double alpha = 0;        
            double x0 = 400, y0 = 150; 

            PointF[] point = new PointF[2 * n + 1];
            double a = alpha, da = Math.PI / n, l;
            for (int i = 0; i < 2 * n + 1; i++)
            {
                l = i % 2 == 0 ? r : R;
                point[i] = new PointF((float)(x0 + l * Math.Cos(a)), (float)(y0 + l * Math.Sin(a)));
                a += da;
            }
            g.DrawLines(pen1, point);

        }
    }
}
