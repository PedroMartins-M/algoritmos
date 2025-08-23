using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Calendário
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o mês (1..12)");
                int mes = int.Parse (Console.ReadLine() );

            Console.WriteLine("Digite o ano: ");
            int ano = int.Parse(Console.ReadLine());

            //Descobre a quanntidade de dias em um mês
            int diasDoMes = DateTime.DaysInMonth (ano, mes);

            //Descobre o dia da semana do primeiro dia do mês
            // 0 = Domingo - 6 = Sábado
            //Gera o primeiro dia do mês e ano informado pelo usuário
            DateTime primeiroDiaDoMes = new DateTime(ano, mes, 1);
            int diaSemanaInicio = (int)primeiroDiaDoMes.DayOfWeek;

            //Matriz de 6 semanas e 7 dias
            int[,] calendario = new int [6, 7];

            int dia = 1;

            //Preenche a matriz com os dias do mês
            for (int semana = 0; semana < 6; semana++)
            {
                for (int diaSemana = 0; diaSemana < 7; diaSemana++)
                {
                    if(semana ==0 && diaSemana < diaSemanaInicio )
                    {
                        calendario[semana, diaSemana] = 0;
                    }
                    else if( dia <= diasDoMes )
                    {
                        calendario[semana, diaSemana] = dia;
                        dia++;
                    }
                }
            }
            Console.WriteLine($"\nCalendário de " +
                $"{primeiroDiaDoMes.ToString("MMMM")} de {ano}");

            Console.WriteLine("DOM\tSEG\tTER\tQUA\tQUI\tSEX\tSAB");

            for (int semana = 0; semana < 6; semana++)
            {
                for (int diaSemana = 0; diaSemana < 7; diaSemana++)
                {
                    int valor = calendario[semana, diaSemana];

                    if (valor == 0)
                        
                    {
                        Console.Write("\t"); // espaço vazio
                    }
                    else
                    {
                        Console.Write($"{valor:D2}\t");
                    }
                }

                //impressão de calendário

                //Espero o usúario teclar qualquer tecla
               Console.ReadLine();
            }
        }
    }
}
