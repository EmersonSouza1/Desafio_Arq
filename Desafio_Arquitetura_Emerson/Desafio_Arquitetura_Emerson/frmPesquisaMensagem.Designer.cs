namespace Desafio_Arquitetura_Emerson
{
    partial class frmPesquisaMensagem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvTabelaMensagem = new System.Windows.Forms.DataGridView();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnRetornar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelaMensagem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTabelaMensagem
            // 
            this.dgvTabelaMensagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabelaMensagem.Location = new System.Drawing.Point(13, 49);
            this.dgvTabelaMensagem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvTabelaMensagem.Name = "dgvTabelaMensagem";
            this.dgvTabelaMensagem.RowHeadersWidth = 62;
            this.dgvTabelaMensagem.Size = new System.Drawing.Size(954, 387);
            this.dgvTabelaMensagem.TabIndex = 15;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(13, 4);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(112, 35);
            this.btnSair.TabIndex = 27;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnRetornar
            // 
            this.btnRetornar.Location = new System.Drawing.Point(133, 4);
            this.btnRetornar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(112, 35);
            this.btnRetornar.TabIndex = 28;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // frmPesquisaMensagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 450);
            this.Controls.Add(this.btnRetornar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.dgvTabelaMensagem);
            this.Name = "frmPesquisaMensagem";
            this.Text = "Tabela de Mensagens";
            this.Load += new System.EventHandler(this.frmPesquisaMensagem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelaMensagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTabelaMensagem;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnRetornar;
    }
}