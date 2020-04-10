namespace WH.Previdencia.Domain.Certificados.Interfaces
{
    public interface ICertificadoService
    {
        void Aportar(string numero, decimal valor);

        void Desativar(string numero);

        Certificado ObterCertificadoPorNumero(string numero);

        void Resgatar(string numero, decimal valor);
    }
}
