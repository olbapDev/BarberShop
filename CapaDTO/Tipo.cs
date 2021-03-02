using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Tipo
    {
        private int idTipo;
        private string nomTipo;
        private string descripcion;

        public int IdTipo { get => idTipo; set => idTipo = value; }
        public string NomTipo { get => nomTipo; set => nomTipo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
