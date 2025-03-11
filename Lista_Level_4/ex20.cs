using System;

class Program
{
	public static void Main()
	{
		Console.Write("Digite o comprimento do array (mínimo 2): ");
		int tamanho = int.Parse(Console.ReadLine());

		if (tamanho < 2)
		{
			Console.WriteLine("O comprimento do array deve ser pelo menos 2.");
			return;
		}

		int[] numeros = new int[tamanho];

		Console.WriteLine("Digite os elementos do array:");

		for (int i = 0; i < tamanho; i++)
		{
			Console.Write($"Elemento {i + 1}: ");
			numeros[i] = int.Parse(Console.ReadLine());
		}

		int maiorValorMedio = MaiorValorMedio(numeros);
		Console.WriteLine("O maior valor médio entre a primeira e a segunda metade do array é: " + maiorValorMedio);
	}

	public static int MaiorValorMedio(int[] array)
	{
		int meio = array.Length / 2;


		int somaPrimeiraMetade = 0;
		for (int i = 0; i < meio; i++)
		{
			somaPrimeiraMetade += array[i];
		}
		int mediaPrimeiraMetade = somaPrimeiraMetade / meio;


		int somaSegundaMetade = 0;
		for (int i = meio; i < array.Length; i++)
		{
			somaSegundaMetade += array[i];
		}
		int mediaSegundaMetade = somaSegundaMetade / (array.Length - meio);

		
		return Math.Max(mediaPrimeiraMetade, mediaSegundaMetade);
	}
}
