using Xunit;
using CalculadoraDesconto.App;
namespace CalculadoraDesconto.Tests;
public class CalculadoraDescontoTests
{
    [Theory]
    [InlineData(100, 10, 90)]
    [InlineData(200, 0, 200)]
    [InlineData(80, 100, 0)]
    public void Desconto_ValoresValidos(int preco, int percentual, int esperado)
    {
        var servico = new CalculadoraDesconto.App.CalculadoraDesconto();
        Assert.Equal(esperado, servico.Calcular(preco, percentual));
        }
        [Theory]
        [InlineData(-1, 10)]
        [InlineData(100, -5)]
        [InlineData(100, 110)]
        public void Desconto_ValoresInvalidos(int preco, int percentual)
        {
        var servico = new CalculadoraDesconto.App.CalculadoraDesconto();
        Assert.Throws<ArgumentOutOfRangeException>(() => servico.Calcular(preco, percentual));
    }
}