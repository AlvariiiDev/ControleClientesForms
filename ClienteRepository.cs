using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleClientes
{
    class ClienteRepository
    {
        private readonly AppDbContext _context;
        public ClienteRepository()
        {
            _context = new AppDbContext();
        }
        public void Adicionar(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }
        public List<Cliente> ListarTodos()
        {
            return _context.Clientes.ToList();
        }
        public Cliente ObterPorId(int id)
        {
            return _context.Clientes.Find(id);
        }
        public void Atualizar(Cliente cliente)
        {
            Cliente clienteExistente = ObterPorId(cliente.Id);
            if (clienteExistente != null)
            {
                clienteExistente.Nome = cliente.Nome;
                clienteExistente.Email = cliente.Email;
                clienteExistente.Genero = cliente.Genero;
                clienteExistente.EstadoCivil = cliente.EstadoCivil;
                _context.SaveChanges();
            }
        }
        public void Remover(int id)
        {
            var cliente = _context.Clientes.Find(id);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                _context.SaveChanges();
            }
        }
    }
}
