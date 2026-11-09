using System.Drawing;
using System.Windows.Forms;

namespace SistemaHotel.Views
{
    partial class frmFuncionarioCadastro
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
            this.lblContato = new Label();
            this.lblVinculo = new Label();
            this.pnlDivisor = new Panel();
            this.lblCodigo = new Label();
            this.txtCodigo = new TextBox();
            this.lblNome = new Label();
            this.txtNome = new TextBox();
            this.lblCargo = new Label();
            this.txtCargo = new TextBox();
            this.lblCPF = new Label();
            this.txtCPF = new TextBox();
            this.lblDataAdmissao = new Label();
            this.dtpDataAdmissao = new DateTimePicker();
            this.lblTelefone = new Label();
            this.txtTelefone = new TextBox();
            this.lblSalario = new Label();
            this.txtSalario = new TextBox();
            this.lblEmail = new Label();
            this.txtEmail = new TextBox();
            this.lblStatusFuncionario = new Label();
            this.cmbStatusFuncionario = new ComboBox();
            this.pnlRodape = new Panel();
            this.lblModo = new Label();
            this.btnCancelar = new Button();
            this.btnSalvar = new Button();
            this.pnlCabecalho.SuspendLayout();
            this.pnlDestaque.SuspendLayout();
            this.pnlCampos.SuspendLayout();
            this.pnlDivisor.SuspendLayout();
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
            this.lblTitulo.Text = "Funcionário";
            this.lblTitulo.TextAlign = ContentAlignment.MiddleLeft;

            // lblSubtitulo
            this.lblSubtitulo.Location = new Point(48, 60);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new Size(660, 24);
            this.lblSubtitulo.ForeColor = Color.FromArgb(215, 226, 231);
            this.lblSubtitulo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            this.lblSubtitulo.Text = "Dados pessoais, contato e informações do vínculo.";
            this.lblSubtitulo.TextAlign = ContentAlignment.MiddleLeft;

            // pnlCampos
            this.pnlCampos.Location = new Point(28, 124);
            this.pnlCampos.Name = "pnlCampos";
            this.pnlCampos.Size = new Size(704, 420);
            this.pnlCampos.TabIndex = 2;
            this.pnlCampos.BackColor = Color.FromArgb(255, 255, 255);

            // lblContato
            this.lblContato.Location = new Point(24, 86);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new Size(316, 24);
            this.lblContato.ForeColor = Color.FromArgb(22, 101, 93);
            this.lblContato.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblContato.Text = "Dados pessoais e contato";
            this.lblContato.TextAlign = ContentAlignment.MiddleLeft;

            // lblVinculo
            this.lblVinculo.Location = new Point(364, 86);
            this.lblVinculo.Name = "lblVinculo";
            this.lblVinculo.Size = new Size(316, 24);
            this.lblVinculo.ForeColor = Color.FromArgb(22, 101, 93);
            this.lblVinculo.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblVinculo.Text = "Vínculo profissional";
            this.lblVinculo.TextAlign = ContentAlignment.MiddleLeft;

            // pnlDivisor
            this.pnlDivisor.Location = new Point(351, 88);
            this.pnlDivisor.Name = "pnlDivisor";
            this.pnlDivisor.Size = new Size(1, 289);
            this.pnlDivisor.TabIndex = 3;
            this.pnlDivisor.BackColor = Color.FromArgb(220, 225, 224);

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
            this.txtCodigo.TabIndex = 4;
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.BackColor = Color.FromArgb(231, 237, 237);
            this.txtCodigo.TabStop = false;

            // lblNome
            this.lblNome.Location = new Point(24, 116);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new Size(316, 22);
            this.lblNome.ForeColor = Color.FromArgb(36, 51, 62);
            this.lblNome.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblNome.Text = "Nome";
            this.lblNome.TextAlign = ContentAlignment.MiddleLeft;

            // txtNome
            this.txtNome.Location = new Point(24, 140);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new Size(316, 27);
            this.txtNome.TabIndex = 5;

