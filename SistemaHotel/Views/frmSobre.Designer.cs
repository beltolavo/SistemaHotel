using System.Drawing;
using System.Windows.Forms;

namespace SistemaHotel.Views
{
    partial class frmSobre
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
            this.lblTitulo = new Label();
            this.lblNomeSistema = new Label();
            this.pnlInformacoes = new Panel();
            this.lblDescricao = new Label();
            this.lblIntegrantes = new Label();
            this.lblIntegranteOlavo = new Label();
            this.lblIntegranteKaua = new Label();
            this.lblIntegranteKaique = new Label();
            this.lblVersao = new Label();
            this.btnFechar = new Button();
            this.pnlCabecalho.SuspendLayout();
            this.pnlInformacoes.SuspendLayout();
            this.SuspendLayout();

            // pnlCabecalho
            this.pnlCabecalho.Location = new Point(0, 0);
            this.pnlCabecalho.Name = "pnlCabecalho";
            this.pnlCabecalho.Size = new Size(540, 82);
            this.pnlCabecalho.BackColor = Color.FromArgb(22, 40, 59);
            this.pnlCabecalho.TabIndex = 0;

            // lblTitulo
            this.lblTitulo.Location = new Point(24, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new Size(492, 36);
            this.lblTitulo.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblTitulo.ForeColor = Color.FromArgb(255, 255, 255);
            this.lblTitulo.Text = "Sobre";
            this.lblTitulo.TextAlign = ContentAlignment.MiddleLeft;

            // lblNomeSistema
            this.lblNomeSistema.Location = new Point(26, 49);
            this.lblNomeSistema.Name = "lblNomeSistema";
            this.lblNomeSistema.Size = new Size(490, 20);
            this.lblNomeSistema.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            this.lblNomeSistema.ForeColor = Color.FromArgb(215, 226, 231);
            this.lblNomeSistema.Text = "Hospedaê";
            this.lblNomeSistema.TextAlign = ContentAlignment.MiddleLeft;

            // pnlInformacoes
            this.pnlInformacoes.Location = new Point(24, 102);
            this.pnlInformacoes.Name = "pnlInformacoes";
            this.pnlInformacoes.Size = new Size(492, 208);
            this.pnlInformacoes.BackColor = Color.FromArgb(255, 255, 255);
            this.pnlInformacoes.TabIndex = 1;

            // lblDescricao
            this.lblDescricao.Location = new Point(20, 16);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new Size(452, 58);
            this.lblDescricao.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            this.lblDescricao.Text = "Aplicação acadêmica criada para organizar os cadastros de clientes, quartos, funcionários e reservas de um hotel.";

            // lblIntegrantes
            this.lblIntegrantes.Location = new Point(20, 83);
            this.lblIntegrantes.Name = "lblIntegrantes";
            this.lblIntegrantes.Size = new Size(452, 25);
            this.lblIntegrantes.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblIntegrantes.ForeColor = Color.FromArgb(22, 40, 59);
            this.lblIntegrantes.Text = "Integrantes";
            this.lblIntegrantes.TextAlign = ContentAlignment.MiddleLeft;

            // lblIntegranteOlavo
            this.lblIntegranteOlavo.Location = new Point(20, 113);
            this.lblIntegranteOlavo.Name = "lblIntegranteOlavo";
            this.lblIntegranteOlavo.Size = new Size(452, 22);
            this.lblIntegranteOlavo.Text = "Olavo Beltran de Oliveira";
            this.lblIntegranteOlavo.TextAlign = ContentAlignment.MiddleLeft;

            // lblIntegranteKaua
            this.lblIntegranteKaua.Location = new Point(20, 137);
            this.lblIntegranteKaua.Name = "lblIntegranteKaua";
            this.lblIntegranteKaua.Size = new Size(452, 22);
            this.lblIntegranteKaua.Text = "Kauã Emanuel de Souza";
            this.lblIntegranteKaua.TextAlign = ContentAlignment.MiddleLeft;

            // lblIntegranteKaique
            this.lblIntegranteKaique.Location = new Point(20, 161);
            this.lblIntegranteKaique.Name = "lblIntegranteKaique";
            this.lblIntegranteKaique.Size = new Size(452, 22);
            this.lblIntegranteKaique.Text = "Kaique Messias Dias";
            this.lblIntegranteKaique.TextAlign = ContentAlignment.MiddleLeft;

            // lblVersao
            this.lblVersao.Location = new Point(24, 326);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new Size(240, 36);
            this.lblVersao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblVersao.ForeColor = Color.FromArgb(22, 101, 93);
            this.lblVersao.Text = "Versão: v1.0";
            this.lblVersao.TextAlign = ContentAlignment.MiddleLeft;

            // btnFechar
            this.btnFechar.Location = new Point(406, 326);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new Size(110, 36);
            this.btnFechar.BackColor = Color.FromArgb(22, 101, 93);
            this.btnFechar.DialogResult = DialogResult.Cancel;
            this.btnFechar.FlatStyle = FlatStyle.Flat;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnFechar.ForeColor = Color.FromArgb(255, 255, 255);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;

            // frmSobre
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(246, 243, 237);
            this.CancelButton = this.btnFechar;
            this.ClientSize = new Size(540, 380);
            this.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            this.ForeColor = Color.FromArgb(36, 51, 62);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Icon = global::SistemaHotel.Properties.Resources.LogoSistema;
            this.Name = "frmSobre";
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Sobre | Hospedaê";
            this.pnlCabecalho.Controls.Add(this.lblTitulo);
            this.pnlCabecalho.Controls.Add(this.lblNomeSistema);
            this.pnlInformacoes.Controls.Add(this.lblDescricao);
            this.pnlInformacoes.Controls.Add(this.lblIntegrantes);
            this.pnlInformacoes.Controls.Add(this.lblIntegranteOlavo);
            this.pnlInformacoes.Controls.Add(this.lblIntegranteKaua);
            this.pnlInformacoes.Controls.Add(this.lblIntegranteKaique);
            this.Controls.Add(this.pnlCabecalho);
            this.Controls.Add(this.pnlInformacoes);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.btnFechar);
            this.pnlCabecalho.ResumeLayout(false);
            this.pnlInformacoes.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private Panel pnlCabecalho;
        private Label lblTitulo;
        private Label lblNomeSistema;
        private Panel pnlInformacoes;
        private Label lblDescricao;
        private Label lblIntegrantes;
        private Label lblIntegranteOlavo;
        private Label lblIntegranteKaua;
        private Label lblIntegranteKaique;
        private Label lblVersao;
        private Button btnFechar;
    }
}
