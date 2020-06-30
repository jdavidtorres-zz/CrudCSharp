using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        NegocioProductos negocioProducto = new NegocioProductos();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarProductos();
        }

        private void MostrarProductos()
        {
            dataGridView1.DataSource = negocioProducto.MostrarProductos();
        }
    }
}
