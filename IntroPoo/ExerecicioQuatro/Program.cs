﻿using System;
using System.Globalization;

namespace ExerecicioQuatro;

class Program
{
    static void Main(string[] args)
    {
        Funcionario f = new Funcionario();

        Console.Write("Nome: ");
        f.Nome = Console.ReadLine();
        Console.WriteLine();

        Console.Write("Salário Bruto: ");
        f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine();

        Console.Write("Imposto: ");
        f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine();

        Console.WriteLine("Funcionário: " + f);
        Console.WriteLine();

        Console.Write("Digite a porcentagem p/ aumentar o salário: ");
        double porcentagem = double.Parse(Console.ReadLine());
        f.AumentarSalario(porcentagem);

        Console.WriteLine("Dados Atualizados: " + f);
    }
}

