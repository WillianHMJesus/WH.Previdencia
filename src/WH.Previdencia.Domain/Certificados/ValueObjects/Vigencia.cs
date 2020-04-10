using System;

namespace WH.Previdencia.Domain.Certificados.ValueObjects
{
    public class Vigencia
    {
        public DateTime Inicio { get; private set; }
        public DateTime Fim { get; private set; }
    }
}
