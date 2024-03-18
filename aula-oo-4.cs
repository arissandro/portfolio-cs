using System;

public class Cone
{
    private double volume;
    private double area;
    private int raio;
    private int altura;
    private double pi = Math.PI; // Utilizando a constante PI da biblioteca Math

    public Cone(int raio, int altura)
    {
        this.raio = raio;
        this.altura = altura;
        this.volume = CalcularVolume();
        this.area = CalcularArea();
    }

    private double CalcularVolume()
    {
        return (1.0 / 3.0) * pi * Math.Pow(raio, 2) * altura;
    }

    private double CalcularArea()
    {
        double lado = Math.Sqrt(Math.Pow(raio, 2) + Math.Pow(altura, 2));
        return pi * raio * (raio + lado);
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
        Console.WriteLine("Digite o raio do cone:");
        int raio = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a altura do cone:");
        int altura = int.Parse(Console.ReadLine());

        Cone cone = new Cone(raio, altura);

        double volume = cone.GetVolume();
        double area = cone.GetArea();

        Console.WriteLine("O volume do cone é: " + volume);
        Console.WriteLine("A área do cone é: " + area);
    }
}
