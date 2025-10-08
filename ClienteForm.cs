using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleClientes
{
    public partial class ClienteForm : Form
    {
        private readonly ClienteRepository _repository;
        private int? editingId = null;

        List<ItemGenero> itemGeneros = new List<ItemGenero>
        {
            new ItemGenero {Valor = Genero.Maculino, Descricao = "Maculino" },
            new ItemGenero {Valor = Genero.Feminino, Descricao = "Feminino" },
        };
        private void CarregarGenero()
        {
            cmbGenero.DataSource = itemGeneros;
            cmbGenero.DisplayMember = "Descricao";
            cmbGenero.ValueMember = "Valor";
        }



        public ClienteForm()
        {
            InitializeComponent(); 
            CarregarGenero();    
            _repository = new ClienteRepository();
            AtualizarGrid();
        }
        private void AtualizarGrid()
        {
            var clientes = _repository.ListarTodos();
            gridClientes.DataSource = clientes;
        }
        private void LimparCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            editingId = null;
            gridClientes.ClearSelection();
        }
        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if (gridClientes.SelectedRows.Count == 0)
                return;
            var cliente = (Cliente)gridClientes.SelectedRows[0].DataBoundItem;
            txtNome.Text = cliente.Nome;
            txtEmail.Text = cliente.Email;
            editingId = cliente.Id;
            tcCliente.SelectTab(tpClienteCadastro);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            tcCliente.SelectTab(tpClienteCadastro);
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ItemGenero genero = (ItemGenero)cmbGenero.SelectedItem;
            var cliente = new Cliente
            {
                Nome = txtNome.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Genero = genero.Valor
            };
            if (editingId == null)
                _repository.Adicionar(cliente);
            else
            {
                cliente.Id = editingId.Value;
                _repository.Atualizar(cliente);
            }
            LimparCampos();
            AtualizarGrid();
            tcCliente.SelectTab(tpClienteConsulta);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tcCliente.SelectTab(tpClienteConsulta);
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (gridClientes.SelectedRows.Count == 0)
                return;
            if (MessageBox.Show("Excluir registro?", "Clientes",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var cliente = (Cliente)gridClientes.SelectedRows[0].DataBoundItem;
                _repository.Remover(cliente.Id);
                AtualizarGrid();
                tcCliente.SelectTab(tpClienteConsulta);
            }
        }

      


    }
}