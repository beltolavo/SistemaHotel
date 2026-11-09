using System.Drawing;
using System.Windows.Forms;

namespace SistemaHotel.Views
{
    partial class frmClienteSelecao
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
            DataGridViewCellStyle estiloCabecalho = new DataGridViewCellStyle();
            DataGridViewCellStyle estiloLinha = new DataGridViewCellStyle();
            DataGridViewCellStyle estiloAlternado = new DataGridViewCellStyle();
            this.pnlCabecalho = new Panel();
            this.pnlDestaque = new Panel();
            this.lblTitulo = new Label();
            this.lblSubtitulo = new Label();
            this.pnlPesquisa = new Panel();
            this.lblCodigo = new Label();
            this.txtCodigo = new TextBox();
            this.lblNome = new Label();
            this.txtNome = new TextBox();
            this.btnPesquisar = new Button();
            this.btnLimpar = new Button();
            this.dgvRegistros = new DataGridView();
            this.pnlRodape = new Panel();
            this.lblRegistros = new Label();
            this.btnAdicionar = new Button();
            this.btnAlterar = new Button();
            this.btnVisualizar = new Button();
            this.btnExcluir = new Button();
            this.btnFechar = new Button();
            this.colIdCliente = new DataGridViewTextBoxColumn();
            this.colNome = new DataGridViewTextBoxColumn();
            this.colCPF = new DataGridViewTextBoxColumn();
            this.colTelefone = new DataGridViewTextBoxColumn();
            this.colCidade = new DataGridViewTextBoxColumn();
            this.pnlCabecalho.SuspendLayout();
            this.pnlDestaque.SuspendLayout();
            this.pnlPesquisa.SuspendLayout();
            this.pnlRodape.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
            this.SuspendLayout();

            estiloCabecalho.BackColor = Color.FromArgb(231, 237, 237);
            estiloCabecalho.ForeColor = Color.FromArgb(22, 40, 59);
            estiloCabecalho.SelectionBackColor = Color.FromArgb(231, 237, 237);
            estiloCabecalho.SelectionForeColor = Color.FromArgb(22, 40, 59);
            estiloCabecalho.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            estiloCabecalho.Padding = new Padding(7, 0, 5, 0);
            estiloLinha.ForeColor = Color.FromArgb(36, 51, 62);
            estiloLinha.SelectionBackColor = Color.FromArgb(220, 239, 233);
            estiloLinha.SelectionForeColor = Color.FromArgb(22, 40, 59);
            estiloLinha.Padding = new Padding(7, 0, 5, 0);
            estiloAlternado.BackColor = Color.FromArgb(246, 243, 237);

            // pnlCabecalho
            this.pnlCabecalho.Location = new Point(0, 0);
            this.pnlCabecalho.Name = "pnlCabecalho";
            this.pnlCabecalho.Size = new Size(1040, 104);
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
            this.lblTitulo.Text = "Clientes";
            this.lblTitulo.TextAlign = ContentAlignment.MiddleLeft;

            // lblSubtitulo
            this.lblSubtitulo.Location = new Point(48, 60);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new Size(660, 24);
            this.lblSubtitulo.ForeColor = Color.FromArgb(215, 226, 231);
            this.lblSubtitulo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            this.lblSubtitulo.Text = "Consulte os dados cadastrais dos clientes do hotel.";
            this.lblSubtitulo.TextAlign = ContentAlignment.MiddleLeft;

            // pnlPesquisa
            this.pnlPesquisa.Location = new Point(28, 122);
            this.pnlPesquisa.Name = "pnlPesquisa";
            this.pnlPesquisa.Size = new Size(984, 80);
            this.pnlPesquisa.TabIndex = 2;
            this.pnlPesquisa.BackColor = Color.FromArgb(255, 255, 255);
            this.pnlPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // lblCodigo
            this.lblCodigo.Location = new Point(16, 11);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new Size(124, 22);
            this.lblCodigo.ForeColor = Color.FromArgb(36, 51, 62);
            this.lblCodigo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblCodigo.Text = "Código";
            this.lblCodigo.TextAlign = ContentAlignment.MiddleLeft;

            // txtCodigo
            this.txtCodigo.Location = new Point(16, 35);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new Size(124, 27);
            this.txtCodigo.TabIndex = 3;

            // lblNome
            this.lblNome.Location = new Point(154, 11);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new Size(340, 22);
            this.lblNome.ForeColor = Color.FromArgb(36, 51, 62);
            this.lblNome.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblNome.Text = "Nome";
            this.lblNome.TextAlign = ContentAlignment.MiddleLeft;

            // txtNome
            this.txtNome.Location = new Point(154, 35);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new Size(340, 27);
            this.txtNome.TabIndex = 4;

            // btnPesquisar
            this.btnPesquisar.Location = new Point(510, 31);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new Size(104, 32);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.BackColor = Color.FromArgb(22, 101, 93);
            this.btnPesquisar.ForeColor = Color.FromArgb(255, 255, 255);
            this.btnPesquisar.FlatStyle = FlatStyle.Flat;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            this.btnPesquisar.UseVisualStyleBackColor = false;

