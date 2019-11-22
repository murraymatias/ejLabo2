using System;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Security;

namespace Entities
{
    [Serializable]
    public class Persona
    {
        private string nombre;
        private string apellido;

        public Persona()
        {

        }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public string Nombre
        {
            set => nombre = value;
            get => nombre;
        }

        public string Apellido
        {
            set => apellido = value;
            get => apellido;
        }
        /// <summary>
        /// Saves a person in a XML file
        /// </summary>
        /// <param name="persona"></param>
        /// <param name="path"></param>
        /// <param name="nombre"></param>
        /// <exception cref="T:System.ArgumentException">The encoding is not supported; the filename is empty, contains only white space, or contains one or more invalid characters. </exception>
        /// <exception cref="T:System.UnauthorizedAccessException">Access is denied. </exception>
        /// <exception cref="T:System.ArgumentNullException">The filename is <see langword="null" />. </exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">The directory to write to is not found. </exception>
        /// <exception cref="T:System.IO.IOException">The filename includes an incorrect or invalid syntax for file name, directory name, or volume label syntax. </exception>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
        /// <exception cref="T:System.InvalidOperationException">An error occurred during serialization. The original exception is available using the <see cref="P:System.Exception.InnerException" /> property. </exception>
        public static void Guardar(Persona persona,string path,string nombre)
        {
            XmlTextWriter writer = new XmlTextWriter(path +"\\"+nombre + ".xml", Encoding.UTF8);
            
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(Persona));
                ser.Serialize(writer, persona);
            }
            catch (InvalidOperationException exception)
            {
                throw exception;
            }
            finally
            {
                writer.Close();
            }
        }

        /// <summary>
        /// Read a person from a file.
        /// </summary>
        /// <param name="path"></param>
        /// <returns>Person object</returns>
        /// <exception cref="T:System.IO.FileNotFoundException">The specified file cannot be found.</exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">Part of the filename or directory cannot be found.</exception>
        /// <exception cref="T:System.InvalidOperationException"></exception>
        /// <exception cref="T:System.Net.WebException">The remote filename cannot be resolved.-or-An error occurred while processing the request.</exception>
        /// <exception cref="T:System.UriFormatException">
        /// <paramref name="path" /> is not a valid URI.</exception>
        public static Persona Leer(string path)
        {
            XmlTextReader reader = new XmlTextReader(path);

            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(Persona));
                Persona persona = (Persona) ser.Deserialize(reader);

                return persona;
            }
            catch (Exception exception)
            {
                throw exception;
            }
            finally
            {
                reader.Close();
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.nombre);
            sb.AppendLine(this.apellido);
            sb.AppendLine();

            return sb.ToString();
        }
    }
}
