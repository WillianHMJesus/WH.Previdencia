using System;
using WH.Previdencia.Domain.Certificados.Enums;

namespace WH.Previdencia.Domain.Certificados.ValueObjects
{
    public class Produto
    {
        public Guid ProdutoId { get; private set; }
        public string Nome { get; private set; }
        public decimal Valor { get; private set; }
        public TipoPlano TipoPlano { get; private set; }
        public RegimeTributario RegimeTributario { get; private set; }
        public TipoFundo TipoFundo { get; private set; }

        public Produto(string nome, decimal valor, TipoPlano tipoPlano, RegimeTributario regimeTributario, TipoFundo tipoFundo)
        {
            ProdutoId = Guid.NewGuid();
            Nome = nome;
            Valor = valor;
            TipoPlano = tipoPlano;
            RegimeTributario = regimeTributario;
            TipoFundo = tipoFundo;
        }
    }
}
