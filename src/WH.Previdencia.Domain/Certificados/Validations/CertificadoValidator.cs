using FluentValidation;

namespace WH.Previdencia.Domain.Certificados.Validations
{
    public class CertificadoValidator : AbstractValidator<Certificado>
    {
        public CertificadoValidator()
        {
            RuleFor(x => x.Numero).NotEmpty().MaximumLength(8).MinimumLength(8).WithMessage("O número do certificado está inválido");
            RuleFor(x => x.ObterSaldo()).NotEmpty().Must(CustomValidator.ValorMaiorQueZero).WithMessage("O saldo do certificado está inválido");
            RuleFor(x => x.Ativo).NotEmpty().WithMessage("O certificado está inativo");
            RuleFor(x => x.Vigencia.Inicio).NotEmpty().Must(CustomValidator.DataMenorIgualQueADataDeHoje).WithMessage("O inicio da vigência está inválido");
            RuleFor(x => x.Vigencia.Fim).NotEmpty().Must(CustomValidator.DataMaiorIgualQueADataDeHoje).WithMessage("O fim da vigência está inválido");
            RuleFor(x => x.Produto).NotNull().WithMessage("O produto está inválido");
        }
    }
}
