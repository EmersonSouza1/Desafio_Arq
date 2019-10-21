using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio_Arquitetura_Emerson
{
    public partial class frmPesquisaMensagem : Form
    {
        public List<Mensagem> Mensagens;
        public List<Mensagem> MensagensSel;
        public frmPesquisaMensagem()
        {
            InitializeComponent();
            Mensagens = new List<Mensagem>();
            MensagensSel = new List<Mensagem>();
            
        }

        private void PopularGrid()
        {
            var data = from Msg in Mensagens
                       orderby Msg.SeqMensagem descending
                       select new
                       {
                           SeqMensagem = Msg.SeqMensagem,
                           Codigo_Aplicacao = Msg.CodigoAplicacao,
                           TextoMensagem = Msg.TextoMensagem,
                           dtaIniExibicao = Msg.DtaInicio,
                           dtaFimExibicao = Msg.DtaFinal,
                           Status = Msg.Status == "I"?"INATIVA":"ATIVA"

                       };
            dgvTabelaMensagem.DataSource = data.ToList();
            dgvTabelaMensagem.Columns[1].HeaderText = "Código Aplicação";
            dgvTabelaMensagem.Columns[2].HeaderText = "Texto da Mensagem";
            dgvTabelaMensagem.Columns[3].HeaderText = "Data Inicio Exibicao";
            dgvTabelaMensagem.Columns[4].HeaderText = "Data Final Exibicao";
            dgvTabelaMensagem.Columns[5].Width = 72;

            foreach (DataGridViewColumn colunas in dgvTabelaMensagem.Columns)
            {
                colunas.ReadOnly = true;
            }

        }



        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPesquisaMensagem_Load(object sender, EventArgs e)
        {
            PopularGrid();
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmCadMensagem>().Count() > 0)
            {
                if (dgvTabelaMensagem.SelectedCells != null)
                {
                    MensagensSel.Clear();
                    Int32 selectedRowCount =
                    dgvTabelaMensagem.Rows.GetRowCount(DataGridViewElementStates.Selected);
                    for ( int i = 0; i < selectedRowCount; i++)
                    {

                        MensagensSel.Add(Mensagens.FirstOrDefault(x => x.SeqMensagem == (int)dgvTabelaMensagem.SelectedRows[i].Cells[0].Value)) ;
                    }
                    FrmCadMensagem frmcad = (FrmCadMensagem)Application.OpenForms["FrmCadMensagem"];
                    frmcad.MensagensEnc = this.MensagensSel;
                    this.Close();
                }
            }
        }
    }
}
