using System;
class DeclaracaoVariavelDecimalFormatado
{
	static void Main(String[] args)
	{
		decimal x = 0.999m;
		decimal y = 9999999999999999999999999999m;
		Console.WriteLine("Minha quantia = {0:c}",x);
		Console.WriteLine("Sua quantia = {0:c}",y);
		}
	}