            // btnLimpar
            this.btnLimpar.Location = new Point(626, 31);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new Size(86, 32);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.BackColor = Color.FromArgb(231, 237, 237);
            this.btnLimpar.ForeColor = Color.FromArgb(22, 40, 59);
            this.btnLimpar.FlatStyle = FlatStyle.Flat;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            this.btnLimpar.UseVisualStyleBackColor = false;

            // dgvRegistros
            this.dgvRegistros.Location = new Point(28, 220);
            this.dgvRegistros.Name = "dgvRegistros";
            this.dgvRegistros.Size = new Size(984, 354);
            this.dgvRegistros.TabIndex = 7;
            this.dgvRegistros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.dgvRegistros.AllowUserToAddRows = false;
            this.dgvRegistros.AllowUserToDeleteRows = false;
            this.dgvRegistros.AllowUserToResizeRows = false;
            this.dgvRegistros.AutoGenerateColumns = false;
            this.dgvRegistros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRegistros.BackgroundColor = Color.FromArgb(255, 255, 255);
            this.dgvRegistros.BorderStyle = BorderStyle.FixedSingle;
            this.dgvRegistros.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRegistros.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            this.dgvRegistros.ColumnHeadersHeight = 37;
            this.dgvRegistros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRegistros.EnableHeadersVisualStyles = false;
            this.dgvRegistros.GridColor = Color.FromArgb(220, 225, 224);
            this.dgvRegistros.MultiSelect = false;
            this.dgvRegistros.ReadOnly = true;
            this.dgvRegistros.RowHeadersVisible = false;
            this.dgvRegistros.RowTemplate.Height = 32;
            this.dgvRegistros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegistros.SelectionChanged += new System.EventHandler(this.dgvRegistros_SelectionChanged);
            this.dgvRegistros.ColumnHeadersDefaultCellStyle = estiloCabecalho;
            this.dgvRegistros.DefaultCellStyle = estiloLinha;
            this.dgvRegistros.AlternatingRowsDefaultCellStyle = estiloAlternado;
            this.dgvRegistros.Columns.AddRange(new DataGridViewColumn[] {
                this.colIdCliente, this.colNome, this.colCPF, this.colTelefone, this.colCidade
            });

            // colIdCliente
            this.colIdCliente.DataPropertyName = "IdCliente";
            this.colIdCliente.FillWeight = 60F;
            this.colIdCliente.HeaderText = "Código";
            this.colIdCliente.MinimumWidth = 75;
            this.colIdCliente.Name = "colIdCliente";
            this.colIdCliente.ReadOnly = true;

            // colNome
            this.colNome.DataPropertyName = "Nome";
            this.colNome.FillWeight = 174F;
            this.colNome.HeaderText = "Nome";
            this.colNome.MinimumWidth = 155;
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;

            // colCPF
            this.colCPF.DataPropertyName = "CPF";
            this.colCPF.FillWeight = 90F;
            this.colCPF.HeaderText = "CPF";
            this.colCPF.MinimumWidth = 115;
            this.colCPF.Name = "colCPF";
            this.colCPF.ReadOnly = true;

            // colTelefone
            this.colTelefone.DataPropertyName = "Telefone";
            this.colTelefone.FillWeight = 100F;
            this.colTelefone.HeaderText = "Telefone";
            this.colTelefone.MinimumWidth = 115;
            this.colTelefone.Name = "colTelefone";
            this.colTelefone.ReadOnly = true;

            // colCidade
            this.colCidade.DataPropertyName = "Cidade";
            this.colCidade.FillWeight = 126F;
            this.colCidade.HeaderText = "Cidade";
            this.colCidade.MinimumWidth = 122;
            this.colCidade.Name = "colCidade";
            this.colCidade.ReadOnly = true;

            // pnlRodape
            this.pnlRodape.Location = new Point(28, 588);
            this.pnlRodape.Name = "pnlRodape";
            this.pnlRodape.Size = new Size(984, 52);
            this.pnlRodape.TabIndex = 8;
            this.pnlRodape.BackColor = Color.FromArgb(246, 243, 237);
            this.pnlRodape.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            // lblRegistros
            this.lblRegistros.Location = new Point(0, 5);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new Size(234, 40);
            this.lblRegistros.ForeColor = Color.FromArgb(78, 92, 101);
            this.lblRegistros.Text = "Total de registros: —";
            this.lblRegistros.TextAlign = ContentAlignment.MiddleLeft;

