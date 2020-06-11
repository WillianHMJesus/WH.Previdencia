namespace WH.Previdencia.Domain.Certificados.Interfaces
{
    public interface ICertificadoService
    {
        Certificado Aportar(Certificado certificado);
        Certificado Resgatar(Certificado certificado);
        Certificado Desativar(Certificado certificado);
    }
}
