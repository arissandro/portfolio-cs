using System;
public class Retangulo
{
    private int baseRetangulo;
    private int altura;



    public Retangulo(int baseRetangulo, int altura)
    {
        this.baseRetangulo = baseRetangulo;
        this.altura = altura;
    }

    public int GetArea()
    {
        return this.baseRetangulo * this.altura;
    }

    public static void Main(string[] args)
    {
        // Exemplo de utilização da classe Retangulo
        // Exemplo de utilização da classe Retangulo
        Console.WriteLine("Digite a base do retângulo:");
        int baseRetangulo = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a altura do retângulo:");
        int altura = int.Parse(Console.ReadLine());


        Retangulo retangulo = new Retangulo(baseRetangulo, altura);

        int area = retangulo.GetArea();
        Console.WriteLine("A área do retângulo é: " + area);
    }
}
