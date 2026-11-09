using System.Drawing;
using System.Windows.Forms;

namespace SistemaHotel.Views
{
    partial class frmReservaCadastro
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
            this.lblCliente = new Label();
            this.cmbCliente = new ComboBox();
            this.lblQuarto = new Label();
            this.cmbQuarto = new ComboBox();
            this.lblDataEntrada = new Label();
            this.dtpDataEntrada = new DateTimePicker();
            this.lblDataSaida = new Label();
            this.dtpDataSaida = new DateTimePicker();
            this.lblQuantidadeHospedes = new Label();
            this.txtQuantidadeHospedes = new TextBox();
            this.lblValorTotal = new Label();
            this.txtValorTotal = new TextBox();
            this.lblStatusReserva = new Label();
            this.cmbStatusReserva = new ComboBox();
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
            this.lblTitulo.Text = "Reserva";
            this.lblTitulo.TextAlign = ContentAlignment.MiddleLeft;

            // lblSubtitulo
            this.lblSubtitulo.Location = new Point(48, 60);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new Size(660, 24);
            this.lblSubtitulo.ForeColor = Color.FromArgb(215, 226, 231);
            this.lblSubtitulo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            this.lblSubtitulo.Text = "Dados da estadia e informações da reserva.";
            this.lblSubtitulo.TextAlign = ContentAlignment.MiddleLeft;

            // pnlCampos
            this.pnlCampos.Location = new Point(28, 124);
            this.pnlCampos.Name = "pnlCampos";
            this.pnlCampos.Size = new Size(704, 356);
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

            // lblCliente
            this.lblCliente.Location = new Point(24, 84);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new Size(316, 22);
            this.lblCliente.ForeColor = Color.FromArgb(36, 51, 62);
            this.lblCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblCliente.Text = "Cliente";
            this.lblCliente.TextAlign = ContentAlignment.MiddleLeft;

            // cmbCliente
            this.cmbCliente.Location = new Point(24, 108);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new Size(316, 27);
            this.cmbCliente.TabIndex = 4;
            this.cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbCliente.FormattingEnabled = true;

            // lblQuarto
            this.lblQuarto.Location = new Point(364, 84);
            this.lblQuarto.Name = "lblQuarto";
            this.lblQuarto.Size = new Size(316, 22);
            this.lblQuarto.ForeColor = Color.FromArgb(36, 51, 62);
            this.lblQuarto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblQuarto.Text = "Quarto";
            this.lblQuarto.TextAlign = ContentAlignment.MiddleLeft;

            // cmbQuarto
            this.cmbQuarto.Location = new Point(364, 108);
            this.cmbQuarto.Name = "cmbQuarto";
            this.cmbQuarto.Size = new Size(316, 27);
            this.cmbQuarto.TabIndex = 5;
            this.cmbQuarto.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbQuarto.FormattingEnabled = true;

            // lblDataEntrada
            this.lblDataEntrada.Location = new Point(24, 150);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new Size(316, 22);
            this.lblDataEntrada.ForeColor = Color.FromArgb(36, 51, 62);
            this.lblDataEntrada.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblDataEntrada.Text = "Data de entrada";
            this.lblDataEntrada.TextAlign = ContentAlignment.MiddleLeft;

            // dtpDataEntrada
            this.dtpDataEntrada.Location = new Point(24, 174);
            this.dtpDataEntrada.Name = "dtpDataEntrada";
            this.dtpDataEntrada.Size = new Size(316, 27);
            this.dtpDataEntrada.TabIndex = 6;
            this.dtpDataEntrada.Format = DateTimePickerFormat.Custom;
            this.dtpDataEntrada.CustomFormat = "dd/MM/yyyy";
            this.dtpDataEntrada.ShowCheckBox = true;
            this.dtpDataEntrada.Checked = false;

            // lblDataSaida
            this.lblDataSaida.Location = new Point(364, 150);
            this.lblDataSaida.Name = "lblDataSaida";
            this.lblDataSaida.Size = new Size(316, 22);
            this.lblDataSaida.ForeColor = Color.FromArgb(36, 51, 62);
            this.lblDataSaida.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblDataSaida.Text = "Data de saída";
            this.lblDataSaida.TextAlign = ContentAlignment.MiddleLeft;

            // dtpDataSaida
            this.dtpDataSaida.Location = new Point(364, 174);
            this.dtpDataSaida.Name = "dtpDataSaida";
            this.dtpDataSaida.Size = new Size(316, 27);
            this.dtpDataSaida.TabIndex = 7;
            this.dtpDataSaida.Format = DateTimePickerFormat.Custom;
            this.dtpDataSaida.CustomFormat = "dd/MM/yyyy";
            this.dtpDataSaida.ShowCheckBox = true;
            this.dtpDataSaida.Checked = false;

