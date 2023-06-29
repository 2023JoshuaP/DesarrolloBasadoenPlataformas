using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PruebaLaboratorio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service2" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service2.svc o Service2.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service2 : IService2
    {
        public void RegistroDatos(string nombres, string apellidos, string sexo, string email, string direccion, string ciudad, string requerimientos)
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(basePath, "TextFile2.txt");
            using(StreamWriter writer = new StreamWriter(filePath, true)) {
                writer.WriteLine($"Nombres: {nombres}");
                writer.WriteLine($"Apellios: {apellidos}");
                writer.WriteLine($"Sexo: {sexo}");
                writer.WriteLine($"Email: {email}");
                writer.WriteLine($"Direccion: {direccion}");
                writer.WriteLine($"Ciudad: {ciudad}");
                writer.WriteLine($"Requerimientos: {requerimientos}");
                writer.WriteLine();
            }
        }
    }
}
