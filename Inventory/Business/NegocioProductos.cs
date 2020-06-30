using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Business
{
    public class NegocioProductos
    {
        private ConnProductos connProductos = new ConnProductos();
        public DataTable MostrarProductos()
        {
            DataTable tabla = new DataTable();
            tabla = connProductos.Mostrar();
            return tabla;
        }
    }
}