            // lblQuantidadeHospedes
            this.lblQuantidadeHospedes.Location = new Point(24, 216);
            this.lblQuantidadeHospedes.Name = "lblQuantidadeHospedes";
            this.lblQuantidadeHospedes.Size = new Size(316, 22);
            this.lblQuantidadeHospedes.ForeColor = Color.FromArgb(36, 51, 62);
            this.lblQuantidadeHospedes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblQuantidadeHospedes.Text = "Quantidade de hóspedes";
            this.lblQuantidadeHospedes.TextAlign = ContentAlignment.MiddleLeft;

            // txtQuantidadeHospedes
            this.txtQuantidadeHospedes.Location = new Point(24, 240);
            this.txtQuantidadeHospedes.Name = "txtQuantidadeHospedes";
            this.txtQuantidadeHospedes.Size = new Size(316, 27);
            this.txtQuantidadeHospedes.TabIndex = 8;

            // lblValorTotal
            this.lblValorTotal.Location = new Point(364, 216);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new Size(316, 22);
            this.lblValorTotal.ForeColor = Color.FromArgb(36, 51, 62);
            this.lblValorTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblValorTotal.Text = "Valor total";
            this.lblValorTotal.TextAlign = ContentAlignment.MiddleLeft;

            // txtValorTotal
            this.txtValorTotal.Location = new Point(364, 240);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new Size(316, 27);
            this.txtValorTotal.TabIndex = 9;

            // lblStatusReserva
            this.lblStatusReserva.Location = new Point(24, 282);
            this.lblStatusReserva.Name = "lblStatusReserva";
            this.lblStatusReserva.Size = new Size(316, 22);
            this.lblStatusReserva.ForeColor = Color.FromArgb(36, 51, 62);
            this.lblStatusReserva.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblStatusReserva.Text = "Status";
            this.lblStatusReserva.TextAlign = ContentAlignment.MiddleLeft;

            // cmbStatusReserva
            this.cmbStatusReserva.Location = new Point(24, 306);
            this.cmbStatusReserva.Name = "cmbStatusReserva";
            this.cmbStatusReserva.Size = new Size(316, 27);
            this.cmbStatusReserva.TabIndex = 10;
            this.cmbStatusReserva.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbStatusReserva.FormattingEnabled = true;

            // pnlRodape
            this.pnlRodape.Location = new Point(28, 496);
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

            // frmReservaCadastro
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(246, 243, 237);
            this.ClientSize = new Size(760, 561);
            this.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            this.ForeColor = Color.FromArgb(36, 51, 62);
            this.Icon = global::SistemaHotel.Properties.Resources.LogoSistema;
            this.Name = "frmReservaCadastro";
            this.CancelButton = this.btnCancelar;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Reserva | Hospedaê";
            this.Controls.Add(this.pnlCabecalho);
            this.pnlCabecalho.Controls.Add(this.pnlDestaque);
            this.pnlCabecalho.Controls.Add(this.lblTitulo);
            this.pnlCabecalho.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.pnlCampos);
            this.pnlCampos.Controls.Add(this.lblCodigo);
            this.pnlCampos.Controls.Add(this.txtCodigo);
            this.pnlCampos.Controls.Add(this.lblCliente);
            this.pnlCampos.Controls.Add(this.cmbCliente);
            this.pnlCampos.Controls.Add(this.lblQuarto);
            this.pnlCampos.Controls.Add(this.cmbQuarto);
            this.pnlCampos.Controls.Add(this.lblDataEntrada);
            this.pnlCampos.Controls.Add(this.dtpDataEntrada);
            this.pnlCampos.Controls.Add(this.lblDataSaida);
            this.pnlCampos.Controls.Add(this.dtpDataSaida);
            this.pnlCampos.Controls.Add(this.lblQuantidadeHospedes);
            this.pnlCampos.Controls.Add(this.txtQuantidadeHospedes);
            this.pnlCampos.Controls.Add(this.lblValorTotal);
            this.pnlCampos.Controls.Add(this.txtValorTotal);
            this.pnlCampos.Controls.Add(this.lblStatusReserva);
            this.pnlCampos.Controls.Add(this.cmbStatusReserva);
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
        private Label lblCliente;
        private ComboBox cmbCliente;
        private Label lblQuarto;
        private ComboBox cmbQuarto;
        private Label lblDataEntrada;
        private DateTimePicker dtpDataEntrada;
        private Label lblDataSaida;
        private DateTimePicker dtpDataSaida;
        private Label lblQuantidadeHospedes;
        private TextBox txtQuantidadeHospedes;
        private Label lblValorTotal;
        private TextBox txtValorTotal;
        private Label lblStatusReserva;
        private ComboBox cmbStatusReserva;
        private Panel pnlRodape;
        private Label lblModo;
        private Button btnCancelar;
        private Button btnSalvar;
    }
}
