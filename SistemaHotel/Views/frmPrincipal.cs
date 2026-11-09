using System;
using System.Windows.Forms;

namespace SistemaHotel.Views
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void tsmiClientes_Click(object sender, EventArgs e)
        {
            using (frmClienteSelecao selecao = new frmClienteSelecao())
            {
                selecao.ShowDialog(this);
            }
        }

        private void tsmiQuartos_Click(object sender, EventArgs e)
        {
            using (frmQuartoSelecao selecao = new frmQuartoSelecao())
            {
                selecao.ShowDialog(this);
            }
        }

        private void tsmiFuncionarios_Click(object sender, EventArgs e)
        {
            using (frmFuncionarioSelecao selecao = new frmFuncionarioSelecao())
            {
                selecao.ShowDialog(this);
            }
        }

        private void tsmiReservas_Click(object sender, EventArgs e)
        {
            using (frmReservaSelecao selecao = new frmReservaSelecao())
            {
                selecao.ShowDialog(this);
            }
        }

        private void tsmiSobre_Click(object sender, EventArgs e)
        {
            using (frmSobre sobre = new frmSobre())
            {
                sobre.ShowDialog(this);
            }
        }
    }
}
