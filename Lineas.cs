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
    public partial class Lineas : Form
    {
        Graphics area;

        public Lineas()
        {
            InitializeComponent();
            area = areaDibujo.CreateGraphics();
        }

        private void btnDibular_Click(object sender, EventArgs e)
        {
            Pen lapicero = new Pen(Color.Black);

            switch (cmbColor.SelectedIndex)
            {
                case 0: lapicero = new Pen(Color.Yellow); break;
                case 1: lapicero = new Pen(Color.Red); break;
                case 2: lapicero = new Pen(Color.Blue); break;
                case 3: lapicero = new Pen(Color.Black); break;
            }

            int iteraciones = int.Parse(txtCantidad.Text);
            int espacio = int.Parse(txtEspaciado.Text);

            int puntoInicioX = int.Parse(txtPuntoInicioX.Text);
            int puntoInicioY = int.Parse(txtPuntoInicioY.Text);
            int puntoFinX = int.Parse(txtPuntoFinX.Text);
            int puntoFinY = int.Parse(txtPuntoFinY.Text);

            area.Clear(Color.White);

            for (int i = 0; i < iteraciones; i++)
            {
                area.DrawLine(lapicero, puntoInicioX + (espacio * i), puntoInicioY, puntoFinX + (espacio * i), puntoFinY);
            }
        }
    }
}