            // btnAdicionar
            this.btnAdicionar.Location = new Point(426, 5);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnAdicionar.Size = new Size(102, 40);
            this.btnAdicionar.TabIndex = 9;
            this.btnAdicionar.BackColor = Color.FromArgb(22, 101, 93);
            this.btnAdicionar.ForeColor = Color.FromArgb(255, 255, 255);
            this.btnAdicionar.FlatStyle = FlatStyle.Flat;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);

            // btnAlterar
            this.btnAlterar.Location = new Point(540, 5);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnAlterar.Size = new Size(102, 40);
            this.btnAlterar.TabIndex = 10;
            this.btnAlterar.BackColor = Color.FromArgb(231, 237, 237);
            this.btnAlterar.ForeColor = Color.FromArgb(22, 40, 59);
            this.btnAlterar.FlatStyle = FlatStyle.Flat;
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            this.btnAlterar.UseVisualStyleBackColor = false;

            // btnVisualizar
            this.btnVisualizar.Location = new Point(654, 5);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Enabled = false;
            this.btnVisualizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnVisualizar.Size = new Size(102, 40);
            this.btnVisualizar.TabIndex = 11;
            this.btnVisualizar.BackColor = Color.FromArgb(231, 237, 237);
            this.btnVisualizar.ForeColor = Color.FromArgb(22, 40, 59);
            this.btnVisualizar.FlatStyle = FlatStyle.Flat;
            this.btnVisualizar.FlatAppearance.BorderSize = 0;
            this.btnVisualizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            this.btnVisualizar.UseVisualStyleBackColor = false;

            // btnExcluir
            this.btnExcluir.Location = new Point(768, 5);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnExcluir.Size = new Size(102, 40);
            this.btnExcluir.TabIndex = 12;
            this.btnExcluir.BackColor = Color.FromArgb(155, 64, 58);
            this.btnExcluir.ForeColor = Color.FromArgb(255, 255, 255);
            this.btnExcluir.FlatStyle = FlatStyle.Flat;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            this.btnExcluir.UseVisualStyleBackColor = false;

            // btnFechar
            this.btnFechar.Location = new Point(882, 5);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnFechar.Size = new Size(102, 40);
            this.btnFechar.TabIndex = 13;
            this.btnFechar.BackColor = Color.FromArgb(231, 237, 237);
            this.btnFechar.ForeColor = Color.FromArgb(22, 40, 59);
            this.btnFechar.FlatStyle = FlatStyle.Flat;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnFechar.Text = "Fechar";
            this.btnFechar.DialogResult = DialogResult.Cancel;
            this.btnFechar.UseVisualStyleBackColor = false;

            // frmClienteSelecao
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(246, 243, 237);
            this.ClientSize = new Size(1040, 658);
            this.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            this.ForeColor = Color.FromArgb(36, 51, 62);
            this.Icon = global::SistemaHotel.Properties.Resources.LogoSistema;
            this.Name = "frmClienteSelecao";
            this.CancelButton = this.btnFechar;
            this.MinimumSize = new Size(940, 550);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Clientes | Hospedaê";
            this.Controls.Add(this.pnlCabecalho);
            this.pnlCabecalho.Controls.Add(this.pnlDestaque);
            this.pnlCabecalho.Controls.Add(this.lblTitulo);
            this.pnlCabecalho.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.pnlPesquisa);
            this.pnlPesquisa.Controls.Add(this.lblCodigo);
            this.pnlPesquisa.Controls.Add(this.txtCodigo);
            this.pnlPesquisa.Controls.Add(this.lblNome);
            this.pnlPesquisa.Controls.Add(this.txtNome);
            this.pnlPesquisa.Controls.Add(this.btnPesquisar);
            this.pnlPesquisa.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.dgvRegistros);
            this.Controls.Add(this.pnlRodape);
            this.pnlRodape.Controls.Add(this.lblRegistros);
            this.pnlRodape.Controls.Add(this.btnAdicionar);
            this.pnlRodape.Controls.Add(this.btnAlterar);
            this.pnlRodape.Controls.Add(this.btnVisualizar);
            this.pnlRodape.Controls.Add(this.btnExcluir);
            this.pnlRodape.Controls.Add(this.btnFechar);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
            this.pnlCabecalho.ResumeLayout(false);
            this.pnlCabecalho.PerformLayout();
            this.pnlDestaque.ResumeLayout(false);
            this.pnlDestaque.PerformLayout();
            this.pnlPesquisa.ResumeLayout(false);
            this.pnlPesquisa.PerformLayout();
            this.pnlRodape.ResumeLayout(false);
            this.pnlRodape.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private Panel pnlCabecalho;
        private Panel pnlDestaque;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Panel pnlPesquisa;
        private Label lblCodigo;
        private TextBox txtCodigo;
        private Label lblNome;
        private TextBox txtNome;
        private Button btnPesquisar;
        private Button btnLimpar;
        private DataGridView dgvRegistros;
        private Panel pnlRodape;
        private Label lblRegistros;
        private Button btnAdicionar;
        private Button btnAlterar;
        private Button btnVisualizar;
        private Button btnExcluir;
        private Button btnFechar;
        private DataGridViewTextBoxColumn colIdCliente;
        private DataGridViewTextBoxColumn colNome;
        private DataGridViewTextBoxColumn colCPF;
        private DataGridViewTextBoxColumn colTelefone;
        private DataGridViewTextBoxColumn colCidade;
    }
}
