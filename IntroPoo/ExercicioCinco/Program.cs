using System;
using System.Globalization;

namespace ExercicioCinco;

class Program
{
    static void Main(string[] args)
    {

        Aluno a = new Aluno();

        Console.Write("Nome do Aluno: ");
        a.Nome = Console.ReadLine();

        Console.WriteLine("Digite as três notas do aluno:");
        Console.WriteLine();

        Console.Write("Nota 1: ");
        a.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine();
        Console.Write("Nota 2: ");
        a.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine();
        Console.Write("Nota 3: ");
        a.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


        Console.WriteLine();
        Console.WriteLine("Nota Final: " + a.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

        if (a.Aprovado())
        {
            Console.WriteLine("APROVADO!");
        }
        else
        {
            Console.WriteLine("REPROVADO!");
            Console.WriteLine("FALTARAM " + a.NotaRestante().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

