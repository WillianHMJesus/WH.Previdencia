namespace WH.Previdencia.Domain.Certificados.Interfaces
{
    public interface ICertificadoService
    {
        Certificado Aportar(Certificado certificado, decimal valor);
        Certificado Desativar(Certificado certificado);
        Certificado Resgatar(Certificado certificado, decimal valor);
    }
}
