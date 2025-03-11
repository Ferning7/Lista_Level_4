using System;

class ex17
{
	public static void Main()
	{
		/*17 - Escreva um programa em C# para verificar um determinado array de
		inteiros de comprimento 1 ou mais, e retorne true se 10 aparecer como o
		primeiro ou o último elemento no array fornecido.*/
		
		Console.Write("Digite o comprimento do array: ");
		int tamanho = int.Parse(Console.ReadLine());

		if (tamanho < 1)
		{
			Console.WriteLine("O comprimento do array deve ser 1 ou mais.");
			return;
		}

		int[] numeros = new int[tamanho];

		Console.WriteLine("Digite os elementos do array:");

		for (int i = 0; i < tamanho; i++)
		{
			Console.Write("Elemento {0}: ", i + 1);
			numeros[i] = int.Parse(Console.ReadLine());
		}

		if (VerificarPrimeiroOUltimoElemento(numeros))
		{
			Console.WriteLine("O número 10 está no primeiro ou no último elemento do array.");
		}
		else
		{
			Console.WriteLine("O número 10 não está no primeiro nem no último elemento do array.");
		}
		
		Console.ReadKey();
	}

	public static bool VerificarPrimeiroOUltimoElemento(int[] array)
	{
		return array[0] == 10 || array[array.Length - 1] == 10;
	}
}
