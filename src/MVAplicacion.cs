using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosObligatoriosFavioRios.src
{
    internal class MVAplicacion: MaquinaVirtual
    {
        public string lenguajeProgramacion;
        public string versionLenguaje;
        public string baseDeDatos;
        public MVAplicacion(string nombre, string sistemaOperativo, string version, string lenguajeProgramacion, string versionLenguaje, string baseDeDatos):base(nombre, sistemaOperativo, version)
        {
            this.lenguajeProgramacion = lenguajeProgramacion;
            this.versionLenguaje = versionLenguaje;
            this.baseDeDatos = baseDeDatos;
        }

        public override void Encender()
        {
            if (string.IsNullOrEmpty(this.lenguajeProgramacion) || string.IsNullOrEmpty(this.versionLenguaje) || string.IsNullOrEmpty(this.baseDeDatos))
            {
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine($"No se puede encender la MV de Aplicacion: {base.nombre}. Faltan datos obligatorios");
                Console.WriteLine("-------------------------------------------------------\n");
            }
            else
            {
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine($"Encendiendo MV de Aplicacion: {base.nombre}");
                Console.WriteLine($"Lenguaje de Programacion: {this.lenguajeProgramacion}");
                Console.WriteLine($"Version del Lenguaje: {this.versionLenguaje}");
                Console.WriteLine($"Base de Datos asociada: {this.baseDeDatos}");
                Console.WriteLine("-------------------------------------------------------\n");
                estado = true;
            }
        }
        public override void Apagar()
        {
            if (estado)
            {
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine($"Apagando MV de Aplicacion: {base.nombre}");
                Console.WriteLine("-------------------------------------------------------\n");
                estado = false;
            }
        }
    }
}
