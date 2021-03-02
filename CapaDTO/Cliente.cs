using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Cliente
    {
        private int rut;
        private string nomCliente;
        private string apCliente;
        private string direccion;
        private int telefono;

        public int Rut { get => rut; set => rut = value; }
        public string NomCliente { get => nomCliente; set => nomCliente = value; }
        public string ApCliente { get => apCliente; set => apCliente = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Telefono { get => telefono; set => telefono = value; }
    }
}
