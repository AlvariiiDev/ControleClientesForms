namespace ControleClientes
{
    partial class ClienteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tcCliente = new TabControl();
            tpClienteConsulta = new TabPage();
            panel2 = new Panel();
            btnPesquisar = new Button();
            txtPesquisa = new TextBox();
            panel1 = new Panel();
            btnVisualizar = new Button();
            btnNovo = new Button();
            gridClientes = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colNome = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            tpClienteCadastro = new TabPage();
            txtCEP = new TextBox();
            label2 = new Label();
            cmbEstadoCivil = new ComboBox();
            label1 = new Label();
            cmbGenero = new ComboBox();
            btnExcluir = new Button();
            btnSalvar = new Button();
            btnCancelar = new Button();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tcCliente.SuspendLayout();
            tpClienteConsulta.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridClientes).BeginInit();
            tpClienteCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // tcCliente
            // 
            tcCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tcCliente.Controls.Add(tpClienteConsulta);
            tcCliente.Controls.Add(tpClienteCadastro);
            tcCliente.Location = new Point(2, 3);
            tcCliente.Name = "tcCliente";
            tcCliente.SelectedIndex = 0;
            tcCliente.Size = new Size(1059, 505);
            tcCliente.TabIndex = 0;
            // 
            // tpClienteConsulta
            // 
            tpClienteConsulta.Controls.Add(panel2);
            tpClienteConsulta.Controls.Add(panel1);
            tpClienteConsulta.Controls.Add(gridClientes);
            tpClienteConsulta.Location = new Point(4, 24);
            tpClienteConsulta.Name = "tpClienteConsulta";
            tpClienteConsulta.Padding = new Padding(3);
            tpClienteConsulta.Size = new Size(1051, 477);
            tpClienteConsulta.TabIndex = 0;
            tpClienteConsulta.Text = "Consulta";
            tpClienteConsulta.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.Controls.Add(btnPesquisar);
            panel2.Controls.Add(txtPesquisa);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1048, 38);
            panel2.TabIndex = 0;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Anchor = AnchorStyles.None;
            btnPesquisar.Location = new Point(855, 0);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(94, 38);
            btnPesquisar.TabIndex = 1;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Anchor = AnchorStyles.None;
            txtPesquisa.Location = new Point(99, 9);
            txtPesquisa.MaximumSize = new Size(1900, 0);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.PlaceholderText = "Pesquisar por nome";
            txtPesquisa.Size = new Size(800, 23);
            txtPesquisa.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(btnVisualizar);
            panel1.Controls.Add(btnNovo);
            panel1.Location = new Point(-4, 429);
            panel1.Name = "panel1";
            panel1.Size = new Size(1055, 42);
            panel1.TabIndex = 2;
            // 
            // btnVisualizar
            // 
            btnVisualizar.Dock = DockStyle.Right;
            btnVisualizar.Location = new Point(867, 0);
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.Size = new Size(94, 42);
            btnVisualizar.TabIndex = 1;
            btnVisualizar.Text = "Visualizar";
            btnVisualizar.UseVisualStyleBackColor = true;
            btnVisualizar.Click += btnVisualizar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Dock = DockStyle.Right;
            btnNovo.Location = new Point(961, 0);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(94, 42);
            btnNovo.TabIndex = 0;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // gridClientes
            // 
            gridClientes.AllowUserToAddRows = false;
            gridClientes.AllowUserToDeleteRows = false;
            gridClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridClientes.Columns.AddRange(new DataGridViewColumn[] { colID, colNome, colEmail });
            gridClientes.Location = new Point(-4, 41);
            gridClientes.Margin = new Padding(3, 38, 3, 3);
            gridClientes.Name = "gridClientes";
            gridClientes.ReadOnly = true;
            gridClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridClientes.Size = new Size(1055, 388);
            gridClientes.TabIndex = 2;
            // 
            // colID
            // 
            colID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colID.DataPropertyName = "id";
            colID.FillWeight = 50F;
            colID.HeaderText = "id";
            colID.Name = "colID";
            colID.ReadOnly = true;
            colID.Width = 42;
            // 
            // colNome
            // 
            colNome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNome.DataPropertyName = "Nome";
            colNome.FillWeight = 50F;
            colNome.HeaderText = "Nome";
            colNome.Name = "colNome";
            colNome.ReadOnly = true;
            // 
            // colEmail
            // 
            colEmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colEmail.DataPropertyName = "Email";
            colEmail.FillWeight = 50F;
            colEmail.HeaderText = "Email";
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            // 
            // tpClienteCadastro
            // 
            tpClienteCadastro.Controls.Add(txtCEP);
            tpClienteCadastro.Controls.Add(label2);
            tpClienteCadastro.Controls.Add(cmbEstadoCivil);
            tpClienteCadastro.Controls.Add(label1);
            tpClienteCadastro.Controls.Add(cmbGenero);
            tpClienteCadastro.Controls.Add(btnExcluir);
            tpClienteCadastro.Controls.Add(btnSalvar);
            tpClienteCadastro.Controls.Add(btnCancelar);
            tpClienteCadastro.Controls.Add(txtEmail);
            tpClienteCadastro.Controls.Add(lblEmail);
            tpClienteCadastro.Controls.Add(txtNome);
            tpClienteCadastro.Controls.Add(lblNome);
            tpClienteCadastro.Location = new Point(4, 24);
            tpClienteCadastro.Name = "tpClienteCadastro";
            tpClienteCadastro.Padding = new Padding(3);
            tpClienteCadastro.Size = new Size(1051, 477);
            tpClienteCadastro.TabIndex = 1;
            tpClienteCadastro.Text = "Cadastro";
            tpClienteCadastro.UseVisualStyleBackColor = true;
            // 
            // txtCEP
            // 
            txtCEP.Location = new Point(2, 103);
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(264, 23);
            txtCEP.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(292, 47);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 10;
            label2.Text = "Estado Civil";
            // 
            // cmbEstadoCivil
            // 
            cmbEstadoCivil.FormattingEnabled = true;
            cmbEstadoCivil.Location = new Point(292, 65);
            cmbEstadoCivil.Name = "cmbEstadoCivil";
            cmbEstadoCivil.Size = new Size(121, 23);
            cmbEstadoCivil.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(292, 3);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 1;
            label1.Text = "Genero";
            // 
            // cmbGenero
            // 
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Location = new Point(292, 21);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(121, 23);
            cmbGenero.TabIndex = 3;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnExcluir.Image = Properties.Resources.icons8_lixo_16__1_;
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.Location = new Point(6, 440);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 31);
            btnExcluir.TabIndex = 6;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvar.Location = new Point(851, 443);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 31);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.Location = new Point(951, 443);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 31);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(3, 65);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(263, 23);
            txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(3, 47);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(3, 21);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(263, 23);
            txtNome.TabIndex = 2;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(3, 3);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // ClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 507);
            Controls.Add(tcCliente);
            Name = "ClienteForm";
            Text = "ClienteForm";
            tcCliente.ResumeLayout(false);
            tpClienteConsulta.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridClientes).EndInit();
            tpClienteCadastro.ResumeLayout(false);
            tpClienteCadastro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcCliente;
        private TabPage tpClienteCadastro;
        private TextBox txtNome;
        private Label lblNome;
        private Label lblEmail;
        private TextBox txtEmail;
        private Button btnCancelar;
        private Button btnExcluir;
        private Button btnSalvar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TabPage tpClienteConsulta;
        private Panel panel1;
        private Button btnVisualizar;
        private Button btnNovo;
        private TextBox txtPesquisa;
        private Button btnPesquisar;
        private DataGridView gridClientes;
        private Panel panel2;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colNome;
        private DataGridViewTextBoxColumn colEmail;
        private Label label1;
        private ComboBox cmbGenero;
        private Label label2;
        private ComboBox cmbEstadoCivil;
        private TextBox txtCEP;
    }
}