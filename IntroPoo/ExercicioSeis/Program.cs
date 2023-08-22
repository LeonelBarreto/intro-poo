using System.Globalization;

namespace ExercicioSeis;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Qual é a cotação do dólar: ");
        double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine();

        Console.Write("Quantos dólares você vai comprar: ");
        double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine();

        double conversaoTotal = ConversorDeMoeda.DolarParaReal(cotacao, quantia);

        Console.WriteLine("Valor a pagar em reais: R$ " + conversaoTotal.ToString("F2", CultureInfo.InvariantCulture));
    }
}

