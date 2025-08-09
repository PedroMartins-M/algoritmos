using System;

namespace _06_Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número para ver a tabuada: ");

            // Lê o número digitado e converte para inteiro
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                Console.WriteLine($"\nTabuada do {numero}:\n");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{numero} x {i} = {numero * i}");
                }
            }
        }
    }
}
