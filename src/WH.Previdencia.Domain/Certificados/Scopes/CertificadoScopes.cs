using FluentValidation.Results;

namespace WH.Previdencia.Domain.Certificados.Scopes
{
    public static class CertificadoScopes
    {
        public static bool ValidarAporteScopeEhValido(this Certificado certificado, decimal valor)
        {
            if (valor >= certificado.Produto.Valor) return true;
            if (certificado.ValidationResult == null) certificado.ValidationResult = new ValidationResult();
            certificado.ValidationResult.Errors.Add(new ValidationFailure(string.Empty, "O valor de aporte não pode ser menor que o valor contratado."));

            return false;
        }

        public static bool ValidarResgateScopeEhValido(this Certificado certificado, decimal valor)
        {
            if (valor <= certificado.ObterSaldo()) return true;
            if (certificado.ValidationResult == null) certificado.ValidationResult = new ValidationResult();
            certificado.ValidationResult.Errors.Add(new ValidationFailure(string.Empty, "O valor de resgate não pode ser maior que o saldo."));

            return false;
        }

        public static bool DesativarCertificadoScopeEhValido(this Certificado certificado)
        {
            if (certificado.ObterSaldo() == 0) return true;
            if (certificado.ValidationResult == null) certificado.ValidationResult = new ValidationResult();
            certificado.ValidationResult.Errors.Add(new ValidationFailure(string.Empty, "Não é possível desativar um certificado com saldo."));

            return false;
        }
    }
}
