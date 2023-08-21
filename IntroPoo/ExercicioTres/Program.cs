using System;
using System.Globalization;

namespace ExercicioTres;

class Program
{
    static void Main(string[] args)
    {
        Retangulo a = new Retangulo();

        Console.WriteLine("Digite a largura do retângulo:");
        a.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Digite a altura do retângulo:");
        a.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("");
        Console.Write("Área = " + a.Area().ToString("F2", CultureInfo.InvariantCulture));

        Console.WriteLine("");
        Console.Write("Perímetro: " + a.Perimetro().ToString("F2", CultureInfo.InvariantCulture));

        Console.WriteLine("");
        Console.Write("Diagonal: " + a.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
    }
}

