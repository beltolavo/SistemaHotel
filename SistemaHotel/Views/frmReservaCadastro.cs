using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using SistemaHotel.Controllers;
using SistemaHotel.Models;

namespace SistemaHotel.Views
{
    public partial class frmReservaCadastro : Form
    {
        private readonly ReservaController _controller = new ReservaController();
        private readonly int _modo;
        private readonly int _codigo;
        private readonly int _idCliente;
        private readonly int _idQuarto;

        public frmReservaCadastro()
        {
            InitializeComponent();
            lblModo.Text = "Inclusão";
            Text = "Incluir Reserva | Hospedaê";
            cmbStatusReserva.Items.AddRange(new object[] { "Agendada", "Confirmada", "Cancelada", "Concluída" });
            cmbStatusReserva.SelectedIndex = 0;
        }

        public frmReservaCadastro(int modo, Reserva registro) : this()
        {
            _modo = modo;
            if (_modo == 0)
            {
                return;
            }

            _codigo = registro.IdReserva;
            _idCliente = registro.IdCliente;
            _idQuarto = registro.IdQuarto;
            CarregarDados(registro);

            if (_modo == 2)
            {
                lblModo.Text = "Visualização";
                Text = "Visualizar Reserva | Hospedaê";
                BloquearEdicao();
            }
            else
            {
                lblModo.Text = "Alteração";
                Text = "Alterar Reserva | Hospedaê";
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (DesignMode)
            {
                return;
            }

            ClienteCollection clientes;
            QuartoCollection quartos;
            try
            {
                clientes = new ClienteController().GetAll();
                quartos = new QuartoController().GetAll();
            }
            catch (SqlException)
            {
                btnSalvar.Enabled = false;
                Avisar("Não foi possível carregar clientes e quartos. Verifique a conexão com o banco de dados.");
                return;
            }

            cmbCliente.DisplayMember = nameof(Cliente.Nome);
            cmbCliente.ValueMember = nameof(Cliente.IdCliente);
            cmbCliente.DataSource = clientes;
            cmbCliente.SelectedIndex = -1;

            cmbQuarto.DisplayMember = nameof(Quarto.NumeroQuarto);
            cmbQuarto.ValueMember = nameof(Quarto.IdQuarto);
            cmbQuarto.DataSource = quartos;
            cmbQuarto.SelectedIndex = -1;

            if (_modo != 0)
            {
                cmbCliente.SelectedValue = _idCliente;
                cmbQuarto.SelectedValue = _idQuarto;
            }

            if (clientes.Count == 0 || quartos.Count == 0)
            {
                btnSalvar.Enabled = false;
                Avisar("Cadastre pelo menos um cliente e um quarto antes de registrar uma reserva.");
            }
        }

        private void CarregarDados(Reserva registro)
        {
            txtCodigo.Text = _codigo.ToString();
            dtpDataEntrada.Value = registro.DataEntrada;
            dtpDataEntrada.Checked = true;
            dtpDataSaida.Value = registro.DataSaida;
            dtpDataSaida.Checked = true;
            txtQuantidadeHospedes.Text = registro.QuantidadeHospedes.ToString();
            txtValorTotal.Text = registro.ValorTotal.ToString();
            SelecionarStatus(registro.StatusReserva);
        }

        private void BloquearEdicao()
        {
            cmbCliente.Enabled = false;
            cmbQuarto.Enabled = false;
            dtpDataEntrada.Enabled = false;
            dtpDataSaida.Enabled = false;
            txtQuantidadeHospedes.ReadOnly = true;
            txtValorTotal.ReadOnly = true;
            cmbStatusReserva.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Text = "Fechar";
        }

        private void SelecionarStatus(string status)
        {
            int indice = cmbStatusReserva.FindStringExact(status);
            if (indice < 0 && !string.IsNullOrWhiteSpace(status))
            {
                indice = cmbStatusReserva.Items.Add(status);
            }

            if (indice >= 0)
            {
                cmbStatusReserva.SelectedIndex = indice;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!(cmbCliente.SelectedValue is int idCliente))
            {
                Avisar("Selecione um cliente.");
                cmbCliente.Focus();
                return;
            }

            if (!(cmbQuarto.SelectedValue is int idQuarto))
            {
                Avisar("Selecione um quarto.");
                cmbQuarto.Focus();
                return;
            }

            if (!dtpDataEntrada.Checked)
            {
                Avisar("Informe a data de entrada.");
                dtpDataEntrada.Focus();
                return;
            }

            if (!dtpDataSaida.Checked || dtpDataSaida.Value.Date <= dtpDataEntrada.Value.Date)
            {
                Avisar("Informe uma data de saída posterior à data de entrada.");
                dtpDataSaida.Focus();
                return;
            }

            if (!int.TryParse(txtQuantidadeHospedes.Text, out int hospedes) || hospedes <= 0)
            {
                Avisar("Informe uma quantidade inteira e positiva de hóspedes.");
                txtQuantidadeHospedes.Focus();
                return;
            }

            if (!decimal.TryParse(txtValorTotal.Text, out decimal valorTotal))
            {
                Avisar("Informe um valor total válido.");
                txtValorTotal.Focus();
                return;
            }

            Reserva registro = new Reserva
            {
                IdReserva = _codigo,
                IdCliente = idCliente,
                IdQuarto = idQuarto,
                DataEntrada = dtpDataEntrada.Value.Date,
                DataSaida = dtpDataSaida.Value.Date,
                QuantidadeHospedes = hospedes,
                ValorTotal = valorTotal,
                StatusReserva = cmbStatusReserva.Text
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
            catch (SqlException ex) when (ex.Number == 547)
            {
                Avisar("O cliente ou o quarto selecionado não está mais disponível. Reabra o cadastro e selecione novamente.");
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
