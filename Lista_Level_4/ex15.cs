
using System;

namespace Lista_Level_4
{
	
	public class ex15
	{
		public static void Main()
		{
			/*15 - Escreva um programa em C# para verificar se três números
			fornecidos estão em ordem crescente, como 4, 7, 15, ou 45, 56, 67, mas
			não 4 ,8, 8 ou 6, 6, 8. No entanto, se um quarto parâmetro for true, a
			igualdade é permitida, como 6, 6, 8 ou 7, 7, 7.*/
			Console.WriteLine("Digite três números:");
			int num1 = int.Parse(Console.ReadLine());
			int num2 = int.Parse(Console.ReadLine());
			int num3 = int.Parse(Console.ReadLine());
			
			crescente(num1, num2, num3);
			
			Console.ReadKey();
		}
		
		public static bool crescente(int num1, int num2, int num3) {
			if (num1 <= num2 && num2 <= num3) {
				Console.WriteLine("Os números estão em ordem crescente");
			} else {
				Console.WriteLine("Os número não estão em ordem crescente");
			}
		}
	}
}
