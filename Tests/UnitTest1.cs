
using projeto;

namespace Tests;

public class UnitTest1
{
   
    Calculadora calc = new Calculadora();


    [Theory]
    [InlineData (1, 2, 3)]
    [InlineData (4, 5, 9)]
    public void SomarTest(int num1, int num2, int resultado)
    {
        // Arrange

        // Act
        int resultadocalc = calc.somar(num1, num2);

        // Assert
        Assert.Equal(resultado, resultadocalc);
         
    }
    [Theory]
    [InlineData (4, 1, 3)]
    [InlineData (9, 5, 4)]
    public void SubtrairTest(int num1, int num2, int resultado)
    {
        // Arrange

        // Act
        int resultadocalc = calc.subtrair(num1, num2);

        // Assert
        Assert.Equal(resultado, resultadocalc);
         
    }
    [Theory]
    [InlineData (3, 2, 6)]
    [InlineData (4, 5, 20)]
    public void MultiplicarTest(int num1, int num2, int resultado)
    {
        // Arrange

        // Act
        int resultadocalc = calc.multiplicar(num1, num2);

        // Assert
        Assert.Equal(resultado, resultadocalc);
         
    }
    [Theory]
    [InlineData (6, 2, 3)]
    [InlineData (45, 5, 9)]
    public void DividirTest(int num1, int num2, int resultado)
    {
        // Arrange

        // Act
        int resultadocalc = calc.dividir(num1, num2);

        // Assert
        Assert.Equal(resultado, resultadocalc);
         
    }

    [Fact]
    public void DividirPor0Test()
    {
        Assert.Throws<DivideByZeroException>(() => calc.dividir(3,0)); 
    }

    [Fact]
    public void ListaTest()
    {
        calc.somar(1, 2);
        calc.somar(1, 3);
        calc.somar(4, 2);
        calc.somar(5, 4);

        var lista = calc.historico();

        Assert.NotEmpty(calc.historico());
        Assert.Equal(3, lista.Count);
    }
    

    
}