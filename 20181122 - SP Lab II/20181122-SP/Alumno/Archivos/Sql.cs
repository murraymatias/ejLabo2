using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace Archivos
{
    public class Sql : IArchivo<Queue<Patente>>
    {
        private SqlCommand comando;
        private SqlConnection conexion;

        public void Guardar(string tabla, Queue<Patente> datos)
        {
            throw new NotImplementedException();
        }

        public void Leer(string tabla, out Queue<Patente> datos)
        {
            throw new NotImplementedException();
        }

        public Sql()
        {
            throw new NotImplementedException();
        }
    }
}
