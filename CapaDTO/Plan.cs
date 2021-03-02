using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Plan
    {
        private int idPlan;
        private DateTime fecha;
        private string estado;
        private int valor;
        private int rut;
        private int idBarbero;

        public int IdPlan { get => idPlan; set => idPlan = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Estado { get => estado; set => estado = value; }
        public int Valor { get => valor; set => valor = value; }
        public int Rut { get => rut; set => rut = value; }
        public int IdBarbero { get => idBarbero; set => idBarbero = value; }
    }
}
