using System;
using WH.Previdencia.Domain.Certificados.Enums;

namespace WH.Previdencia.Domain.Certificados
{
    public class Transacao
    {
        public Guid TransacaoId { get; private set; }
        public TipoTransacao TipoTransacao { get; private set; }
        public DateTime Data { get; private set; }
        public decimal Valor { get; private set; }

        public Transacao(TipoTransacao tipoTransacao, DateTime data, decimal valor)
        {
            TransacaoId = Guid.NewGuid();
            TipoTransacao = tipoTransacao;
            Data = data;
            Valor = valor;
        }
    }
}
