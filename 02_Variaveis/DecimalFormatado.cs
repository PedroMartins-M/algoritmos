using System;
class DeclaracaoVariavelDecimalFormatado
{
	static void Main(String[] args)
	{
		decimal x = 0.999m;
		decimal y = 9999999999999999999999999999m;
		/*
		Utilizando Placeholder para demonstrar o conteúdo
		{0;C}
		0 = Posiçao de Marcação
		C = Formação de Moeda (Currency)
		*/
		
		Console.WriteLine("Minha quantia = {0:c}",x);
		Console.WriteLine("Sua quantia = {0:c}",y);
		Console.WriteLine("Valor de x = {0: F3} e Valor de y = (1:c)",x,y);
		
		/*
		Interpolação de String, só funciona no .Net versão 6.0 acima
		*/
		
		/*
		Console.WriteLine($"Minha quantia = {0:c}",x);
		Console.WriteLine($"Sua quantia = {0:c}",y);
		Console.WriteLine($"Valor de x = {0: F3} e Valor de y = (1:c)",x,y);
		*/
		}
	}