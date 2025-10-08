using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleClientes
{
    public enum Genero
    {
        Maculino,
        Feminino
    }
    public class ItemGenero
    {
        public Genero Valor { get; set; }
        public string Descricao { get; set; }
    }
}
