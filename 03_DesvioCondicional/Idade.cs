//classificacao_idade

using System;
 
class classificacaoidade

{

    static void Main()

    {

        int idade;

        Console.Write("Digite sua idade: ");

        idade = Convert.ToInt32(Console.ReadLine());
 
        if (idade <= 12)

        {

            Console.WriteLine("Você é criança");

        }

        else if (idade <= 17)

        {

            Console.WriteLine("Você é adolescente");

        }

        else if (idade <= 59)

        {

            Console.WriteLine("Você é adulto");

        }
		
		else
			
		{
			Console.WriteLine("Você é idoso");
		}
 
        Console.WriteLine("Pressione qualquer tecla para sair...");

        Console.ReadKey();

    }

}

 