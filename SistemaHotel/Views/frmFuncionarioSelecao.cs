using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using SistemaHotel.Controllers;
using SistemaHotel.Models;

namespace SistemaHotel.Views
{
    public partial class frmFuncionarioSelecao : Form
    {
        private readonly FuncionarioController _controller = new FuncionarioController();

        public frmFuncionarioSelecao()
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
            else if (!string.IsNullOrWhiteSpace(txtNome.Text))
            {
                CarregarRegistros(() => _controller.GetByName(txtNome.Text.Trim()));
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
            Funcionario registro = ObterSelecionado();
            if (registro != null)
            {
                AbrirCadastro(1, registro);
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            Funcionario registro = ObterSelecionado();
            if (registro != null)
            {
                AbrirCadastro(2, registro);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Funcionario registro = ObterSelecionado();
            if (registro == null ||
                MessageBox.Show(this, "Deseja excluir este funcionário?", "Confirmar exclusão",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
            {
                return;
            }

            try
            {
                if (_controller.Excluir(registro.IdFuncionario) <= 0)
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

        private void CarregarRegistros(Func<FuncionarioCollection> consultar)
        {
            FuncionarioCollection registros;
            try
            {
                registros = consultar();
            }
            catch (SqlException)
            {
                ExibirRegistros(new FuncionarioCollection());
                Avisar("Não foi possível carregar os registros. Verifique a conexão com o banco de dados.");
                return;
            }

            ExibirRegistros(registros);
        }

        private void ExibirRegistros(FuncionarioCollection registros)
        {
            dgvRegistros.DataSource = registros;
            dgvRegistros.ClearSelection();
            lblRegistros.Text = $"Total de registros: {registros.Count}";
            AtualizarAcoes();
        }

        private static FuncionarioCollection ResultadoUnico(Funcionario registro)
        {
            FuncionarioCollection registros = new FuncionarioCollection();
            if (registro != null)
            {
                registros.Add(registro);
            }

            return registros;
        }

        private void LimparFiltrosECarregar()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            CarregarRegistros(_controller.GetAll);
        }

        private void AbrirCadastro(int modo, Funcionario registro)
        {
            using (frmFuncionarioCadastro cadastro = new frmFuncionarioCadastro(modo, registro))
            {
                if (cadastro.ShowDialog(this) == DialogResult.OK)
                {
                    LimparFiltrosECarregar();
                }
            }
        }

        private Funcionario ObterSelecionado()
        {
            Funcionario registro = RegistroDaGrade();
            if (registro == null)
            {
                Avisar("Selecione um registro na grade.");
            }

            return registro;
        }

        private Funcionario RegistroDaGrade()
        {
            return dgvRegistros.SelectedRows.Count == 0
                ? null
                : dgvRegistros.SelectedRows[0].DataBoundItem as Funcionario;
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
