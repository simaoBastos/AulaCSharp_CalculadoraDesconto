namespace CalculadoraDesconto.App;
    public class CalculadoraDesconto
    {
    public decimal Calcular(decimal preco, decimal percentual)
    {
    if (preco < 0 || percentual < 0 || percentual > 100)
    throw new ArgumentOutOfRangeException();
    return preco * (1 - percentual / 100);
    }
}