using FluentValidation;

namespace WH.Previdencia.Domain.Certificados.Validations
{
    public class TransacaoValidator : AbstractValidator<Transacao>
    {
        public TransacaoValidator()
        {
            RuleFor(x => x.TipoTransacao).NotNull().WithMessage("O tipo de transação está inválido");
            RuleFor(x => x.Data).NotEmpty().Must(CustomValidator.DataIgualADataDeHoje).WithMessage("A data da transação está inválida");
            RuleFor(x => x.Valor).Must(CustomValidator.ValorMaiorQueZero).WithMessage("O valor da transação está inválido");
        }

        
    }
}
