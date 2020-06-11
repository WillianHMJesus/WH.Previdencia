using System;
using System.Collections.Generic;
using WH.Previdencia.Domain.Certificados.Scopes;
using WH.Previdencia.Domain.Certificados.Validations;
using WH.Previdencia.Domain.Certificados.ValueObjects;
using WH.Previdencia.Domain.Core;

namespace WH.Previdencia.Domain.Certificados
{
    public class Certificado : Entity
    {
        public Guid CertificadoId { get; set; }
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

            Validate(this, new CertificadoValidator());
        }

        public decimal ObterSaldo()
        {
            //Adicionar Regra de Negócio
            return Saldo;
        }

        public void Aportar(decimal valor)
        {
            if (this.ValidarAporteScopeEhValido(valor))
                Saldo += valor;

            Validate(this, new CertificadoValidator());
        }

        public void Resgatar(decimal valor)
        {
            if (this.ValidarResgateScopeEhValido(valor))
                Saldo -= valor;

            Validate(this, new CertificadoValidator());
        }

        public void Desativar()
        {
            if (this.DesativarCertificadoScopeEhValido())
                Ativo = false;

            Validate(this, new CertificadoValidator());
        }
    }
}
