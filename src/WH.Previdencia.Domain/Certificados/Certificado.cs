using System;
using System.Collections.Generic;
using WH.Previdencia.Domain.Certificados.ValueObjects;

namespace WH.Previdencia.Domain.Certificados
{
    public class Certificado
    {
        public Guid CertificadoId { get; private set; }
        public string Numero { get; private set; }
        private decimal Saldo { get; set; }
        public bool Ativo { get; private set; }
        public Produto Produto { get; private set; }
        public Vigencia Vigencia { get; private set; }
        public List<Transacao> Transacoes { get; private set; }

        public Certificado(string numero, bool ativo, Produto produto, Vigencia vigencia)
        {
            CertificadoId = Guid.NewGuid();
            Numero = numero;
            Ativo = ativo;
            Produto = produto;
            Vigencia = vigencia;
            Transacoes = new List<Transacao>();
        }

        public decimal ObterSaldo()
        {
            return Saldo;
        }

        public void Aportar(decimal valor)
        {
            if (valor < Produto.Valor)
                throw new Exception("O valor de aporte não pode ser menor que o valor contratado.");

            Saldo += valor;
        }

        public void Resgatar(decimal valor)
        {
            if (valor > Saldo)
                throw new Exception("O valor de resgate não pode ser maior que o saldo.");

            Saldo -= valor;
        }

        public void Desativar()
        {
            if (Saldo > 0)
                throw new Exception("Não é possível desativar um certificado com saldo.");

            Ativo = false;
        }
    }
}
