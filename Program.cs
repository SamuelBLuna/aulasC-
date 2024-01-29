using System;

namespace ExercicioQuartos // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudantes[] totalQuartos = new Estudantes[10];

            Console.Write("Quantos quartos serão alugados? ");
            int quartos = int.Parse(Console.ReadLine());

            for (int i = 0; i < quartos; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i + 1}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                totalQuartos[quarto] = new Estudantes(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");

           for (int i = 0;i < totalQuartos.Length;i++)
            {
                if (totalQuartos[i] != null)
                {
                    Console.WriteLine($"{i} {totalQuartos[i]}");
                }
            }


        }
    }
}