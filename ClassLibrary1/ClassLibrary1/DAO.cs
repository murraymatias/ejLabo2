﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ClassLibrary1
{
    public class DAO
    {
        private static SqlConnection connection;
        private static SqlCommand command;
        private static string connectionString;

        static DAO()
        {
            DAO.connectionString = @"Server = .\SQLEXPRESS; Database = BDVet; Trusted_Connection=true;";
            connection = new SqlConnection(DAO.connectionString);
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }

        public static void InsertarCliente(string nombre,string apellido, string dni)
        {
            try
            {
                connection.Open();
                string comando = string.Format("INSERT INTO CLIENTES (nombre,apellido,dni) VALUES ('{0}','{1}','{2}')",nombre,apellido,dni);

                command.CommandText = comando;
                command.ExecuteNonQuery();
            }
            finally
            {
                if(connection.State == System.Data.ConnectionState.Open && connection != null)
                {
                    connection.Close();
                }
            }
        }

        public static void ModificarCliente(int id,string nombre, string apellido, string dni,DateTime? fechaNac)
        {
            using(SqlConnection connection = new SqlConnection(DAO.connectionString))
            {
                string comando = "UPDATE CLIENTES SET"+
                                 " nombre = @nombre,"+
                                 " apellido = @apellido,"+
                                 " dni = @dni,"+
                                 " fecha_nacimiento = @fechaNacimiento "+
                                 "WHERE id = @id;";
                SqlCommand command = new SqlCommand(comando,connection);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@apellido", apellido);
                command.Parameters.AddWithValue("@dni", dni);
                command.Parameters.AddWithValue("@fechaNacimiento", fechaNac);
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static void BorrarCliente(int id)
        {
            using(SqlConnection connection = new SqlConnection(DAO.connectionString))
            {
                string commandString = "DELETE FROM Clientes WHERE id = @id;";

                SqlCommand command = new SqlCommand(commandString, connection);
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static void InsertarMascota(string nombre,int idCliente)
        {
            using(SqlConnection connection = new SqlConnection(DAO.connectionString))
            {
                string comando = "INSERT INTO Mascotas (nombre,idHumano) VALUES (@nombre,@idCliente);";

                SqlCommand command = new SqlCommand(comando,connection);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@idCliente", idCliente);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        /*
        public static void ActualizarFecha(DateTime fecha)
        {
            using (SqlConnection connection = new SqlConnection(DAO.connectionString))
            {
                string comando = "SELECT id FROM Clientes";

                List<int> lista = new List<int>;

                SqlCommand command = new SqlCommand(comando, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add((int)reader["id"]);
                }

                foreach(int i in lista)
                {
                    command.CommandText(string.Format("UPDATE Clientes SET fecha"))
                }
            }*/

        public static List<Cliente> LeerClientes()
        {
            using(SqlConnection connection = new SqlConnection(DAO.connectionString))
            {
                string comando = "SELECT id, nombre, apellido, dni, fecha_nacimiento FROM Clientes;";

                SqlCommand command = new SqlCommand(comando, connection);
                connection.Open();
                SqlDataReader dataReader = command.ExecuteReader();
                List<Cliente> lista = new List<Cliente>();

                while (dataReader.Read())
                {
                    int id = dataReader.GetInt32(0);
                    string nombre = dataReader.GetString(1);
                    string apellido = dataReader.GetString(2);
                    string dni = dataReader.GetString(3);
                    DateTime? fechaNacimiento = null;
                    if (!dataReader.IsDBNull(4))
                    {
                        fechaNacimiento = dataReader.GetDateTime(4);
                    }

                    Cliente cliente = new Cliente(id, nombre, apellido, dni, fechaNacimiento);
                    lista.Add(cliente);
                }

                return lista;
            }
        }
    }    
}
