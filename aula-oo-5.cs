using System;

public class Piramide
{
    private double volume;
    private double area;
    private double baseArea;
    private int altura;
    private double ladoBase;
    private double alturaTriangulo;

    public Piramide(double ladoBase, int altura)
    {
        this.ladoBase = ladoBase;
        this.altura = altura;
        this.baseArea = CalcularBaseArea();
        this.volume = CalcularVolume();
        this.area = CalcularArea();
    }

    private double CalcularBaseArea()
    {
        return Math.Pow(ladoBase, 2);
    }

    private double CalcularVolume()
    {
        return (1.0 / 3.0) * baseArea * altura;
    }

    private double CalcularArea()
    {
        alturaTriangulo = Math.Sqrt(Math.Pow(altura, 2) + Math.Pow(ladoBase / 2, 2));
        double areaTriangulo = ladoBase * alturaTriangulo / 2;
        double areaBase = baseArea;

        return areaBase + 4 * areaTriangulo;
    }

    public double GetVolume()
    {
        return volume;
    }

    public double GetArea()
    {
        return area;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Digite o comprimento do lado da base da pirâmide:");
        double ladoBase = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a altura da pirâmide:");
        int altura = int.Parse(Console.ReadLine());

        Piramide piramide = new Piramide(ladoBase, altura);

        double volume = piramide.GetVolume();
        double area = piramide.GetArea();

        Console.WriteLine("O volume da pirâmide é: " + volume);
        Console.WriteLine("A área da pirâmide é: " + area);
    }
}
