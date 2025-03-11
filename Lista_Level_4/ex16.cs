using System;

public class ex15
{
	public static void Main()
	{
		Console.Write("Digite o número de inteiros a serem verificados: ");
		int n = int.Parse(Console.ReadLine());

		if (n < 2)
		{
			Console.WriteLine("Por favor, insira pelo menos dois inteiros.");
			return;
		}

		Console.Write("Digite o 1º número não negativo: ");
		int numero1 = int.Parse(Console.ReadLine());
		if (numero1 < 0)
		{
			Console.WriteLine("Por favor, insira apenas números não negativos.");
			return;
		}

		if (VerificarUltimoDigito(numero1, n))
		{
			Console.WriteLine("Os números têm o mesmo último dígito.");
		}
		else
		{
			Console.WriteLine("Os números não têm o mesmo último dígito.");
		}
		
		Console.ReadKey();
	}

	static bool VerificarUltimoDigito(int numero1, int n)
	{
		int ultimoDigito = numero1 % 10;

		for (int i = 2; i <= n; i++)
		{
			Console.Write("Digite o {0}º número não negativo: ", i);
			int numero = int.Parse(Console.ReadLine());
			if (numero < 0)
			{
				Console.WriteLine("Por favor, insira apenas números não negativos.");
				return false;
			}

			if (numero % 10 != ultimoDigito)
			{
				return false;
			}
		}

		return true;
	}
}
