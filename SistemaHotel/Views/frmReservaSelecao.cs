using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using SistemaHotel.Controllers;
using SistemaHotel.Models;

namespace SistemaHotel.Views
{
    public partial class frmReservaSelecao : Form
    {
        private readonly ReservaController _controller = new ReservaController();

        public frmReservaSelecao()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!DesignMode)
            {
                CarregarRegistros(_controller.GetAll);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                if (!int.TryParse(txtCodigo.Text, out int codigo))
                {
                    Avisar("Informe um código inteiro válido.");
                    txtCodigo.Focus();
                    return;
                }

                CarregarRegistros(() => ResultadoUnico(_controller.GetById(codigo)));
            }
            else
            {
                CarregarRegistros(_controller.GetAll);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparFiltrosECarregar();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            AbrirCadastro(0, null);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Reserva registro = ObterSelecionado();
            if (registro != null)
            {
                AbrirCadastro(1, registro);
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            Reserva registro = ObterSelecionado();
            if (registro != null)
            {
                AbrirCadastro(2, registro);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Reserva registro = ObterSelecionado();
            if (registro == null ||
                MessageBox.Show(this, "Deseja excluir esta reserva?", "Confirmar exclusão",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
            {
                return;
            }

            try
            {
                if (_controller.Excluir(registro.IdReserva) <= 0)
                {
                    Avisar("O registro não foi excluído. Ele pode ter sido removido anteriormente.");
                    return;
                }
            }
            catch (SqlException)
            {
                Avisar("Não foi possível excluir o registro. Verifique a conexão com o banco de dados.");
                return;
            }

            LimparFiltrosECarregar();
        }

        private void dgvRegistros_SelectionChanged(object sender, EventArgs e)
        {
            AtualizarAcoes();
        }

        private void CarregarRegistros(Func<ReservaCollection> consultar)
        {
            ReservaCollection registros;
            try
            {
                registros = consultar();
            }
            catch (SqlException)
            {
                ExibirRegistros(new ReservaCollection());
                Avisar("Não foi possível carregar os registros. Verifique a conexão com o banco de dados.");
                return;
            }

            ExibirRegistros(registros);
        }

        private void ExibirRegistros(ReservaCollection registros)
        {
            dgvRegistros.DataSource = registros;
            dgvRegistros.ClearSelection();
            lblRegistros.Text = $"Total de registros: {registros.Count}";
            AtualizarAcoes();
        }

        private static ReservaCollection ResultadoUnico(Reserva registro)
        {
            ReservaCollection registros = new ReservaCollection();
            if (registro != null)
            {
                registros.Add(registro);
            }

            return registros;
        }

        private void LimparFiltrosECarregar()
        {
            txtCodigo.Clear();
            CarregarRegistros(_controller.GetAll);
        }

        private void AbrirCadastro(int modo, Reserva registro)
        {
            using (frmReservaCadastro cadastro = new frmReservaCadastro(modo, registro))
            {
                if (cadastro.ShowDialog(this) == DialogResult.OK)
                {
                    LimparFiltrosECarregar();
                }
            }
        }

        private Reserva ObterSelecionado()
        {
            Reserva registro = RegistroDaGrade();
            if (registro == null)
            {
                Avisar("Selecione um registro na grade.");
            }

            return registro;
        }

        private Reserva RegistroDaGrade()
        {
            return dgvRegistros.SelectedRows.Count == 0
                ? null
                : dgvRegistros.SelectedRows[0].DataBoundItem as Reserva;
        }

        private void AtualizarAcoes()
        {
            bool selecionado = RegistroDaGrade() != null;
            btnAlterar.Enabled = selecionado;
            btnVisualizar.Enabled = selecionado;
            btnExcluir.Enabled = selecionado;
        }

        private void Avisar(string mensagem)
        {
            MessageBox.Show(this, mensagem, Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
