using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using SistemaHotel.Controllers;
using SistemaHotel.Models;

namespace SistemaHotel.Views
{
    public partial class frmQuartoCadastro : Form
    {
        private readonly QuartoController _controller = new QuartoController();
        private readonly int _modo;
        private readonly int _codigo;

        public frmQuartoCadastro()
        {
            InitializeComponent();
            lblModo.Text = "Inclusão";
            Text = "Incluir Quarto | Hospedaê";
            cmbStatusQuarto.Items.AddRange(new object[] { "Disponível", "Ocupado", "Em manutenção" });
            cmbStatusQuarto.SelectedIndex = 0;
        }

        public frmQuartoCadastro(int modo, Quarto registro) : this()
        {
            _modo = modo;
            if (_modo == 0)
            {
                return;
            }

            _codigo = registro.IdQuarto;
            CarregarDados(registro);

            if (_modo == 2)
            {
                lblModo.Text = "Visualização";
                Text = "Visualizar Quarto | Hospedaê";
                BloquearEdicao();
            }
            else
            {
                lblModo.Text = "Alteração";
                Text = "Alterar Quarto | Hospedaê";
            }
        }

        private void CarregarDados(Quarto registro)
        {
            txtCodigo.Text = _codigo.ToString();
            txtNumeroQuarto.Text = registro.NumeroQuarto.ToString();
            txtTipo.Text = registro.Tipo ?? string.Empty;
            txtCapacidade.Text = registro.Capacidade.ToString();
            txtValorDiaria.Text = registro.ValorDiaria.ToString();
            SelecionarStatus(registro.StatusQuarto);
            txtAndar.Text = registro.Andar?.ToString() ?? string.Empty;
            txtDescricao.Text = registro.Descricao ?? string.Empty;
        }

        private void BloquearEdicao()
        {
            txtNumeroQuarto.ReadOnly = true;
            txtTipo.ReadOnly = true;
            txtCapacidade.ReadOnly = true;
            txtValorDiaria.ReadOnly = true;
            cmbStatusQuarto.Enabled = false;
            txtAndar.ReadOnly = true;
            txtDescricao.ReadOnly = true;
            btnSalvar.Enabled = false;
            btnCancelar.Text = "Fechar";
        }

        private void SelecionarStatus(string status)
        {
            if (string.Equals(status, "Disponivel", StringComparison.OrdinalIgnoreCase))
            {
                status = "Disponível";
            }

            int indice = cmbStatusQuarto.FindStringExact(status);
            if (indice < 0 && !string.IsNullOrWhiteSpace(status))
            {
                indice = cmbStatusQuarto.Items.Add(status);
            }

            if (indice >= 0)
            {
                cmbStatusQuarto.SelectedIndex = indice;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNumeroQuarto.Text, out int numero))
            {
                Avisar("Informe um número de quarto inteiro válido.");
                txtNumeroQuarto.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTipo.Text))
            {
                Avisar("Informe o tipo de quarto.");
                txtTipo.Focus();
                return;
            }

            if (!int.TryParse(txtCapacidade.Text, out int capacidade))
            {
                Avisar("Informe uma capacidade inteira válida.");
                txtCapacidade.Focus();
                return;
            }

            if (!decimal.TryParse(txtValorDiaria.Text, out decimal diaria))
            {
                Avisar("Informe um valor de diária válido.");
                txtValorDiaria.Focus();
                return;
            }

            int? andar = null;
            if (!string.IsNullOrWhiteSpace(txtAndar.Text))
            {
                if (!int.TryParse(txtAndar.Text, out int numeroAndar))
                {
                    Avisar("Informe um andar inteiro válido.");
                    txtAndar.Focus();
                    return;
                }

                andar = numeroAndar;
            }

            Quarto registro = new Quarto
            {
                IdQuarto = _codigo,
                NumeroQuarto = numero,
                Tipo = txtTipo.Text.Trim(),
                Capacidade = capacidade,
                ValorDiaria = diaria,
                StatusQuarto = cmbStatusQuarto.Text == "Disponível" ? "Disponivel" : cmbStatusQuarto.Text,
                Andar = andar,
                Descricao = txtDescricao.Text.Trim()
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
                Avisar("Este número de quarto já está cadastrado. O registro duplicado não foi salvo.");
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