            // lblCargo
            this.lblCargo.Location = new Point(364, 116);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new Size(316, 22);
            this.lblCargo.ForeColor = Color.FromArgb(36, 51, 62);
            this.lblCargo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblCargo.Text = "Cargo";
            this.lblCargo.TextAlign = ContentAlignment.MiddleLeft;

            // txtCargo
            this.txtCargo.Location = new Point(364, 140);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new Size(316, 27);
            this.txtCargo.TabIndex = 6;

            // lblCPF
            this.lblCPF.Location = new Point(24, 182);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new Size(316, 22);
            this.lblCPF.ForeColor = Color.FromArgb(36, 51, 62);
            this.lblCPF.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblCPF.Text = "CPF";
            this.lblCPF.TextAlign = ContentAlignment.MiddleLeft;

            // txtCPF
            this.txtCPF.Location = new Point(24, 206);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new Size(316, 27);
            this.txtCPF.TabIndex = 7;

            // lblDataAdmissao
            this.lblDataAdmissao.Location = new Point(364, 182);
            this.lblDataAdmissao.Name = "lblDataAdmissao";
            this.lblDataAdmissao.Size = new Size(316, 22);
            this.lblDataAdmissao.ForeColor = Color.FromArgb(36, 51, 62);
            this.lblDataAdmissao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblDataAdmissao.Text = "Data de admissão";
            this.lblDataAdmissao.TextAlign = ContentAlignment.MiddleLeft;

            // dtpDataAdmissao
            this.dtpDataAdmissao.Location = new Point(364, 206);
            this.dtpDataAdmissao.Name = "dtpDataAdmissao";
            this.dtpDataAdmissao.Size = new Size(316, 27);
            this.dtpDataAdmissao.TabIndex = 8;
            this.dtpDataAdmissao.Format = DateTimePickerFormat.Custom;
            this.dtpDataAdmissao.CustomFormat = "dd/MM/yyyy";
            this.dtpDataAdmissao.ShowCheckBox = true;
            this.dtpDataAdmissao.Checked = false;

            // lblTelefone
            this.lblTelefone.Location = new Point(24, 248);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new Size(316, 22);
            this.lblTelefone.ForeColor = Color.FromArgb(36, 51, 62);
            this.lblTelefone.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblTelefone.Text = "Telefone";
            this.lblTelefone.TextAlign = ContentAlignment.MiddleLeft;

            // txtTelefone
            this.txtTelefone.Location = new Point(24, 272);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new Size(316, 27);
            this.txtTelefone.TabIndex = 9;

            // lblSalario
            this.lblSalario.Location = new Point(364, 248);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new Size(316, 22);
            this.lblSalario.ForeColor = Color.FromArgb(36, 51, 62);
            this.lblSalario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblSalario.Text = "Salário";
            this.lblSalario.TextAlign = ContentAlignment.MiddleLeft;

            // txtSalario
            this.txtSalario.Location = new Point(364, 272);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new Size(316, 27);
            this.txtSalario.TabIndex = 10;

            // lblEmail
            this.lblEmail.Location = new Point(24, 314);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new Size(316, 22);
            this.lblEmail.ForeColor = Color.FromArgb(36, 51, 62);
            this.lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblEmail.Text = "E-mail";
            this.lblEmail.TextAlign = ContentAlignment.MiddleLeft;

            // txtEmail
            this.txtEmail.Location = new Point(24, 338);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new Size(316, 27);
            this.txtEmail.TabIndex = 11;

            // lblStatusFuncionario
            this.lblStatusFuncionario.Location = new Point(364, 314);
            this.lblStatusFuncionario.Name = "lblStatusFuncionario";
            this.lblStatusFuncionario.Size = new Size(316, 22);
            this.lblStatusFuncionario.ForeColor = Color.FromArgb(36, 51, 62);
            this.lblStatusFuncionario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblStatusFuncionario.Text = "Status";
            this.lblStatusFuncionario.TextAlign = ContentAlignment.MiddleLeft;

