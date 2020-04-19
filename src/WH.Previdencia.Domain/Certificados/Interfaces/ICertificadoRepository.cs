using System.Collections.Generic;

namespace WH.Previdencia.Domain.Certificados.Interfaces
{
    public interface ICertificadoRepository
    {
        List<Certificado> ObterCertificadosPorCpf(string cpf);

        Certificado ObterCertificadoPorNumero(string numero);
    }
}
