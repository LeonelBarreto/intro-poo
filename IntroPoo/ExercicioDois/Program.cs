using System;
using System.Globalization;

namespace ExercicioDois;

class Program
{
    static void Main(string[] args)
    {
        Funcionario a, b;
        a = new Funcionario();
        b = new Funcionario();

        Console.WriteLine("Dados do primeiro funcionário:");
        a.Nome = Console.ReadLine();
        a.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Dados do segundo funcionário:");
        b.Nome = Console.ReadLine();
        b.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double mediaSalarial = (a.Salario + b.Salario) / 2.0;
        Console.Write("Média salarial: " + mediaSalarial.ToString("F2", CultureInfo.InvariantCulture));
    }
}

