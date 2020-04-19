using System;
using System.Collections.Generic;
using WH.Previdencia.Domain.Certificados;
using WH.Previdencia.Domain.Certificados.Interfaces;

namespace WH.Previdencia.Infra.Data.Repository
{
    public class CertificadoRepository : ICertificadoRepository
    {
        public Certificado ObterCertificadoPorNumero(string numero)
        {
            throw new NotImplementedException();
        }

        public List<Certificado> ObterCertificadosPorCpf(string cpf)
        {
            throw new NotImplementedException();
        }
    }
}
