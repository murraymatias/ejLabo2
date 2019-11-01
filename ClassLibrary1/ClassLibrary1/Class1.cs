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

        static DAO()
        {
            string connectionString = @"Data source = .\ ; Initial Catalog = BDVet; Integrated Security=true;";
            connection = new SqlConnection(connectionString);
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
    }
}
