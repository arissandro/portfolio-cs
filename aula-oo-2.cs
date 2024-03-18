using System;

public class Esfera
{
    private double volume;
    private double area;
    private int raio;
    private double pi = Math.PI; // Utilizando a constante PI da biblioteca Math

    public Esfera(int raio)
    {
        this.raio = raio;
        this.volume = CalcularVolume();
        this.area = CalcularArea();
    }

    private double CalcularVolume()
    {
        return (4.0 / 3.0) * pi * Math.Pow(raio, 3);
    }

    private double CalcularArea()
    {
        return 4 * pi * Math.Pow(raio, 2);
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
        Console.WriteLine("Digite o raio da esfera:");
        int raio = int.Parse(Console.ReadLine());

        Esfera esfera = new Esfera(raio);

        double volume = esfera.GetVolume();
        double area = esfera.GetArea();

        Console.WriteLine("O volume da esfera é: " + volume);
        Console.WriteLine("A área da esfera é: " + area);
    }
}
