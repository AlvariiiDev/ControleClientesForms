using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleClientes
{
    class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public Genero Genero { get; set; }
        public EstadoCivilEnum EstadoCivil { get; set; }
        public string Cep { get; set; }
    }
}
