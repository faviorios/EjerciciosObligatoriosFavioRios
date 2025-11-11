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
        public string datosFin;

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

        public override void Apagar()
        {
            Console.WriteLine("Apagando MV de Procesos de Datos");
            estado = false;
        }
        public override void Encender()
        {
            if(string.IsNullOrEmpty(datosFin) || string.IsNullOrEmpty(datosOrigen))
            {
                Console.WriteLine("No se puede encender la MV de Procesos de Datos. Faltan datos obligatorios");
            }
            else
            {
                Console.WriteLine("Encendiendo MV de Procesos de Datos");
                estado = true;
            }
        }

    }
}
