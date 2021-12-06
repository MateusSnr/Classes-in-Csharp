using System;

namespace PrimeirsExercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoasDados Pessoa1, Pessoa2;

            Pessoa1 = new PessoasDados();
            Pessoa2 = new PessoasDados();

            Console.WriteLine("Dados da primeira pessoa:");

            Console.Write("Nome: ");
            Pessoa1.nome = Console.ReadLine();

            Console.Write("Idade: ");
            Pessoa1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");

            Console.Write("Nome: ");
            Pessoa2.nome = Console.ReadLine();

            Console.Write("Idade: ");
            Pessoa2.idade = int.Parse(Console.ReadLine());

            if (Pessoa1.idade > Pessoa2.idade)
            {
                Console.WriteLine("\nPessoa mais velha: " + Pessoa1.nome);
            }

            else if (Pessoa1.idade == Pessoa2.idade)
            {
                Console.WriteLine("\nAmbas as pessoas possuem a mesma idade! ");
            }

            else
            {
                Console.WriteLine("\nPessoa mais velha: " + Pessoa2.nome);
            }
        }
    }
}
