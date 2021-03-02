using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Servicio
    {
        private int idServicio;
        private string nomServicio;
        private string descripcion;
        private int precioBase;
        private int tipoServicio;

        public int IdServicio { get => idServicio; set => idServicio = value; }
        public string NomServicio { get => nomServicio; set => nomServicio = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int PrecioBase { get => precioBase; set => precioBase = value; }
        public int TipoServicio { get => tipoServicio; set => tipoServicio = value; }
    }
}
