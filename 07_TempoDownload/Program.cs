using System;

namespace _07_TempoDownload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tamanhoMB = 0;
            double velocidadeMbps = 0;
            bool digitacaoValida = false;

            //Loop infinito

            while (true)
            {
                //Operadores lógicos
                //&& --> AND (e lógico)
                //!! --> OR (ou lógico)
                Console.Write("Informe o tamanho do arquivo (MB): ");
                if (double.TryParse(Console.ReadLine(), out tamanhoMB) && tamanhoMB > 0)

                //sai do loop
                break;

                else
                    Console.WriteLine("Valor inválido! Digite um número maior que zero.");
            }

            while (true)
            {
                Console.Write("Informe a velocidade da internet (Mbps): ");
                if (double.TryParse(Console.ReadLine(), out velocidadeMbps) && velocidadeMbps > 0)

                break;

                else
                    Console.WriteLine("Valor inválido! Digite um número maior que zero.");
            }

            double tempoSegundos = (tamanhoMB * 8) / velocidadeMbps;
            double tempoMinutos = tempoSegundos / 60;

            //saida formada
            Console.WriteLine($"Tempo aproximado de download: {tempoMinutos:F2} minutos");

            Console.ReadKey();
        }
    }
}
    

