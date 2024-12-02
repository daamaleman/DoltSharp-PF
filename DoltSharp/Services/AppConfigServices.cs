using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoltSharp.Services
{
    public class AppConfigServices
    {
        public bool MyDarkMode { get; set; }
        public string MyStyle { get; set; }
        // Guardar configuracion en un archivo dat
        public void SaveConfigFile()
        {
            string filePath = "configuracion.dat";

            using (FileStream myFile = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                using (BinaryWriter writer = new BinaryWriter(myFile))
                {
                    writer.Write(MyDarkMode);
                    writer.Write(MyStyle);
                }
            }
        }

        // Leer configuracion de un archivo dat
        public void LoadConfigFile()
        {
            string filePath = "configuracion.dat";
            using (FileStream myFile = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader reader = new BinaryReader(myFile))
                {
                    MyDarkMode = reader.ReadBoolean();
                    MyStyle = reader.ReadString();
                }
            }
        }
    }
}
