using System.Drawing;
using System.Windows.Forms;

namespace SistemaHotel.Views
{
    partial class frmQuartoCadastro
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
            this.pnlCabecalho = new Panel();
            this.pnlDestaque = new Panel();
            this.lblTitulo = new Label();
            this.lblSubtitulo = new Label();
            this.pnlCampos = new Panel();
            this.lblCodigo = new Label();
            this.txtCodigo = new TextBox();
            this.lblNumeroQuarto = new Label();
            this.txtNumeroQuarto = new TextBox();
            this.lblTipo = new Label();
            this.txtTipo = new TextBox();
            this.lblCapacidade = new Label();
            this.txtCapacidade = new TextBox();
            this.lblValorDiaria = new Label();
            this.txtValorDiaria = new TextBox();
            this.lblStatusQuarto = new Label();
            this.cmbStatusQuarto = new ComboBox();
            this.lblAndar = new Label();
            this.txtAndar = new TextBox();
            this.lblDescricao = new Label();
            this.txtDescricao = new TextBox();
            this.pnlRodape = new Panel();
            this.lblModo = new Label();
            this.btnCancelar = new Button();
            this.btnSalvar = new Button();
            this.pnlCabecalho.SuspendLayout();
            this.pnlDestaque.SuspendLayout();
            this.pnlCampos.SuspendLayout();
            this.pnlRodape.SuspendLayout();
            this.SuspendLayout();

            // pnlCabecalho
            this.pnlCabecalho.Location = new Point(0, 0);
            this.pnlCabecalho.Name = "pnlCabecalho";
            this.pnlCabecalho.Size = new Size(760, 104);
            this.pnlCabecalho.TabIndex = 0;
            this.pnlCabecalho.BackColor = Color.FromArgb(22, 40, 59);
            this.pnlCabecalho.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // pnlDestaque
            this.pnlDestaque.Location = new Point(28, 25);
            this.pnlDestaque.Name = "pnlDestaque";
            this.pnlDestaque.Size = new Size(4, 53);
            this.pnlDestaque.TabIndex = 1;
            this.pnlDestaque.BackColor = Color.FromArgb(193, 150, 73);

