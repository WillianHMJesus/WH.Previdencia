using Moq;
using System;
using WH.Previdencia.Domain.Certificados;
using WH.Previdencia.Domain.Certificados.Enums;
using WH.Previdencia.Domain.Certificados.ValueObjects;
using Xunit;

namespace WH.Previdencia.Testes.UnitTests.Certificados
{
    [Trait("Grupo", "Certificado")]
    public class CertificadoTests
    {
        private readonly Certificado _certificado;

        public CertificadoTests()
        {
            var mockVigencia = new Mock<Vigencia>();
            var produto = new Produto
            (
                "PREVIDÊNCIA RV 30",
                100,
                TipoPlano.PGBL,
                RegimeTributario.Progressiva,
                TipoFundo.RendaVariavel
            );
            _certificado = new Certificado
            (
                "1002030",
                true,
                produto,
                mockVigencia.Object
            );
        }

        [Fact]
        public void Certificado_ConsultarSaldo_CompararValorCorreto()
        {
            _certificado.Aportar(100);

            Assert.Equal(100, _certificado.ObterSaldo());
        }

        [Fact]
        public void Certificado_ConsultarSaldo_CompararValorDivergencia()
        {
            _certificado.Aportar(100);

            Assert.NotEqual(50, _certificado.ObterSaldo());
        }

        [Fact]
        public void Certificado_Aportar_AportarValorCorreto()
        {
            _certificado.Aportar(100);

            Assert.Equal(100, _certificado.ObterSaldo());
        }

        [Fact]
        public void Certificado_Aportar_AportarValorMenorQueValorProduto()
        {
            var exception = Assert.Throws<Exception>(() => _certificado.Aportar(50));

            Assert.Equal("O valor de aporte não pode ser menor que o valor contratado.", exception.Message);
        }

        [Fact]
        public void Certificado_Regatar_ResgatarValorCorreto()
        {
            _certificado.Aportar(100);
            _certificado.Resgatar(100);

            Assert.Equal(0, _certificado.ObterSaldo());
        }

        [Fact]
        public void Certificado_Resgatar_ResgatarValorAcimaDoSaldo()
        {
            _certificado.Aportar(100);
            var exception = Assert.Throws<Exception>(() => _certificado.Resgatar(150));

            Assert.Equal("O valor de resgate não pode ser maior que o saldo.", exception.Message);
        }

        [Fact]
        public void Certificado_Desativar_DesativarCertificadoComSucesso()
        {
            _certificado.Desativar();

            Assert.False(_certificado.Ativo);
        }

        [Fact]
        public void Certificado_Desativar_DesativarCertificadoComSaldo()
        {
            _certificado.Aportar(100);
            var exception = Assert.Throws<Exception>(() => _certificado.Desativar());

            Assert.Equal("Não é possível desativar um certificado com saldo.", exception.Message);
        }
    }
}
