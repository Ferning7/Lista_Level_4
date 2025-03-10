
using System;

namespace Lista_Level_4
{
	
	using System;

	class ex12
	{
		public static int ProxDe100(int num1, int num2)
		{
			// Calcula a diferença entre cada número e 100
			int diff1 = Math.Abs(num1 - 100);
			int diff2 = Math.Abs(num2 - 100);

			// Compara as diferenças
			if (diff1 < diff2)
			{
				Console.WriteLine("{0} está mais próximo de 100.", num1);
				return num1;
			}
			else if (diff2 < diff1)
			{
				Console.WriteLine("{0} está mais próximo de 100.", num2);
				return num2;
			}
			else
			{
				Console.WriteLine("Os dois números são iguais.");
				return 0;  // Retorna 0 se os números forem iguais
			}
		}

		public static void Main()
		{
			Console.Write("Digite o primeiro número: ");
			int numero1 = int.Parse(Console.ReadLine());

			Console.Write("Digite o segundo número: ");
			int numero2 = int.Parse(Console.ReadLine());

			int resultado = ProxDe100(numero1, numero2);
			Console.WriteLine("Resultado: " + resultado);
		}
	}

}
