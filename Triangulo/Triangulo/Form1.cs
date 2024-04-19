using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangulo
{
    public partial class frmTriangulo : Form
    {
        // instancia del modelo
        
        private TrianguloModelo modelo;
        public frmTriangulo()
        {
            InitializeComponent();
            modelo = new TrianguloModelo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void CargarBase()
        {
            modelo.SetBase(double.Parse(txtBASE.Text));
           
        }

        public void CargarAltura()
        {
            modelo.SetAltura(double.Parse(txtAltura.Text));
        }

        public void MostrarResultado()
        {
            txtResultado.Text = ""+ modelo.AreaTriangulo();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CargarBase();
            CargarAltura();
            MostrarResultado();
        }
    }
}
