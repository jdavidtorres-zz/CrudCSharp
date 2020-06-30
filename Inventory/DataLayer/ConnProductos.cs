using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataLayer
{
    public class ConnProductos
    {
        private DataConnection dataConnection = new DataConnection();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = dataConnection.OpenConnection();
            comando.CommandText = "SELECT * FROM PRODUCTOS";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            return tabla;
        }
    }
}
