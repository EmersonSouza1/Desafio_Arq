namespace Desafio_Arquitetura_Emerson
{
    partial class FrmCadMensagem
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCodigoAplicacao = new System.Windows.Forms.TextBox();
            this.lblCodAplicacao = new System.Windows.Forms.Label();
            this.lblPeriodoExibicao = new System.Windows.Forms.Label();
            this.lblDtaFimExibicao = new System.Windows.Forms.Label();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.rctxtMenssagem = new System.Windows.Forms.RichTextBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.mktxtDtaIniExibicao = new System.Windows.Forms.MaskedTextBox();
            this.mktxtDtaFimExibicao = new System.Windows.Forms.MaskedTextBox();
            this.mktxtSeqMensagem = new System.Windows.Forms.MaskedTextBox();
            this.lblSeqmensagem = new System.Windows.Forms.Label();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnTabela = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCodigoAplicacao
            // 
            this.txtCodigoAplicacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoAplicacao.Location = new System.Drawing.Point(219, 112);
            this.txtCodigoAplicacao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigoAplicacao.MaxLength = 12;
            this.txtCodigoAplicacao.Name = "txtCodigoAplicacao";
            this.txtCodigoAplicacao.Size = new System.Drawing.Size(204, 26);
            this.txtCodigoAplicacao.TabIndex = 1;
            // 
            // lblCodAplicacao
            // 
            this.lblCodAplicacao.AutoSize = true;
            this.lblCodAplicacao.Location = new System.Drawing.Point(39, 115);
            this.lblCodAplicacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodAplicacao.Name = "lblCodAplicacao";
            this.lblCodAplicacao.Size = new System.Drawing.Size(154, 20);
            this.lblCodAplicacao.TabIndex = 5;
            this.lblCodAplicacao.Text = "Código da Aplicação";
            // 
            // lblPeriodoExibicao
            // 
            this.lblPeriodoExibicao.AutoSize = true;
            this.lblPeriodoExibicao.Location = new System.Drawing.Point(21, 318);
            this.lblPeriodoExibicao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPeriodoExibicao.Name = "lblPeriodoExibicao";
            this.lblPeriodoExibicao.Size = new System.Drawing.Size(172, 20);
            this.lblPeriodoExibicao.TabIndex = 6;
            this.lblPeriodoExibicao.Text = "Periodo de vigencia de ";
            // 
            // lblDtaFimExibicao
            // 
            this.lblDtaFimExibicao.AutoSize = true;
            this.lblDtaFimExibicao.Location = new System.Drawing.Point(351, 315);
            this.lblDtaFimExibicao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDtaFimExibicao.Name = "lblDtaFimExibicao";
            this.lblDtaFimExibicao.Size = new System.Drawing.Size(32, 20);
            this.lblDtaFimExibicao.TabIndex = 7;
            this.lblDtaFimExibicao.Text = "até";
            // 
            // cbxStatus
            // 
            this.cbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "ATIVA",
            "INATIVA"});
            this.cbxStatus.Location = new System.Drawing.Point(612, 310);
            this.cbxStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(180, 28);
            this.cbxStatus.TabIndex = 5;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(534, 314);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(56, 20);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Status";
            // 
            // rctxtMenssagem
            // 
            this.rctxtMenssagem.Location = new System.Drawing.Point(219, 154);
            this.rctxtMenssagem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rctxtMenssagem.MaxLength = 4000;
            this.rctxtMenssagem.Name = "rctxtMenssagem";
            this.rctxtMenssagem.Size = new System.Drawing.Size(721, 146);
            this.rctxtMenssagem.TabIndex = 2;
            this.rctxtMenssagem.Text = "";
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(108, 217);
            this.lblMensagem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(88, 20);
            this.lblMensagem.TabIndex = 13;
            this.lblMensagem.Text = "Mensagem";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(134, 14);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(112, 35);
            this.btnSalvar.TabIndex = 15;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(374, 14);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(112, 35);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(254, 14);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(112, 35);
            this.btnExcluir.TabIndex = 17;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(13, 14);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(112, 35);
            this.btnLimpar.TabIndex = 18;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // mktxtDtaIniExibicao
            // 
            this.mktxtDtaIniExibicao.Location = new System.Drawing.Point(222, 315);
            this.mktxtDtaIniExibicao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mktxtDtaIniExibicao.Mask = "00/00/0000";
            this.mktxtDtaIniExibicao.Name = "mktxtDtaIniExibicao";
            this.mktxtDtaIniExibicao.Size = new System.Drawing.Size(97, 26);
            this.mktxtDtaIniExibicao.TabIndex = 3;
            this.mktxtDtaIniExibicao.ValidatingType = typeof(System.DateTime);
            this.mktxtDtaIniExibicao.Validated += new System.EventHandler(this.mktxtDtaIniExibicao_Validated);
            // 
            // mktxtDtaFimExibicao
            // 
            this.mktxtDtaFimExibicao.Location = new System.Drawing.Point(408, 312);
            this.mktxtDtaFimExibicao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mktxtDtaFimExibicao.Mask = "00/00/0000";
            this.mktxtDtaFimExibicao.Name = "mktxtDtaFimExibicao";
            this.mktxtDtaFimExibicao.Size = new System.Drawing.Size(97, 26);
            this.mktxtDtaFimExibicao.TabIndex = 4;
            this.mktxtDtaFimExibicao.ValidatingType = typeof(System.DateTime);
            this.mktxtDtaFimExibicao.Validated += new System.EventHandler(this.mktxtDtaFimExibicao_Validated);
            // 
            // mktxtSeqMensagem
            // 
            this.mktxtSeqMensagem.HidePromptOnLeave = true;
            this.mktxtSeqMensagem.Location = new System.Drawing.Point(219, 70);
            this.mktxtSeqMensagem.Mask = "000000000000000000000";
            this.mktxtSeqMensagem.Name = "mktxtSeqMensagem";
            this.mktxtSeqMensagem.Size = new System.Drawing.Size(204, 26);
            this.mktxtSeqMensagem.TabIndex = 0;
            this.mktxtSeqMensagem.ValidatingType = typeof(int);
            // 
            // lblSeqmensagem
            // 
            this.lblSeqmensagem.AutoSize = true;
            this.lblSeqmensagem.Location = new System.Drawing.Point(76, 73);
            this.lblSeqmensagem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeqmensagem.Name = "lblSeqmensagem";
            this.lblSeqmensagem.Size = new System.Drawing.Size(117, 20);
            this.lblSeqmensagem.TabIndex = 20;
            this.lblSeqmensagem.Text = "SeqMensagem";
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(614, 14);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(112, 35);
            this.btnAnterior.TabIndex = 21;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Location = new System.Drawing.Point(734, 14);
            this.btnProximo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(112, 35);
            this.btnProximo.TabIndex = 22;
            this.btnProximo.Text = "Proxímo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnTabela
            // 
            this.btnTabela.Location = new System.Drawing.Point(494, 14);
            this.btnTabela.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTabela.Name = "btnTabela";
            this.btnTabela.Size = new System.Drawing.Size(112, 35);
            this.btnTabela.TabIndex = 23;
            this.btnTabela.Text = "Tabela";
            this.btnTabela.UseVisualStyleBackColor = true;
            this.btnTabela.Click += new System.EventHandler(this.btnTabela_Click);
            // 
            // FrmCadMensagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 357);
            this.Controls.Add(this.btnTabela);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.lblSeqmensagem);
            this.Controls.Add(this.mktxtSeqMensagem);
            this.Controls.Add(this.mktxtDtaFimExibicao);
            this.Controls.Add(this.mktxtDtaIniExibicao);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.rctxtMenssagem);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cbxStatus);
            this.Controls.Add(this.lblDtaFimExibicao);
            this.Controls.Add(this.lblPeriodoExibicao);
            this.Controls.Add(this.lblCodAplicacao);
            this.Controls.Add(this.txtCodigoAplicacao);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmCadMensagem";
            this.Text = "Periodo de vigencia de ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigoAplicacao;
        private System.Windows.Forms.Label lblCodAplicacao;
        private System.Windows.Forms.Label lblPeriodoExibicao;
        private System.Windows.Forms.Label lblDtaFimExibicao;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.RichTextBox rctxtMenssagem;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.MaskedTextBox mktxtDtaIniExibicao;
        private System.Windows.Forms.MaskedTextBox mktxtDtaFimExibicao;
        private System.Windows.Forms.MaskedTextBox mktxtSeqMensagem;
        private System.Windows.Forms.Label lblSeqmensagem;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnTabela;
    }
}

