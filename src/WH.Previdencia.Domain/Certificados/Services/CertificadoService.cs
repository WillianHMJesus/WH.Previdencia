using System;
using WH.Previdencia.Domain.Certificados.Interfaces;

namespace WH.Previdencia.Domain.Certificados.Services
{
    public class CertificadoService : ICertificadoService
    {
        public void Aportar(string numero, decimal valor)
        {
            throw new NotImplementedException();
        }

        public void Desativar(string numero)
        {
            throw new NotImplementedException();
        }

        public Certificado ObterCertificadoPorNumero(string numero)
        {
            throw new NotImplementedException();
        }

        public void Resgatar(string numero, decimal valor)
        {
            throw new NotImplementedException();
        }
    }
}
