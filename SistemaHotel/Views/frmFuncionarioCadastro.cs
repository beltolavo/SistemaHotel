using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using SistemaHotel.Controllers;
using SistemaHotel.Models;

namespace SistemaHotel.Views
{
    public partial class frmFuncionarioCadastro : Form
    {
        private readonly FuncionarioController _controller = new FuncionarioController();
        private readonly int _modo;
        private readonly int _codigo;

        public frmFuncionarioCadastro()
        {
            InitializeComponent();
            lblModo.Text = "Inclusão";
            Text = "Incluir Funcionário | Hospedaê";
            cmbStatusFuncionario.Items.AddRange(new object[] { "Ativo", "Inativo" });
            cmbStatusFuncionario.SelectedIndex = 0;
        }

        public frmFuncionarioCadastro(int modo, Funcionario registro) : this()
        {
            _modo = modo;
            if (_modo == 0)
            {
                return;
            }

            _codigo = registro.IdFuncionario;
            CarregarDados(registro);

            if (_modo == 2)
            {
                lblModo.Text = "Visualização";
                Text = "Visualizar Funcionário | Hospedaê";
                BloquearEdicao();
            }
            else
            {
                lblModo.Text = "Alteração";
                Text = "Alterar Funcionário | Hospedaê";
            }
        }

        private void CarregarDados(Funcionario registro)
        {
            txtCodigo.Text = _codigo.ToString();
            txtNome.Text = registro.Nome ?? string.Empty;
            txtCPF.Text = registro.CPF ?? string.Empty;
            txtTelefone.Text = registro.Telefone ?? string.Empty;
            txtEmail.Text = registro.Email ?? string.Empty;
            txtCargo.Text = registro.Cargo ?? string.Empty;
            dtpDataAdmissao.Value = registro.DataAdmissao;
            dtpDataAdmissao.Checked = true;
            txtSalario.Text = registro.Salario.ToString();
            SelecionarStatus(registro.StatusFuncionario);
        }

        private void BloquearEdicao()
        {
            txtNome.ReadOnly = true;
            txtCPF.ReadOnly = true;
            txtTelefone.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtCargo.ReadOnly = true;
            dtpDataAdmissao.Enabled = false;
            txtSalario.ReadOnly = true;
            cmbStatusFuncionario.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Text = "Fechar";
        }

        private void SelecionarStatus(string status)
        {
            int indice = cmbStatusFuncionario.FindStringExact(status);
            if (indice < 0 && !string.IsNullOrWhiteSpace(status))
            {
                indice = cmbStatusFuncionario.Items.Add(status);
            }

            if (indice >= 0)
            {
                cmbStatusFuncionario.SelectedIndex = indice;
            }
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

            if (string.IsNullOrWhiteSpace(txtCargo.Text))
            {
                Avisar("Informe o cargo.");
                txtCargo.Focus();
                return;
            }

            if (!dtpDataAdmissao.Checked)
            {
                Avisar("Informe a data de admissão.");
                dtpDataAdmissao.Focus();
                return;
            }

            if (!decimal.TryParse(txtSalario.Text, out decimal salario))
            {
                Avisar("Informe um salário válido.");
                txtSalario.Focus();
                return;
            }

            Funcionario registro = new Funcionario
            {
                IdFuncionario = _codigo,
                Nome = txtNome.Text.Trim(),
                CPF = txtCPF.Text.Trim(),
                Telefone = txtTelefone.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Cargo = txtCargo.Text.Trim(),
                DataAdmissao = dtpDataAdmissao.Value.Date,
                Salario = salario,
                StatusFuncionario = cmbStatusFuncionario.Text
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
