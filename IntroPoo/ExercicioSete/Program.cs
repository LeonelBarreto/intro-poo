using System;
using System.Globalization;

namespace ExercicioSete;

class Program
{
    static void Main(string[] args)
    {
        ContaBancaria conta;

        Console.Write("Entre com o número da conta: ");
        int numero = int.Parse(Console.ReadLine());

        Console.Write("Entre com o nome do titular da conta: ");
        string titular = Console.ReadLine();

        Console.Write("Haverá depósito inicial? [s/n]");
        char resposta = char.Parse(Console.ReadLine());

        if (resposta == 's' || resposta == 'S')
        {
            Console.Write("Entre com o valor do depósito inicial: R$ ");
            double depositoInicial = double.Parse(Console.ReadLine());
            conta = new ContaBancaria(numero, titular, depositoInicial);
        }
        else
        {
            conta = new ContaBancaria(numero, titular);
        }

        Console.WriteLine();
        Console.WriteLine("Dados da Conta: ");
        Console.WriteLine(conta);

        Console.WriteLine();
        Console.Write("Entre com um valor para depósito: R$ ");
        double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        conta.Deposito(quantia);
        Console.WriteLine("Dados da Conta atualizados: ");
        Console.WriteLine(conta);

        Console.WriteLine();
        Console.Write("Entre com um valor para saque: R$ ");
        quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        conta.Saque(quantia);
        Console.WriteLine("Dados da Conta atualizados: ");
        Console.WriteLine(conta);



    }
}
    
