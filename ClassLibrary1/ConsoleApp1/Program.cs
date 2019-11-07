using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DAO.InsertarCliente("Lorem", "Ipsum", "123456");
                DAO.InsertarCliente("asd", "asd", "123456");
                DAO.InsertarCliente("sit", "amet", "123456");

                DAO.InsertarMascota("Asd", 14);
                DAO.InsertarMascota("QWE", 14);
                DAO.InsertarMascota("RTY", 14);
                DAO.InsertarMascota("UIO", 14);


                Console.WriteLine("Insert");

                List<Cliente> list = new List<Cliente>();
                list = DAO.LeerClientes();

                foreach(Cliente c in list)
                {
                    Console.WriteLine(c.ToString());
                }
                /*DAO.ModificarCliente(2, "Pepe", "pepe", "98765432", DateTime.Now);
                Console.WriteLine("Update");*/
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
