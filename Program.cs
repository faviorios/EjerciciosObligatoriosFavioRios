using EjerciciosObligatoriosFavioRios.src;

namespace EjerciciosObligatoriosFavioRios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<MaquinaVirtual> mv = new List<MaquinaVirtual>
            {
                new MVProcesosDatos("MV1","Linux","5.4","bdOrigen.db","bdDestino.db")
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
