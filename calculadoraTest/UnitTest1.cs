using calculadora.services;

namespace calculadoraTest;

public class CalculadoraTest
{
    private Calculadora _calc;
    public CalculadoraTest()
    {
        _calc = new Calculadora();
    }

    [Theory]
    [InlineData(1, 1, 2)]
    [InlineData(2, 2, 4)]
    [InlineData(100, -1, 99)]
    [InlineData(3, 500, 503)]
    public void Somar_1Com1_Resulta2(int val1, int val2, int resultadoEsperado)
    {
        // Act
        var resultado = _calc.somar(val1, val2);

        // Assesrt
        Assert.Equal(resultado, resultadoEsperado);
    }

    [Theory]
    [InlineData(1, 1, 0)]
    [InlineData(2, 2, 0)]
    [InlineData(100, -1, 101)]
    [InlineData(3, 500, -497)]
    public void Subtrair_1Com1_Resulta0(int val1, int val2, int resultadoEsperado)
    {
        // Act
        var resultado = _calc.subtrair(val1, val2);

        // Assesrt
        Assert.Equal(resultado, resultadoEsperado);
    }

    [Theory]
    [InlineData(1, 1, 1)]
    [InlineData(2, 2, 1)]
    [InlineData(100, -1, -100)]
    [InlineData(3, 500, 0)]
    public void Dividir_1Com1_Resulta1(int val1, int val2, int resultadoEsperado)
    {
        // Act
        var resultado = _calc.dividir(val1, val2);

        // Assesrt
        Assert.Equal(resultado, resultadoEsperado);
    }

    [Fact]
    public void Dividir_byZero()
    {
        // Arrange
        var val1 = 5;
        var val2 = 0;

        // Act / Assert

        Assert.Throws<DivideByZeroException>(
            () => { _calc.dividir(val1, val2); }
        );

    }

    [Theory]
    [InlineData(1, 1, 1)]
    [InlineData(2, 2, 4)]
    [InlineData(100, -1, -100)]
    [InlineData(3, 500, 1500)]
    public void Multiplicar_1Com1_Resulta1(int val1, int val2, int resultadoEsperado)
    {
        // Act
        var resultado = _calc.multiplicar(val1, val2);

        // Assesrt
        Assert.Equal(resultado, resultadoEsperado);
    }

    [Fact]
    public void Historico_listaString()
    {
        // Act
        var resultado = _calc.Historico();
        _calc.somar(1, 1);
        _calc.dividir(1, 1);
        _calc.multiplicar(1, 1);
        _calc.somar(1, 1);
        _calc.subtrair(1, 1);

        Assert.NotEmpty(resultado);
        Assert.Equal(5, resultado.Count);
    }
}