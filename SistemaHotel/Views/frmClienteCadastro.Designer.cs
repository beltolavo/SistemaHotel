using System.Drawing;
using System.Windows.Forms;

namespace SistemaHotel.Views
{
    partial class frmClienteCadastro
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
            this.lblNome = new Label();
            this.txtNome = new TextBox();
            this.lblCPF = new Label();
            this.txtCPF = new TextBox();
            this.lblDataNascimento = new Label();
            this.dtpDataNascimento = new DateTimePicker();
            this.lblTelefone = new Label();
            this.txtTelefone = new TextBox();
            this.lblEmail = new Label();
            this.txtEmail = new TextBox();
            this.lblEndereco = new Label();
            this.txtEndereco = new TextBox();
            this.lblCidade = new Label();
            this.txtCidade = new TextBox();
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
            this.lblTitulo.Text = "Cliente";
            this.lblTitulo.TextAlign = ContentAlignment.MiddleLeft;

            // lblSubtitulo
            this.lblSubtitulo.Location = new Point(48, 60);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new Size(660, 24);
            this.lblSubtitulo.ForeColor = Color.FromArgb(215, 226, 231);
            this.lblSubtitulo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            this.lblSubtitulo.Text = "Dados pessoais, contato e endereço.";
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

            // lblNome
            this.lblNome.Location = new Point(24, 84);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new Size(656, 22);
            this.lblNome.ForeColor = Color.FromArgb(36, 51, 62);
            this.lblNome.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblNome.Text = "Nome";
            this.lblNome.TextAlign = ContentAlignment.MiddleLeft;

            // txtNome
            this.txtNome.Location = new Point(24, 108);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new Size(656, 27);
            this.txtNome.TabIndex = 4;

            // lblCPF
            this.lblCPF.Location = new Point(24, 150);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new Size(316, 22);
            this.lblCPF.ForeColor = Color.FromArgb(36, 51, 62);
            this.lblCPF.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblCPF.Text = "CPF";
            this.lblCPF.TextAlign = ContentAlignment.MiddleLeft;

            // txtCPF
            this.txtCPF.Location = new Point(24, 174);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new Size(316, 27);
            this.txtCPF.TabIndex = 5;

            // lblDataNascimento
            this.lblDataNascimento.Location = new Point(364, 150);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new Size(316, 22);
            this.lblDataNascimento.ForeColor = Color.FromArgb(36, 51, 62);
            this.lblDataNascimento.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblDataNascimento.Text = "Data de nascimento";
            this.lblDataNascimento.TextAlign = ContentAlignment.MiddleLeft;

            // dtpDataNascimento
            this.dtpDataNascimento.Location = new Point(364, 174);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new Size(316, 27);
            this.dtpDataNascimento.TabIndex = 6;
            this.dtpDataNascimento.Format = DateTimePickerFormat.Custom;
            this.dtpDataNascimento.CustomFormat = "dd/MM/yyyy";
            this.dtpDataNascimento.ShowCheckBox = true;
            this.dtpDataNascimento.Checked = false;

            // lblTelefone
            this.lblTelefone.Location = new Point(24, 216);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new Size(316, 22);
            this.lblTelefone.ForeColor = Color.FromArgb(36, 51, 62);
            this.lblTelefone.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblTelefone.Text = "Telefone";
            this.lblTelefone.TextAlign = ContentAlignment.MiddleLeft;

            // txtTelefone
            this.txtTelefone.Location = new Point(24, 240);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new Size(316, 27);
            this.txtTelefone.TabIndex = 7;

            // lblEmail
            this.lblEmail.Location = new Point(364, 216);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new Size(316, 22);
            this.lblEmail.ForeColor = Color.FromArgb(36, 51, 62);
            this.lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblEmail.Text = "E-mail";
            this.lblEmail.TextAlign = ContentAlignment.MiddleLeft;

            // txtEmail
            this.txtEmail.Location = new Point(364, 240);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new Size(316, 27);
            this.txtEmail.TabIndex = 8;

            // lblEndereco
            this.lblEndereco.Location = new Point(24, 282);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new Size(656, 22);
            this.lblEndereco.ForeColor = Color.FromArgb(36, 51, 62);
            this.lblEndereco.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblEndereco.Text = "Endereço";
            this.lblEndereco.TextAlign = ContentAlignment.MiddleLeft;

            // txtEndereco
            this.txtEndereco.Location = new Point(24, 306);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new Size(656, 27);
            this.txtEndereco.TabIndex = 9;

            // lblCidade
            this.lblCidade.Location = new Point(24, 348);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new Size(316, 22);
            this.lblCidade.ForeColor = Color.FromArgb(36, 51, 62);
            this.lblCidade.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblCidade.Text = "Cidade";
            this.lblCidade.TextAlign = ContentAlignment.MiddleLeft;

            // txtCidade
            this.txtCidade.Location = new Point(24, 372);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new Size(316, 27);
            this.txtCidade.TabIndex = 10;

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

            // frmClienteCadastro
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(246, 243, 237);
            this.ClientSize = new Size(760, 625);
            this.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            this.ForeColor = Color.FromArgb(36, 51, 62);
            this.Icon = global::SistemaHotel.Properties.Resources.LogoSistema;
            this.Name = "frmClienteCadastro";
            this.CancelButton = this.btnCancelar;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Cliente | Hospedaê";
            this.Controls.Add(this.pnlCabecalho);
            this.pnlCabecalho.Controls.Add(this.pnlDestaque);
            this.pnlCabecalho.Controls.Add(this.lblTitulo);
            this.pnlCabecalho.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.pnlCampos);
            this.pnlCampos.Controls.Add(this.lblCodigo);
            this.pnlCampos.Controls.Add(this.txtCodigo);
            this.pnlCampos.Controls.Add(this.lblNome);
            this.pnlCampos.Controls.Add(this.txtNome);
            this.pnlCampos.Controls.Add(this.lblCPF);
            this.pnlCampos.Controls.Add(this.txtCPF);
            this.pnlCampos.Controls.Add(this.lblDataNascimento);
            this.pnlCampos.Controls.Add(this.dtpDataNascimento);
            this.pnlCampos.Controls.Add(this.lblTelefone);
            this.pnlCampos.Controls.Add(this.txtTelefone);
            this.pnlCampos.Controls.Add(this.lblEmail);
            this.pnlCampos.Controls.Add(this.txtEmail);
            this.pnlCampos.Controls.Add(this.lblEndereco);
            this.pnlCampos.Controls.Add(this.txtEndereco);
            this.pnlCampos.Controls.Add(this.lblCidade);
            this.pnlCampos.Controls.Add(this.txtCidade);
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
        private Label lblNome;
        private TextBox txtNome;
        private Label lblCPF;
        private TextBox txtCPF;
        private Label lblDataNascimento;
        private DateTimePicker dtpDataNascimento;
        private Label lblTelefone;
        private TextBox txtTelefone;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblEndereco;
        private TextBox txtEndereco;
        private Label lblCidade;
        private TextBox txtCidade;
        private Panel pnlRodape;
        private Label lblModo;
        private Button btnCancelar;
        private Button btnSalvar;
    }
}
