using System;
using System.Collections.Generic;
using System.Text;

namespace WH.Previdencia.Domain.Beneficiarios.ValueObjects
{
    public class Agencia
    {
        public int Numero { get; private set; }
        public char Digito { get; private set; }
    }
}
