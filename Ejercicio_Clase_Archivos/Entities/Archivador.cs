using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public static class Archivador
    {
        public static void SaveTxt(string directoryPath, bool append, string name, string text)
        {
            if (!Directory.Exists(directoryPath))
            {
                throw new Exception("Invalid path");
            }
            else
            {
                StreamWriter sr = new StreamWriter(directoryPath+"\\"+name+".txt",append);

                sr.Write(text);

                sr.Close();
            }
        }

        public static string LoadText(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new Exception("Invalid file");
            }
            else
            {
                StreamReader sr = new StreamReader(filePath);

                string text = sr.ReadToEnd();

                sr.Close();

                return text;
            }
        }
    }
}
