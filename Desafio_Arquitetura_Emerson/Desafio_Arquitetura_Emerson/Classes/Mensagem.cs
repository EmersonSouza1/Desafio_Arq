using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Arquitetura_Emerson
{
    public class Mensagem
    {
        static int S_Seqmensagem;
        public int SeqMensagem { get; private set; }
        public string CodigoAplicacao { get; set; }
        public string TextoMensagem { get; set; }
        public DateTime DtaInicio { get; set; }
        public DateTime DtaFinal { get; set; }
        public string Status { get; set; }

        public DateTime DtaInclusao { get; set; }

        public Mensagem()
        {
            if (S_Seqmensagem < 0)          
            {
                S_Seqmensagem = 0;
            }
            S_Seqmensagem = S_Seqmensagem + 1;
            this.SeqMensagem = S_Seqmensagem;

        }
    }
}