            // lblTitulo
            this.lblTitulo.Location = new Point(46, 17);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new Size(660, 41);
            this.lblTitulo.ForeColor = Color.FromArgb(255, 255, 255);
            this.lblTitulo.Font = new Font("Segoe UI", 23F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblTitulo.Text = "Quarto";
            this.lblTitulo.TextAlign = ContentAlignment.MiddleLeft;

            // lblSubtitulo
            this.lblSubtitulo.Location = new Point(48, 60);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new Size(660, 24);
            this.lblSubtitulo.ForeColor = Color.FromArgb(215, 226, 231);
            this.lblSubtitulo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            this.lblSubtitulo.Text = "Identificação, capacidade e condições da diária.";
            this.lblSubtitulo.TextAlign = ContentAlignment.MiddleLeft;

            // pnlCampos
            this.pnlCampos.Location = new Point(28, 124);
            this.pnlCampos.Name = "pnlCampos";
            this.pnlCampos.Size = new Size(704, 420);
            this.pnlCampos.TabIndex = 2;
            this.pnlCampos.BackColor = Color.FromArgb(255, 255, 255);

            // lblCodigo
            this.lblCodigo.Location = new Point(24, 18);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new Size(144, 22);
            this.lblCodigo.ForeColor = Color.FromArgb(36, 51, 62);
            this.lblCodigo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblCodigo.Text = "Código";
            this.lblCodigo.TextAlign = ContentAlignment.MiddleLeft;

            // txtCodigo
            this.txtCodigo.Location = new Point(24, 42);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new Size(144, 27);
            this.txtCodigo.TabIndex = 3;
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.BackColor = Color.FromArgb(231, 237, 237);
            this.txtCodigo.TabStop = false;

            // lblNumeroQuarto
            this.lblNumeroQuarto.Location = new Point(24, 84);
            this.lblNumeroQuarto.Name = "lblNumeroQuarto";
            this.lblNumeroQuarto.Size = new Size(316, 22);
            this.lblNumeroQuarto.ForeColor = Color.FromArgb(36, 51, 62);
            this.lblNumeroQuarto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblNumeroQuarto.Text = "Número do quarto";
            this.lblNumeroQuarto.TextAlign = ContentAlignment.MiddleLeft;

            // txtNumeroQuarto
            this.txtNumeroQuarto.Location = new Point(24, 108);
            this.txtNumeroQuarto.Name = "txtNumeroQuarto";
            this.txtNumeroQuarto.Size = new Size(316, 27);
            this.txtNumeroQuarto.TabIndex = 4;

            // lblTipo
            this.lblTipo.Location = new Point(364, 84);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new Size(316, 22);
            this.lblTipo.ForeColor = Color.FromArgb(36, 51, 62);
            this.lblTipo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblTipo.Text = "Tipo";
            this.lblTipo.TextAlign = ContentAlignment.MiddleLeft;

            // txtTipo
            this.txtTipo.Location = new Point(364, 108);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new Size(316, 27);
            this.txtTipo.TabIndex = 5;

            // lblCapacidade
            this.lblCapacidade.Location = new Point(24, 150);
            this.lblCapacidade.Name = "lblCapacidade";
            this.lblCapacidade.Size = new Size(316, 22);
            this.lblCapacidade.ForeColor = Color.FromArgb(36, 51, 62);
            this.lblCapacidade.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblCapacidade.Text = "Capacidade";
            this.lblCapacidade.TextAlign = ContentAlignment.MiddleLeft;

            // txtCapacidade
            this.txtCapacidade.Location = new Point(24, 174);
            this.txtCapacidade.Name = "txtCapacidade";
            this.txtCapacidade.Size = new Size(316, 27);
            this.txtCapacidade.TabIndex = 6;

            // lblValorDiaria
            this.lblValorDiaria.Location = new Point(364, 150);
            this.lblValorDiaria.Name = "lblValorDiaria";
            this.lblValorDiaria.Size = new Size(316, 22);
            this.lblValorDiaria.ForeColor = Color.FromArgb(36, 51, 62);
            this.lblValorDiaria.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblValorDiaria.Text = "Valor da diária";
            this.lblValorDiaria.TextAlign = ContentAlignment.MiddleLeft;

            // txtValorDiaria
            this.txtValorDiaria.Location = new Point(364, 174);
            this.txtValorDiaria.Name = "txtValorDiaria";
            this.txtValorDiaria.Size = new Size(316, 27);
            this.txtValorDiaria.TabIndex = 7;

            // lblStatusQuarto
            this.lblStatusQuarto.Location = new Point(24, 216);
            this.lblStatusQuarto.Name = "lblStatusQuarto";
            this.lblStatusQuarto.Size = new Size(316, 22);
            this.lblStatusQuarto.ForeColor = Color.FromArgb(36, 51, 62);
            this.lblStatusQuarto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblStatusQuarto.Text = "Status";
            this.lblStatusQuarto.TextAlign = ContentAlignment.MiddleLeft;

            // cmbStatusQuarto
            this.cmbStatusQuarto.Location = new Point(24, 240);
            this.cmbStatusQuarto.Name = "cmbStatusQuarto";
            this.cmbStatusQuarto.Size = new Size(316, 27);
            this.cmbStatusQuarto.TabIndex = 8;
            this.cmbStatusQuarto.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbStatusQuarto.FormattingEnabled = true;

            // lblAndar
            this.lblAndar.Location = new Point(364, 216);
            this.lblAndar.Name = "lblAndar";
            this.lblAndar.Size = new Size(316, 22);
            this.lblAndar.ForeColor = Color.FromArgb(36, 51, 62);
            this.lblAndar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblAndar.Text = "Andar";
            this.lblAndar.TextAlign = ContentAlignment.MiddleLeft;

            // txtAndar
            this.txtAndar.Location = new Point(364, 240);
            this.txtAndar.Name = "txtAndar";
            this.txtAndar.Size = new Size(316, 27);
            this.txtAndar.TabIndex = 9;

            // lblDescricao
            this.lblDescricao.Location = new Point(24, 282);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new Size(656, 22);
            this.lblDescricao.ForeColor = Color.FromArgb(36, 51, 62);
            this.lblDescricao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblDescricao.Text = "Descrição";
            this.lblDescricao.TextAlign = ContentAlignment.MiddleLeft;

            // txtDescricao
            this.txtDescricao.Location = new Point(24, 306);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new Size(656, 92);
            this.txtDescricao.TabIndex = 10;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.ScrollBars = ScrollBars.Vertical;

            // pnlRodape
            this.pnlRodape.Location = new Point(28, 560);
            this.pnlRodape.Name = "pnlRodape";
            this.pnlRodape.Size = new Size(704, 46);
            this.pnlRodape.TabIndex = 11;
            this.pnlRodape.BackColor = Color.FromArgb(246, 243, 237);

            // lblModo
            this.lblModo.Location = new Point(0, 0);
            this.lblModo.Name = "lblModo";
            this.lblModo.Size = new Size(346, 42);
            this.lblModo.ForeColor = Color.FromArgb(78, 92, 101);
            this.lblModo.Text = "Cadastro";
            this.lblModo.TextAlign = ContentAlignment.MiddleLeft;

            // btnCancelar
            this.btnCancelar.Location = new Point(456, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new Size(112, 40);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.BackColor = Color.FromArgb(231, 237, 237);
            this.btnCancelar.ForeColor = Color.FromArgb(22, 40, 59);
            this.btnCancelar.FlatStyle = FlatStyle.Flat;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.DialogResult = DialogResult.Cancel;
            this.btnCancelar.UseVisualStyleBackColor = false;

            // btnSalvar
            this.btnSalvar.Location = new Point(580, 0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new Size(124, 40);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.BackColor = Color.FromArgb(22, 101, 93);
            this.btnSalvar.ForeColor = Color.FromArgb(255, 255, 255);
            this.btnSalvar.FlatStyle = FlatStyle.Flat;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            this.btnSalvar.UseVisualStyleBackColor = false;

            // frmQuartoCadastro
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(246, 243, 237);
            this.ClientSize = new Size(760, 625);
            this.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            this.ForeColor = Color.FromArgb(36, 51, 62);
            this.Icon = global::SistemaHotel.Properties.Resources.LogoSistema;
            this.Name = "frmQuartoCadastro";
            this.CancelButton = this.btnCancelar;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Quarto | Hospedaê";
            this.Controls.Add(this.pnlCabecalho);
            this.pnlCabecalho.Controls.Add(this.pnlDestaque);
            this.pnlCabecalho.Controls.Add(this.lblTitulo);
            this.pnlCabecalho.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.pnlCampos);
            this.pnlCampos.Controls.Add(this.lblCodigo);
            this.pnlCampos.Controls.Add(this.txtCodigo);
            this.pnlCampos.Controls.Add(this.lblNumeroQuarto);
            this.pnlCampos.Controls.Add(this.txtNumeroQuarto);
            this.pnlCampos.Controls.Add(this.lblTipo);
            this.pnlCampos.Controls.Add(this.txtTipo);
            this.pnlCampos.Controls.Add(this.lblCapacidade);
            this.pnlCampos.Controls.Add(this.txtCapacidade);
            this.pnlCampos.Controls.Add(this.lblValorDiaria);
            this.pnlCampos.Controls.Add(this.txtValorDiaria);
            this.pnlCampos.Controls.Add(this.lblStatusQuarto);
            this.pnlCampos.Controls.Add(this.cmbStatusQuarto);
            this.pnlCampos.Controls.Add(this.lblAndar);
            this.pnlCampos.Controls.Add(this.txtAndar);
            this.pnlCampos.Controls.Add(this.lblDescricao);
            this.pnlCampos.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.pnlRodape);
            this.pnlRodape.Controls.Add(this.lblModo);
            this.pnlRodape.Controls.Add(this.btnCancelar);
            this.pnlRodape.Controls.Add(this.btnSalvar);
            this.pnlCabecalho.ResumeLayout(false);
            this.pnlCabecalho.PerformLayout();
            this.pnlDestaque.ResumeLayout(false);
            this.pnlDestaque.PerformLayout();
            this.pnlCampos.ResumeLayout(false);
            this.pnlCampos.PerformLayout();
            this.pnlRodape.ResumeLayout(false);
            this.pnlRodape.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private Panel pnlCabecalho;
        private Panel pnlDestaque;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Panel pnlCampos;
        private Label lblCodigo;
        private TextBox txtCodigo;
        private Label lblNumeroQuarto;
        private TextBox txtNumeroQuarto;
        private Label lblTipo;
        private TextBox txtTipo;
        private Label lblCapacidade;
        private TextBox txtCapacidade;
        private Label lblValorDiaria;
        private TextBox txtValorDiaria;
        private Label lblStatusQuarto;
        private ComboBox cmbStatusQuarto;
        private Label lblAndar;
        private TextBox txtAndar;
        private Label lblDescricao;
        private TextBox txtDescricao;
        private Panel pnlRodape;
        private Label lblModo;
        private Button btnCancelar;
        private Button btnSalvar;
    }
}
