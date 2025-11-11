using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosObligatoriosFavioRios.src
{
    internal abstract class MaquinaVirtual
    {
        protected string nombre;
        protected string sistemaOperativo;
        protected string version;
        protected bool estado;

        public MaquinaVirtual(string nombre, string sistemaOperativo, string version)
        {
            this.nombre = nombre;
            this.sistemaOperativo = sistemaOperativo;
            this.version = version;
            estado = false;
        }

        public abstract void Encender();
        public abstract void Apagar();
    }
}
