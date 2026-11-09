using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using SistemaHotel.Controllers;
using SistemaHotel.Models;

namespace SistemaHotel.Views
{
    public partial class frmClienteCadastro : Form
    {
        private readonly ClienteController _controller = new ClienteController();
        private readonly int _modo;
        private readonly int _codigo;

        public frmClienteCadastro()
        {
            InitializeComponent();
            lblModo.Text = "Inclusão";
            Text = "Incluir Cliente | Hospedaê";
        }

        public frmClienteCadastro(int modo, Cliente registro) : this()
        {
            _modo = modo;
            if (_modo == 0)
            {
                return;
            }

            _codigo = registro.IdCliente;
            CarregarDados(registro);

            if (_modo == 2)
            {
                lblModo.Text = "Visualização";
                Text = "Visualizar Cliente | Hospedaê";
                BloquearEdicao();
            }
            else
            {
                lblModo.Text = "Alteração";
                Text = "Alterar Cliente | Hospedaê";
            }
        }

        private void CarregarDados(Cliente registro)
        {
            txtCodigo.Text = _codigo.ToString();
            txtNome.Text = registro.Nome ?? string.Empty;
            txtCPF.Text = registro.CPF ?? string.Empty;
            dtpDataNascimento.Value = registro.DataNascimento;
            dtpDataNascimento.Checked = true;
            txtTelefone.Text = registro.Telefone ?? string.Empty;
            txtEmail.Text = registro.Email ?? string.Empty;
            txtEndereco.Text = registro.Endereco ?? string.Empty;
            txtCidade.Text = registro.Cidade ?? string.Empty;
        }

        private void BloquearEdicao()
        {
            txtNome.ReadOnly = true;
            txtCPF.ReadOnly = true;
            dtpDataNascimento.Enabled = false;
            txtTelefone.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtEndereco.ReadOnly = true;
            txtCidade.ReadOnly = true;
            btnSalvar.Enabled = false;
            btnCancelar.Text = "Fechar";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                Avisar("Informe o nome.");
                txtNome.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCPF.Text))
            {
                Avisar("Informe o CPF.");
                txtCPF.Focus();
                return;
            }

            if (!dtpDataNascimento.Checked)
            {
                Avisar("Informe a data de nascimento.");
                dtpDataNascimento.Focus();
                return;
            }

            Cliente registro = new Cliente
            {
                IdCliente = _codigo,
                Nome = txtNome.Text.Trim(),
                CPF = txtCPF.Text.Trim(),
                DataNascimento = dtpDataNascimento.Value.Date,
                Telefone = txtTelefone.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Endereco = txtEndereco.Text.Trim(),
                Cidade = txtCidade.Text.Trim()
            };

            try
            {
                int alterados = _modo == 0 ? _controller.Inserir(registro) : _controller.Alterar(registro);
                if (alterados <= 0)
                {
                    Avisar("O registro não foi salvo. Ele pode ter sido removido anteriormente.");
                    return;
                }
            }
            catch (SqlException ex) when (ex.Number == 2601 || ex.Number == 2627)
            {
                Avisar("Este CPF já está cadastrado. O registro duplicado não foi salvo.");
                return;
            }
            catch (SqlException)
            {
                Avisar("Não foi possível salvar o registro. Verifique os dados e a conexão com o banco.");
                return;
            }

            DialogResult = DialogResult.OK;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (!e.Cancel && _modo != 2 && DialogResult != DialogResult.OK &&
                (e.CloseReason == CloseReason.UserClosing || e.CloseReason == CloseReason.None))
            {
                e.Cancel = MessageBox.Show(this, "Deseja fechar sem salvar?", "Confirmar cancelamento",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes;
            }
        }

        private void Avisar(string mensagem)
        {
            MessageBox.Show(this, mensagem, Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
