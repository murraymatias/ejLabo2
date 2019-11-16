using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidades;

namespace Archivos
{
    public class Texto : IArchivo<Queue<Patente>>
    {
        public void Guardar(string archivo,Queue<Patente> datos)
        {
            using (StreamWriter writer = new StreamWriter(archivo))
            {
                writer.WriteLine(datos);
            }
        }

        public void Leer(string archivo,out Queue<Patente> datos)
        {
            using (StreamReader reader = new StreamReader(archivo))
            {
                datos = new Queue<Patente>();
                while(reader.Peek() >= 0)
                {
                    Patente patente = reader.ReadLine().ValidarPatente();
                    datos.Enqueue(patente);
                }
            }
        }
    }
}
