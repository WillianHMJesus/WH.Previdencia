using System.Collections.Generic;

namespace WH.Previdencia.Domain.Certificados.Interfaces
{
    public interface ICertificadoRepository
    {
        Transacao AdicionarTransacao(Transacao transacao);
        Certificado Atualizar(Certificado certificado);
        List<Certificado> ObterCertificadosPorCpf(string cpf);
        Certificado ObterCertificadoPorNumero(string numero);
    }
}
