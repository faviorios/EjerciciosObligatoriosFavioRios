using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosObligatoriosFavioRios.src
{
    internal class MVProcesosDatos : MaquinaVirtual
    {
        public string datosOrigen;
        public string datosDestino;

        public MVProcesosDatos(string nombre, string sistemaOperativo, string version, string datosOrigen, string datosFin):base(nombre, sistemaOperativo, version)
        {
            this.datosOrigen = datosOrigen;
            this.datosDestino = datosFin;
        }

        public void ClonarBD()
        {
            Console.WriteLine("Clonando Base de datos");
        }   
        public void FiltrarBD()
        {
            Console.WriteLine("Filtrando Base de datos");
        }
        public void AlmacenarDatosEnOtraBD()
        {
            Console.WriteLine("Almacenando datos en otra Base de datos");
        }   
        public override void Encender()
        {
            if(string.IsNullOrEmpty(this.datosDestino) || string.IsNullOrEmpty(this.datosOrigen))
            {
                Console.WriteLine("No se puede encender la MV de Procesos de Datos. Faltan datos obligatorios");
            }
            else
            {
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine($"Encendiendo MV de Procesos de Datos: {base.nombre}");
                Console.WriteLine($"Acceso a datos de origen: {this.datosOrigen}");
                Console.WriteLine($"Acceso a datos de Destino: {this.datosDestino}");
                Console.WriteLine("-------------------------------------------------------\n");
                estado = true;
            }
        }
        public override void Apagar()
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine($"Apagando MV de Procesos de Datos: {base.nombre}");
            Console.WriteLine("-------------------------------------------------------\n");
            estado = false;
        }
    }
}
