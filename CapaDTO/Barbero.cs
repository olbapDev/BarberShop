using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Barbero
    {
        private int idBarbero;
        private string nomBarbero;

        public int IdBarbero { get => idBarbero; set => idBarbero = value; }
        public string NomBarbero { get => nomBarbero; set => nomBarbero = value; }
    }
}
