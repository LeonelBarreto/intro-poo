namespace ExercicioUm;

class Program
{
    static void Main(string[] args)
    {
        Pessoa a, b;

        a = new Pessoa();
        b = new Pessoa();

        Console.WriteLine("Dados da primeira pessoa:");
        a.Nome = Console.ReadLine();
        a.Idade = int.Parse(Console.ReadLine());

        Console.WriteLine("Dados da primeira pessoa:");
        b.Nome = Console.ReadLine();
        b.Idade = int.Parse(Console.ReadLine());

        if (a.Idade > b.Idade)
        {
            Console.WriteLine("Pessoa mais velha: " + a.Nome);
        }
        else
        {
            Console.WriteLine("Pessoa mais velha: " + b.Nome);
        }
    }
}

