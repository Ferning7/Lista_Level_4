using System;

class ex19
{
	public static void Main()
	{
		Console.Write("Digite o número de termos da sequência de Fibonacci: ");
		int n = int.Parse(Console.ReadLine());

		if (n < 1)
		{
			Console.WriteLine("O número de termos deve ser 1 ou maior.");
		}
		else
		{
			ExibirFibonacci(n);
		}
	}

	public static void ExibirFibonacci(int n)
	{
		int a = 0, b = 1, c;

		Console.WriteLine("Sequência de Fibonacci:");

		for (int i = 1; i <= n; i++)
		{
			Console.Write(a + " ");
			c = a + b;
			a = b;
			b = c;
		}

		Console.WriteLine(); // Para pular a linha no final
	}
}
