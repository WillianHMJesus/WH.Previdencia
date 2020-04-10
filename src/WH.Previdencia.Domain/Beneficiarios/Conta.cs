using System;
using WH.Previdencia.Domain.Beneficiarios.ValueObjects;

namespace WH.Previdencia.Domain.Beneficiarios
{
    public class Conta
    {
        public Guid ContaId { get; private set; }
        public Agencia Agencia { get; private set; }
        public int Numero { get; private set; }
        public char Digito { get; set; }
    }
}
