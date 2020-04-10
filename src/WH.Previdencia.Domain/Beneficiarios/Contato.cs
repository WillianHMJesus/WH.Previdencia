using System;

namespace WH.Previdencia.Domain.Beneficiarios
{
    public class Contato
    {
        public Guid ContatoId { get; private set; }
        public string Telefone { get; private set; }
        public string Celular { get; private set; }
        public string Email { get; private set; }
    }
}