            // cmbStatusFuncionario
            this.cmbStatusFuncionario.Location = new Point(364, 338);
            this.cmbStatusFuncionario.Name = "cmbStatusFuncionario";
            this.cmbStatusFuncionario.Size = new Size(316, 27);
            this.cmbStatusFuncionario.TabIndex = 12;
            this.cmbStatusFuncionario.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbStatusFuncionario.FormattingEnabled = true;

            // pnlRodape
            this.pnlRodape.Location = new Point(28, 560);
            this.pnlRodape.Name = "pnlRodape";
            this.pnlRodape.Size = new Size(704, 46);
            this.pnlRodape.TabIndex = 13;
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
            this.btnCancelar.TabIndex = 14;
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
            this.btnSalvar.TabIndex = 15;
            this.btnSalvar.BackColor = Color.FromArgb(22, 101, 93);
            this.btnSalvar.ForeColor = Color.FromArgb(255, 255, 255);
            this.btnSalvar.FlatStyle = FlatStyle.Flat;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            this.btnSalvar.UseVisualStyleBackColor = false;

            // frmFuncionarioCadastro
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(246, 243, 237);
            this.ClientSize = new Size(760, 625);
            this.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            this.ForeColor = Color.FromArgb(36, 51, 62);
            this.Icon = global::SistemaHotel.Properties.Resources.LogoSistema;
            this.Name = "frmFuncionarioCadastro";
            this.CancelButton = this.btnCancelar;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Funcionário | Hospedaê";
            this.Controls.Add(this.pnlCabecalho);
            this.pnlCabecalho.Controls.Add(this.pnlDestaque);
            this.pnlCabecalho.Controls.Add(this.lblTitulo);
            this.pnlCabecalho.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.pnlCampos);
            this.pnlCampos.Controls.Add(this.lblContato);
            this.pnlCampos.Controls.Add(this.lblVinculo);
            this.pnlCampos.Controls.Add(this.pnlDivisor);
            this.pnlCampos.Controls.Add(this.lblCodigo);
            this.pnlCampos.Controls.Add(this.txtCodigo);
            this.pnlCampos.Controls.Add(this.lblNome);
            this.pnlCampos.Controls.Add(this.txtNome);
            this.pnlCampos.Controls.Add(this.lblCargo);
            this.pnlCampos.Controls.Add(this.txtCargo);
            this.pnlCampos.Controls.Add(this.lblCPF);
            this.pnlCampos.Controls.Add(this.txtCPF);
            this.pnlCampos.Controls.Add(this.lblDataAdmissao);
            this.pnlCampos.Controls.Add(this.dtpDataAdmissao);
            this.pnlCampos.Controls.Add(this.lblTelefone);
            this.pnlCampos.Controls.Add(this.txtTelefone);
            this.pnlCampos.Controls.Add(this.lblSalario);
            this.pnlCampos.Controls.Add(this.txtSalario);
            this.pnlCampos.Controls.Add(this.lblEmail);
            this.pnlCampos.Controls.Add(this.txtEmail);
            this.pnlCampos.Controls.Add(this.lblStatusFuncionario);
            this.pnlCampos.Controls.Add(this.cmbStatusFuncionario);
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
            this.pnlDivisor.ResumeLayout(false);
            this.pnlDivisor.PerformLayout();
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
        private Label lblContato;
        private Label lblVinculo;
        private Panel pnlDivisor;
        private Label lblCodigo;
        private TextBox txtCodigo;
        private Label lblNome;
        private TextBox txtNome;
        private Label lblCargo;
        private TextBox txtCargo;
        private Label lblCPF;
        private TextBox txtCPF;
        private Label lblDataAdmissao;
        private DateTimePicker dtpDataAdmissao;
        private Label lblTelefone;
        private TextBox txtTelefone;
        private Label lblSalario;
        private TextBox txtSalario;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblStatusFuncionario;
        private ComboBox cmbStatusFuncionario;
        private Panel pnlRodape;
        private Label lblModo;
        private Button btnCancelar;
        private Button btnSalvar;
    }
}
