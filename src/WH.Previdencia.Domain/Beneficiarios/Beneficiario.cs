using System;
using WH.Previdencia.Domain.Beneficiarios.Enums;

namespace WH.Previdencia.Domain.Beneficiarios
{
    public class Beneficiario
    {
        public Guid BeneficiarioId { get; private set; }
        public string Nome { get; private set; }
        public DateTime DataNacimento { get; private set; }
        public string CPF { get; private set; }
        public Sexo Sexo { get; private set; }
        public Contato Contato { get; private set; }
        public Conta Conta { get; set; }
    }
}
