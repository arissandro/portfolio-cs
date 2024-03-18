using System;

public class Cilindro
{
    private double volume;
    private double area;
    private int raio;
    private int altura;
    private double pi = Math.PI; // Utilizando a constante PI da biblioteca Math

    public Cilindro(int raio, int altura)
    {
        this.raio = raio;
        this.altura = altura;
        this.volume = CalcularVolume();
        this.area = CalcularArea();
    }

    private double CalcularVolume()
    {
        return pi * raio * raio * altura;
    }

    private double CalcularArea()
    {
        return 2 * pi * raio * (raio + altura);
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
        Console.WriteLine("Digite o raio do cilindro:");
        int raio = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a altura do cilindro:");
        int altura = int.Parse(Console.ReadLine());

        Cilindro cilindro = new Cilindro(raio, altura);

        double volume = cilindro.GetVolume();
        double area = cilindro.GetArea();

        Console.WriteLine("O volume do cilindro é: " + volume);
        Console.WriteLine("A área do cilindro é: " + area);
    }
}
