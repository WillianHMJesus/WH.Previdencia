using System;
using WH.Previdencia.Domain.Certificados.Enums;
using WH.Previdencia.Domain.Core;

namespace WH.Previdencia.Domain.Certificados
{
    public class Transacao : Entity
    {
        public Guid TransacaoId { get; private set; }
        public TipoTransacao TipoTransacao { get; private set; }
        public DateTime Data { get; private set; }
        public decimal Valor { get; private set; }

        public Transacao(TipoTransacao tipoTransacao, DateTime data, decimal valor)
        {
            Id = Guid.NewGuid();
            TipoTransacao = tipoTransacao;
            Data = data;
            Valor = valor;
        }
    }
}
