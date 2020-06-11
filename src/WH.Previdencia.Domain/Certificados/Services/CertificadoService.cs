using System;
using WH.Previdencia.Domain.Certificados.Enums;
using WH.Previdencia.Domain.Certificados.Interfaces;
using WH.Previdencia.Domain.Core.Notifications;

namespace WH.Previdencia.Domain.Certificados.Services
{
    public class CertificadoService : ICertificadoService
    {
        private readonly IDomainNotificationHandle _notifications;
        private readonly ICertificadoRepository _certificadoRepository;

        public CertificadoService(
            IDomainNotificationHandle notifications,
            ICertificadoRepository certificadoRepository)
        {
            _notifications = notifications;
            _certificadoRepository = certificadoRepository;
        }

        public Certificado Aportar(Certificado certificado, decimal valor)
        {
            certificado.Aportar(valor);
            if(_notifications.HasNotification())
            {
                var transacao = new Transacao(TipoTransacao.Aporte, DateTime.Now, valor);
                _certificadoRepository.Atualizar(certificado);
                _certificadoRepository.AdicionarTransacao(transacao);

                return certificado;
            }

            return null;
        }

        public Certificado Desativar(Certificado certificado)
        {
            certificado.Desativar();
            if(_notifications.HasNotification())
            {
                _certificadoRepository.Atualizar(certificado);
                return certificado;
            }

            return null;
        }

        public Certificado Resgatar(Certificado certificado, decimal valor)
        {
            certificado.Resgatar(valor);
            if (_notifications.HasNotification())
            {
                var transacao = new Transacao(TipoTransacao.Resgate, DateTime.Now, valor);
                _certificadoRepository.Atualizar(certificado);
                _certificadoRepository.AdicionarTransacao(transacao);

                return certificado;
            }

            return null;
        }
    }
}
