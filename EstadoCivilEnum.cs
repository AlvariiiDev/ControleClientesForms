using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleClientes
{
    public enum EstadoCivilEnum
    {
        Casado,
        Solteiro,
        Viuvo
    }
    public class ItemEstadoCivil
    {
        public EstadoCivilEnum Valor { get; set; }
        public string Descricao { get; set; }
    }
}
