using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drawingMR202832
{
    public partial class Form1 : Form
    {
        private Random rnd;
        int x, y;

        public Form1()
        {
            InitializeComponent();
            rnd = new Random();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            x = (int)e.X;
            y = (int)e.Y;
            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            Pen lapiz = new Pen(Color.Black);

            if(listOpc.SelectedIndex == 0)
            {
                SolidBrush sb = new SolidBrush(Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256)));
                int tamanioCirculo = rnd.Next(50, 150);
                g.DrawEllipse(lapiz, x - tamanioCirculo, y - tamanioCirculo, tamanioCirculo, tamanioCirculo);
                g.FillEllipse(sb, x - tamanioCirculo, y - tamanioCirculo, tamanioCirculo, tamanioCirculo);

            }

            if (listOpc.SelectedIndex == 1)
            {
                SolidBrush sb = new SolidBrush(Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256)));
                int baseFigura = rnd.Next(50, 150);
                int alturaFigura = rnd.Next(50, 150);
                g.DrawRectangle(lapiz, x - baseFigura, y - alturaFigura, baseFigura, alturaFigura);
                g.FillRectangle(sb, x - baseFigura, y - alturaFigura, baseFigura, alturaFigura);

            }
        }
    }
}
