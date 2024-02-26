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
    public partial class ejercicio3guia1PED : Form
    {
        enum Posicion
        {
            izquierda, derecha, arriba, abajo
        }

        private int x, y;
        private Posicion objPosicion;
        private List<Point> puntos;
        private Point punto;
        private const int TamanioCelda = 20;

        private void ejercicio3guia1PED_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(new Bitmap("birrete.png"), x, y, 65, 65);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (objPosicion == Posicion.derecha)
            {
                x += 10;
            }else if (objPosicion == Posicion.izquierda)
            {
                x -= 10;
            }else if(objPosicion == Posicion.arriba)
            {
                y -= 10;
            }else if(objPosicion == Posicion.abajo)
            {
                y += 10;
            }

            Invalidate();
        }

        private void ejercicio3guia1PED_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                objPosicion = Posicion.izquierda;
            }else if (e.KeyCode == Keys.Right)
            {
                objPosicion = Posicion.derecha;
            }else if (e.KeyCode == Keys.Up)
            {
                objPosicion = Posicion.arriba;
            }else if (e.KeyCode == Keys.Down)
            {
                objPosicion = Posicion.abajo;
            }
        }

        public ejercicio3guia1PED()
        {
            InitializeComponent();
            x = 50;
            y = 50;
            objPosicion = Posicion.abajo;

            puntos = new List<Point>();
            puntos.Add(new Point(5, 5));

            punto = generarObjeto();

            DoubleBuffered = true;
            KeyPreview = true;
        }

        private Point generarObjeto()
        {
            Random rnd = new Random();
            int x = rnd.Next(ClientSize.Width / TamanioCelda);
            int y = rnd.Next(ClientSize.Height / TamanioCelda);
            return new Point(x, y);
        }
    }
}
