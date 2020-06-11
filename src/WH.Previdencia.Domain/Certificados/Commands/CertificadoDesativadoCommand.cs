using MediatR;

namespace WH.Previdencia.Domain.Certificados.Commands
{
    public class CertificadoDesativadoCommand : IRequest<Certificado>
    {
        public string NumeroCertificado { get; set; }
    }
}
