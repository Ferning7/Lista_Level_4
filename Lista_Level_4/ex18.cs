using System;

class ex18
{
	public static void Main()
	{
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

		if (VerificarPrimeiroEUltimoElementoIguais(numeros))
		{
			Console.WriteLine("O primeiro e o último elemento são iguais.");
		}
		else
		{
			Console.WriteLine("O primeiro e o último elemento não são iguais.");
		}
	}

	public static bool VerificarPrimeiroEUltimoElementoIguais(int[] array)
	{
		return array[0] == array[array.Length - 1];
	}
}

}
