using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

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

        List<ItemEstadoCivil> estadoCivil = new List<ItemEstadoCivil>
        {
            new ItemEstadoCivil {Valor = EstadoCivilEnum.Casado, Descricao = "Casado" },
            new ItemEstadoCivil {Valor = EstadoCivilEnum.Solteiro, Descricao = "Solteiro" },
        };
        private void CarregarEstadoCivil()
        {
            cmbEstadoCivil.DataSource = estadoCivil;
            cmbEstadoCivil.DisplayMember = "Descricao";
            cmbEstadoCivil.ValueMember = "Valor";
        }



        public ClienteForm()
        {

            InitializeComponent();
            CarregarGenero();
            _repository = new ClienteRepository();
            AtualizarGrid();
            CarregarEstadoCivil();
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
            cmbGenero.SelectedIndex = -1;
            editingId = null;
            gridClientes.ClearSelection();
            cmbEstadoCivil.SelectedIndex = -1;
            txtCEP.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtLogradouro.Clear();
            txtNumero.Clear();
        }
        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if (gridClientes.SelectedRows.Count == 0)
                return;
            var cliente = (Cliente)gridClientes.SelectedRows[0].DataBoundItem;
            txtNome.Text = cliente.Nome;
            txtEmail.Text = cliente.Email;
            editingId = cliente.Id;
            cmbGenero.SelectedItem = itemGeneros.FirstOrDefault(
                g => g.Valor == cliente.Genero);
            cmbEstadoCivil.SelectedItem = estadoCivil.FirstOrDefault(
                g => g.Valor == cliente.EstadoCivil);
            txtCEP.Text = cliente.Cep;
            txtLogradouro.Text = cliente.Logradouro;
            txtUf.Text = cliente.Uf;
            txtCidade.Text = cliente.Cidade;
            txtNumero.Text = cliente.Numero;
            txtBairro.Text = cliente.Bairro;

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

            ItemEstadoCivil estadoCivil = (ItemEstadoCivil)cmbEstadoCivil.SelectedItem;
            var cliente = new Cliente
            {
                Nome = txtNome.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Genero = genero.Valor,
                EstadoCivil = estadoCivil.Valor,
                Cep = txtCEP.Text.Trim(),
                Numero = txtNumero.Text.Trim(),
                Cidade = txtCidade.Text.Trim(),
                Uf = txtUf.Text.Trim(),
                Bairro = txtBairro.Text.Trim(),
                Logradouro = txtLogradouro.Text.Trim(),
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
        private async Task<Endereco> BuscarCepAsync(string cep)
        {
            string url = $"https://viacep.com.br/ws/{cep}/json/";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    return JsonSerializer.Deserialize<Endereco>(responseBody);
                }
                else
                    throw new Exception($"Consultando o CEP. Código de status: {response.StatusCode}");
            }
        }

        private async void txtCep_Leave_Click(object sender, EventArgs e)
        {
            string cep = txtCEP.Text.Trim().Replace("-", "");

            if (string.IsNullOrEmpty(cep))
            {
                MessageBox.Show("Por favor, insira um CEP válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Endereco endereco = await BuscarCepAsync(cep);

                if (endereco != null)
                {
                    txtLogradouro.Text = endereco.Logradouro;
                    txtBairro.Text = endereco.Bairro;
                    txtCidade.Text = endereco.Localidade;
                    txtUf.Text = endereco.Uf;
                    txtNumero.Focus();
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Erro na requisição HTTP: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (JsonException ex)
            {
                MessageBox.Show($"Erro ao ler o retorno JSON: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
