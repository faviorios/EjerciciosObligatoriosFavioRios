using EjerciciosObligatoriosFavioRios.src;

namespace EjerciciosObligatoriosFavioRios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<MaquinaVirtual> mv = new List<MaquinaVirtual>
            {
                new MVProcesosDatos("MV1","Linux","5.4","bdOrigen.db","bdDestino.db"),
                new MVAplicacion("MV2","Windows","7","C#","9.0","bdApp.db"),
                new MVProcesosDatos("MV3","Ubuntu","1.0","","bdDestino.db"),
                new MVAplicacion("MV4","IOS","14","ReactJS","18.2","SQLite.db")
            };

            Console.WriteLine("////////Encendiendo MVs////////\n");
            foreach (var item in mv)
            {
                item.Encender();
            }

            Console.WriteLine("////////Apagando MVs////////\n");
            foreach (var item in mv)
            {
                item.Apagar();
            }

        }
    }
}
