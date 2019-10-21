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
    public partial class FrmCadMensagem : Form
    {
        private List<Mensagem> Mensagens;
        public List<Mensagem> MensagensEnc;
        private int IndexMsgEnc;
        public FrmCadMensagem()
        {
            InitializeComponent();

            Mensagens = new List<Mensagem>();
            MensagensEnc = new List<Mensagem>();
            LimparCampos();
            HabDisaLimp();
        }
        private bool EncontraCodigo(string Codigo)
        {
            var Result = Mensagens.Find(T => T.CodigoAplicacao == Codigo);
            if (Result != null) return true;
            return false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool oksalvar = true;
            if (txtCodigoAplicacao.Text == "")
            {
                MessageBox.Show("O Código da aplicação deve ser informado!", "Atenção");
                oksalvar = false;
            }
            if(oksalvar && rctxtMenssagem.Text == "")
            {
                MessageBox.Show("O texto da mensagem deve ser informado!", "Atenção");
                oksalvar = false;
            }
            if (oksalvar)
            {
                string Status = cbxStatus.Text == "INATIVA" ? "I" : "A";
                DateTime.TryParse(mktxtDtaIniExibicao.Text, out DateTime DtaIni);
                DateTime.TryParse(mktxtDtaFimExibicao.Text, out DateTime DtaFim);
                if (mktxtSeqMensagem.Enabled)
                {
                    Mensagem Msg = new Mensagem
                    {
                        CodigoAplicacao = txtCodigoAplicacao.Text,
                        TextoMensagem = rctxtMenssagem.Text,
                        DtaInicio = DtaIni,
                        DtaFinal = DtaFim,
                        DtaInclusao = DateTime.Now,
                        Status = Status
                    };
                    Mensagens.Add(Msg);
                    LimparCampos();
                }
                else
                {
                    var elem = Mensagens.FirstOrDefault(x => x.SeqMensagem == int.Parse(mktxtSeqMensagem.Text));
                    elem.CodigoAplicacao = txtCodigoAplicacao.Text;
                    elem.TextoMensagem = rctxtMenssagem.Text;
                    elem.DtaInicio = DtaIni;
                    elem.DtaFinal = DtaFim;
                    elem.Status = Status;
                }

            }
            
        }

        private bool ValidaDataVazia(string Date)
        {
            string str = Date.Replace("/", "").Replace("_", "").Replace(" ", "");

            return str == "";
        }

        private void mktxtDtaIniExibicao_Validated(object sender, EventArgs e)
        {
            if (ValidaDataVazia( mktxtDtaIniExibicao.Text ))
            {
                return;
            }
            if (! DateTime.TryParse(mktxtDtaIniExibicao.Text, out DateTime DtaIni)){
                MessageBox.Show("Data inicial Incorreta!", "Atenção");
                this.mktxtDtaIniExibicao.Text = "";

            }
            else if (!ValidaDataVazia(mktxtDtaFimExibicao.Text))
            {
                DateTime DtaFim = DateTime.Parse(mktxtDtaFimExibicao.Text);
                if (DtaIni > DtaFim)
                {
                    MessageBox.Show("Data Inicial não pode ser maior que a data final.", "Atenção");
                    this.mktxtDtaIniExibicao.Text = "";
                    return;
                }
            }
        }

        private void mktxtDtaFimExibicao_Validated(object sender, EventArgs e)
        {

            if (!DateTime.TryParse(mktxtDtaFimExibicao.Text, out DateTime DtaFim) && !ValidaDataVazia(mktxtDtaFimExibicao.Text))
            {
                MessageBox.Show("Data Final Incorreta!", "Atenção");
                this.mktxtDtaFimExibicao.Text = "";
                return;
            }
            if(!ValidaDataVazia(mktxtDtaFimExibicao.Text) && !ValidaDataVazia(mktxtDtaIniExibicao.Text))
            {
                DateTime DtaIni = DateTime.Parse(mktxtDtaIniExibicao.Text);
                if(DtaIni > DtaFim)
                {
                    MessageBox.Show("Data Final não pode ser menor que a Data Inicial.", "Atenção");
                    this.mktxtDtaFimExibicao.Text = "";
                    return;
                }
            }

        }
        private void LimparCampos()
        {
            mktxtSeqMensagem.Text = "";
            txtCodigoAplicacao.Text = "";
            rctxtMenssagem.Text = "";
            mktxtDtaIniExibicao.Text = "";
            mktxtDtaFimExibicao.Text = "";
            cbxStatus.SelectedIndex = -1;
            txtCodigoAplicacao.Focus();
        }
        private void LimparList()
        {
            MensagensEnc.Clear();
            IndexMsgEnc = -1;
        }
        private void HabDisaLimp()
        {
            mktxtSeqMensagem.Enabled = true;
            btnBuscar.Enabled = true;
            btnExcluir.Enabled = false;
            btnAnterior.Enabled = false;
            btnProximo.Enabled = false;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            LimparList();
            HabDisaLimp();

        }

        private void PopulaMensagem(Mensagem msg)
        {
            LimparCampos();
            mktxtSeqMensagem.Text = msg.SeqMensagem.ToString();   
            txtCodigoAplicacao.Text = msg.CodigoAplicacao;
            rctxtMenssagem.Text = msg.TextoMensagem;
            mktxtDtaIniExibicao.Text = msg.DtaInicio.ToShortDateString() == "01/01/0001" ? "" : msg.DtaInicio.ToShortDateString();
            mktxtDtaFimExibicao.Text = msg.DtaFinal.ToShortDateString() == "01/01/0001" ? "" : msg.DtaFinal.ToShortDateString();
            cbxStatus.Text = msg.Status == "I" ? "INATIVA":"ATIVA";
            mktxtSeqMensagem.Enabled = false;
            btnBuscar.Enabled = false;
            btnExcluir.Enabled = true;
            
        }
        private bool MultPopula(List<Mensagem> ListMsg)
        {
            PopulaMensagem(ListMsg.First());
            if (ListMsg.Count > 1)
            {
                IndexMsgEnc = 0;
                btnProximo.Enabled = true;
            }
            return true;
        }

        private bool BuscarMensagem()
        {
            if(mktxtSeqMensagem.Text != "")
            {
                var msg = Mensagens.FirstOrDefault(x => x.SeqMensagem == int.Parse(mktxtSeqMensagem.Text));
                if (msg != null)
                { 
                    PopulaMensagem(msg);
                    return true;
                }
                return false;
            }
            else
            {
                string CodMsg = txtCodigoAplicacao.Text;
                string TxtMsg = rctxtMenssagem.Text;
                bool dtainib = DateTime.TryParse(mktxtDtaIniExibicao.Text, out DateTime dtaini);
                bool dtafimb = DateTime.TryParse(mktxtDtaFimExibicao.Text, out DateTime dtafim);
                string Status = cbxStatus.Text == "INATIVA" ? "I" : "A";

                MensagensEnc = Mensagens.FindAll(x => (CodMsg != "" && CodMsg == x.CodigoAplicacao) ||
                                                       (TxtMsg != "" && x.TextoMensagem.Contains(TxtMsg)) ||
                                                       (dtainib &&   dtaini <= x.DtaInicio) ||
                                                       (dtafimb && dtafim >= x.DtaFinal) ||
                                                       (cbxStatus.Text != "" && Status == x.Status));
                if (MensagensEnc.Count != 0)
                {
                    return MultPopula(MensagensEnc);
                }

            }
            return false;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            if( BuscarMensagem() == false)
            {
                MessageBox.Show("Nenhum Mensagem foi econtrada. Verifique!", "Atenção");
                
            }
            
        }


        private void ExcluirMensagem(int SeqMensagem)
        {
            if( Mensagens.Remove(Mensagens.FirstOrDefault(x => x.SeqMensagem == SeqMensagem)))
            {
                MessageBox.Show("Mensagem " + SeqMensagem.ToString() + " Apagada com sucesso!");
                if (MensagensEnc.Remove(MensagensEnc.FirstOrDefault(x => x.SeqMensagem == SeqMensagem)))
                {
                    if (btnAnterior.Enabled)
                    {
                        btnAnterior.PerformClick();
                    }
                    else if (btnProximo.Enabled)
                    {
                        IndexMsgEnc -= 1;
                        btnProximo.PerformClick();
                    }
                    else
                    {
                        btnLimpar.PerformClick();
                    }
                }
                else
                {
                    btnLimpar.PerformClick();
                }




            }
            else
            {
                MessageBox.Show("Erro ao tentar apagar a mensagem:" + SeqMensagem.ToString());

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirMensagem(int.Parse(mktxtSeqMensagem.Text));

        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (MensagensEnc.Count -1 >= IndexMsgEnc)
            {
                IndexMsgEnc += 1;
                PopulaMensagem(MensagensEnc[IndexMsgEnc]);
                btnAnterior.Enabled = true;
                if (MensagensEnc.Count - 1 == IndexMsgEnc) btnProximo.Enabled = false;
                if (IndexMsgEnc == 0) btnAnterior.Enabled = false;
            }
            else
            {
                btnProximo.Enabled = false;
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (IndexMsgEnc - 1 >= 0)
            {
                IndexMsgEnc -= 1;
                PopulaMensagem(MensagensEnc[IndexMsgEnc]);
                btnProximo.Enabled = true;
                if (IndexMsgEnc == 0) btnAnterior.Enabled = false;
                if (MensagensEnc.Count - 1 == IndexMsgEnc) btnProximo.Enabled = false;
            }
        }

        private void btnTabela_Click(object sender, EventArgs e)
        {
            btnLimpar.PerformClick();
            frmPesquisaMensagem frmPesq = new frmPesquisaMensagem();
            frmPesq.Mensagens = this.Mensagens;
            frmPesq.ShowDialog();
            if (MensagensEnc.Count > 0)
            {
                MultPopula(MensagensEnc);
            }
        }
    }
}
