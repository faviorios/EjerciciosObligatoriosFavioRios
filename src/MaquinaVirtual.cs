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

        public abstract void Encender();
        public abstract void Apagar();
    }
}
