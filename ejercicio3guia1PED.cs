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
            Izquierda, Derecha, Arriba, Abajo
        }

        private int x, y;
        private Posicion objPosicion;
        private List<Point> puntos;
        private Point punto;
        private const int TamanioCelda = 20;

        public ejercicio3guia1PED()
        {
            InitializeComponent();
            x = 50;
            y = 50;
            objPosicion = Posicion.Abajo;

            puntos = new List<Point> {
                new Point(5, 5)
            };

            punto = GenerarObjeto();

            DoubleBuffered = true;
            KeyPreview = true;
        }

        private void ejercicio3guia1PED_Paint(object sender, PaintEventArgs e)
        {
            // e.Graphics.DrawImage(new Bitmap("birrete.png"), x, y, 65, 65);
            foreach (Point segmento in puntos)
            {
                e.Graphics.FillRectangle(Brushes.Green, segmento.X * TamanioCelda, segmento.Y * TamanioCelda, TamanioCelda, TamanioCelda);
            }

            e.Graphics.FillEllipse(Brushes.Red, punto.X * TamanioCelda, punto.Y * TamanioCelda, TamanioCelda, TamanioCelda);
        }

        private void ejercicio3guia1PED_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                objPosicion = Posicion.Izquierda;
            }
            else if (e.KeyCode == Keys.Right)
            {
                objPosicion = Posicion.Derecha;
            }
            else if (e.KeyCode == Keys.Up)
            {
                objPosicion = Posicion.Arriba;
            }
            else if (e.KeyCode == Keys.Down)
            {
                objPosicion = Posicion.Abajo;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point cabeza = puntos[0];
            Point nuevo = new Point(cabeza.X, cabeza.Y);

            switch (objPosicion)
            {
                case Posicion.Derecha:
                    nuevo.X += 1;
                    break;
                case Posicion.Izquierda:
                    nuevo.X -= 1;
                    break;
                case Posicion.Arriba:
                    nuevo.Y -= 1;
                    break;
                case Posicion.Abajo:
                    nuevo.Y += 1;
                    break;
            }

            if (nuevo == punto)
            {
                puntos.Add(punto);
                punto = GenerarObjeto();
            }else
            {
                puntos.Insert(0, nuevo);
                if (puntos.Count > 1)
                {
                    puntos.RemoveAt(puntos.Count - 1);
                }
            }
                
            
            if (nuevo.X < 0 || nuevo.X >= ClientSize.Width / TamanioCelda || nuevo.Y < 0 || nuevo.Y >= ClientSize.Height / TamanioCelda)
            {
                timer1.Stop();
                MessageBox.Show("Perdiste");
                ReiniciarJuego();
                return;
            }

            Invalidate();
        }

        private Point GenerarObjeto()
        {
            Random rnd = new Random();
            int x = rnd.Next(ClientSize.Width / TamanioCelda);
            int y = rnd.Next(ClientSize.Height / TamanioCelda);
            return new Point(x, y);
        }

        private void ReiniciarJuego()
        {
            puntos.Clear();
            puntos.Add(new Point(5, 5));
            objPosicion = Posicion.Abajo;
            punto = GenerarObjeto();
            timer1.Start();
            Invalidate();
        }
    }
}
