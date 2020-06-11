using MediatR;
using System.Threading;
using System.Threading.Tasks;
using WH.Previdencia.Domain.Certificados.Commands;
using WH.Previdencia.Domain.Certificados.Interfaces;
using WH.Previdencia.Domain.Core.Notifications;

namespace WH.Previdencia.Domain.Certificados.Handles
{
    public class CertificadoHandle :
        IRequestHandler<CertificadoAporteCommand, Certificado>,
        IRequestHandler<CertificadoResgateCommand, Certificado>,
        IRequestHandler<CertificadoDesativadoCommand, Certificado>
    {
        private readonly IDomainNotificationHandle _notifications;
        private readonly ICertificadoRepository _certificadoRepository;
        private readonly ICertificadoService _certificadoService;

        public CertificadoHandle(
            IDomainNotificationHandle notifications,
            ICertificadoRepository certificadoRepository,
            ICertificadoService certificadoService)
        {
            _notifications = notifications;
            _certificadoRepository = certificadoRepository;
            _certificadoService = certificadoService;
        }

        public async Task<Certificado> Handle(CertificadoAporteCommand request, CancellationToken cancellationToken)
        {
            var certificado = _certificadoRepository.ObterCertificadoPorNumero(request.NumeroCertificado);
            if(_notifications.HasNotification())
            {
                return await Task.FromResult(_certificadoService.Aportar(certificado));
            }

            return null;
        }

        public async Task<Certificado> Handle(CertificadoResgateCommand request, CancellationToken cancellationToken)
        {
            var certificado = _certificadoRepository.ObterCertificadoPorNumero(request.NumeroCertificado);
            if (_notifications.HasNotification())
            {
                return await Task.FromResult(_certificadoService.Resgatar(certificado));
            }

            return null;
        }

        public async Task<Certificado> Handle(CertificadoDesativadoCommand request, CancellationToken cancellationToken)
        {
            var certificado = _certificadoRepository.ObterCertificadoPorNumero(request.NumeroCertificado);
            if (_notifications.HasNotification())
            {
                return await Task.FromResult(_certificadoService.Desativar(certificado));
            }

            return null;
        }
    }
}
