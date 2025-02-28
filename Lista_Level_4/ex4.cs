
using System;

namespace Lista_Level_4
{
	
	public class ex4
	{
		/*4 - Escreva um programa em C# para calcular a soma dos dois valores
		inteiros fornecidos. Se os dois valores forem iguais, retorne o triplo de sua
		soma.*/
		public static int SomaValores(int num1, int num2)
		{
			
			
			if (num1 == num2) {
				return (num1 + num2) * 3;
			}
			return num1 + num2;
		}
		
		public static void Main(){
			
			
			Console.WriteLine("Digite dois números: ");
			int num1 = int.Parse(Console.ReadLine());
			int num2 = int.Parse(Console.ReadLine());
			

			
			if (num1 == num2) {
				Console.WriteLine("\nNúmeros iguais! Exibindo o Triplo da soma: ");
			}
			
			Console.WriteLine("\nResultado: {0} ",SomaValores(num1, num2));
			
			Console.ReadKey();
		}
	}
}
