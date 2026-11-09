using System.Drawing;
using System.Windows.Forms;

namespace SistemaHotel.Views
{
    partial class frmPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer do Windows Forms

        private void InitializeComponent()
        {
            this.menuStripPrincipal = new MenuStrip();
            this.tsmiCadastros = new ToolStripMenuItem();
            this.tsmiSobre = new ToolStripMenuItem();
            this.tsmiClientes = new ToolStripMenuItem();
            this.tsmiQuartos = new ToolStripMenuItem();
            this.tsmiFuncionarios = new ToolStripMenuItem();
            this.tsmiReservas = new ToolStripMenuItem();
            this.pnlCabecalho = new Panel();
            this.lblNomeSistema = new Label();
            this.lblIdentificacao = new Label();
            this.pnlBoasVindas = new Panel();
            this.lblBoasVindas = new Label();
            this.lblIntroducao = new Label();
            this.pnlRodape = new Panel();
            this.lblRodape = new Label();
            this.menuStripPrincipal.SuspendLayout();
            this.pnlCabecalho.SuspendLayout();
            this.pnlBoasVindas.SuspendLayout();
            this.pnlRodape.SuspendLayout();
            this.SuspendLayout();

            // menuStripPrincipal
            this.menuStripPrincipal.AutoSize = false;
            this.menuStripPrincipal.BackColor = Color.FromArgb(231, 237, 237);
            this.menuStripPrincipal.Dock = DockStyle.Top;
            this.menuStripPrincipal.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            this.menuStripPrincipal.Items.AddRange(new ToolStripItem[] {
                this.tsmiCadastros, this.tsmiSobre
            });
            this.menuStripPrincipal.Location = new Point(0, 0);
            this.menuStripPrincipal.Name = "menuStripPrincipal";
            this.menuStripPrincipal.Padding = new Padding(20, 2, 0, 2);
            this.menuStripPrincipal.Size = new Size(960, 32);
            this.menuStripPrincipal.TabIndex = 0;

            // tsmiCadastros
            this.tsmiCadastros.DropDownItems.AddRange(new ToolStripItem[] {
                this.tsmiClientes, this.tsmiQuartos, this.tsmiFuncionarios, this.tsmiReservas
            });
            this.tsmiCadastros.ForeColor = Color.FromArgb(22, 101, 93);
            this.tsmiCadastros.Name = "tsmiCadastros";
            this.tsmiCadastros.Text = "Cadastros";

            // tsmiClientes
            this.tsmiClientes.Name = "tsmiClientes";
            this.tsmiClientes.Click += new System.EventHandler(this.tsmiClientes_Click);
            this.tsmiClientes.Text = "Clientes";

            // tsmiQuartos
            this.tsmiQuartos.Name = "tsmiQuartos";
            this.tsmiQuartos.Click += new System.EventHandler(this.tsmiQuartos_Click);
            this.tsmiQuartos.Text = "Quartos";

            // tsmiFuncionarios
            this.tsmiFuncionarios.Name = "tsmiFuncionarios";
            this.tsmiFuncionarios.Click += new System.EventHandler(this.tsmiFuncionarios_Click);
            this.tsmiFuncionarios.Text = "Funcionários";

            // tsmiReservas
            this.tsmiReservas.Name = "tsmiReservas";
            this.tsmiReservas.Click += new System.EventHandler(this.tsmiReservas_Click);
            this.tsmiReservas.Text = "Reservas";

            // tsmiSobre
            this.tsmiSobre.ForeColor = Color.FromArgb(22, 101, 93);
            this.tsmiSobre.Name = "tsmiSobre";
            this.tsmiSobre.Text = "Sobre";
            this.tsmiSobre.Click += new System.EventHandler(this.tsmiSobre_Click);

            // pnlCabecalho
            this.pnlCabecalho.Location = new Point(0, 32);
            this.pnlCabecalho.Name = "pnlCabecalho";
            this.pnlCabecalho.Size = new Size(960, 108);
            this.pnlCabecalho.TabIndex = 1;
            this.pnlCabecalho.BackColor = Color.FromArgb(22, 40, 59);
            this.pnlCabecalho.Dock = DockStyle.Top;

            // lblNomeSistema
            this.lblNomeSistema.Location = new Point(28, 15);
            this.lblNomeSistema.Name = "lblNomeSistema";
            this.lblNomeSistema.Size = new Size(640, 48);
            this.lblNomeSistema.ForeColor = Color.FromArgb(255, 255, 255);
            this.lblNomeSistema.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblNomeSistema.Text = "Hospedaê";
            this.lblNomeSistema.TextAlign = ContentAlignment.MiddleLeft;

            // lblIdentificacao
            this.lblIdentificacao.Location = new Point(30, 64);
            this.lblIdentificacao.Name = "lblIdentificacao";
            this.lblIdentificacao.Size = new Size(640, 24);
            this.lblIdentificacao.ForeColor = Color.FromArgb(215, 226, 231);
            this.lblIdentificacao.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            this.lblIdentificacao.Text = "Gestão de cadastros e hospedagem";
            this.lblIdentificacao.TextAlign = ContentAlignment.MiddleLeft;

            // pnlBoasVindas
            this.pnlBoasVindas.Location = new Point(28, 164);
            this.pnlBoasVindas.Name = "pnlBoasVindas";
            this.pnlBoasVindas.Size = new Size(904, 296);
            this.pnlBoasVindas.TabIndex = 2;
            this.pnlBoasVindas.BackColor = Color.FromArgb(255, 255, 255);
            this.pnlBoasVindas.BackgroundImage = global::SistemaHotel.Properties.Resources.ImagemHotelBoasVindas;
            this.pnlBoasVindas.BackgroundImageLayout = ImageLayout.Zoom;
            this.pnlBoasVindas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            // lblBoasVindas
            this.lblBoasVindas.Location = new Point(30, 42);
            this.lblBoasVindas.Name = "lblBoasVindas";
            this.lblBoasVindas.BackColor = Color.Transparent;
            this.lblBoasVindas.Size = new Size(400, 54);
            this.lblBoasVindas.ForeColor = Color.FromArgb(22, 40, 59);
            this.lblBoasVindas.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblBoasVindas.Text = "Bem-vindo ao Hospedaê";
            this.lblBoasVindas.TextAlign = ContentAlignment.MiddleLeft;

            // lblIntroducao
            this.lblIntroducao.Location = new Point(32, 103);
            this.lblIntroducao.Name = "lblIntroducao";
            this.lblIntroducao.BackColor = Color.Transparent;
            this.lblIntroducao.Size = new Size(365, 62);
            this.lblIntroducao.ForeColor = Color.FromArgb(78, 92, 101);
            this.lblIntroducao.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            this.lblIntroducao.Text = "Os cadastros de clientes, quartos, funcionários e reservas estão organizados no menu Cadastros.";
            this.lblIntroducao.TextAlign = ContentAlignment.MiddleLeft;

            // pnlRodape
            this.pnlRodape.Location = new Point(28, 476);
            this.pnlRodape.Name = "pnlRodape";
            this.pnlRodape.Size = new Size(904, 32);
            this.pnlRodape.TabIndex = 3;
            this.pnlRodape.BackColor = Color.FromArgb(246, 243, 237);
            this.pnlRodape.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            // lblRodape
            this.lblRodape.Location = new Point(0, 0);
            this.lblRodape.Name = "lblRodape";
            this.lblRodape.Size = new Size(360, 32);
            this.lblRodape.ForeColor = Color.FromArgb(78, 92, 101);
            this.lblRodape.Text = "Hospedaê  /  Gestão hoteleira";
            this.lblRodape.TextAlign = ContentAlignment.MiddleLeft;

            // frmPrincipal
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(246, 243, 237);
            this.ClientSize = new Size(960, 528);
            this.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            this.ForeColor = Color.FromArgb(36, 51, 62);
            this.MainMenuStrip = this.menuStripPrincipal;
            this.Icon = global::SistemaHotel.Properties.Resources.LogoSistema;
            this.Name = "frmPrincipal";
            this.MinimumSize = new Size(900, 540);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Hospedaê";
            this.Controls.Add(this.pnlCabecalho);
            this.pnlCabecalho.Controls.Add(this.lblNomeSistema);
            this.pnlCabecalho.Controls.Add(this.lblIdentificacao);
            this.Controls.Add(this.pnlBoasVindas);
            this.pnlBoasVindas.Controls.Add(this.lblBoasVindas);
            this.pnlBoasVindas.Controls.Add(this.lblIntroducao);
            this.Controls.Add(this.pnlRodape);
            this.pnlRodape.Controls.Add(this.lblRodape);
            this.Controls.Add(this.menuStripPrincipal);
            this.menuStripPrincipal.ResumeLayout(false);
            this.menuStripPrincipal.PerformLayout();
            this.pnlCabecalho.ResumeLayout(false);
            this.pnlCabecalho.PerformLayout();
            this.pnlBoasVindas.ResumeLayout(false);
            this.pnlBoasVindas.PerformLayout();
            this.pnlRodape.ResumeLayout(false);
            this.pnlRodape.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStripPrincipal;
        private ToolStripMenuItem tsmiCadastros;
        private ToolStripMenuItem tsmiSobre;
        private ToolStripMenuItem tsmiClientes;
        private ToolStripMenuItem tsmiQuartos;
        private ToolStripMenuItem tsmiFuncionarios;
        private ToolStripMenuItem tsmiReservas;
        private Panel pnlCabecalho;
        private Label lblNomeSistema;
        private Label lblIdentificacao;
        private Panel pnlBoasVindas;
        private Label lblBoasVindas;
        private Label lblIntroducao;
        private Panel pnlRodape;
        private Label lblRodape;
    }
}
