
using System;

namespace Lista_Level_4
{
	public class ex11
	{
		public static void Main()
		{
			/*11 - Escreva um programa em C# para verificar o maior número entre três
			números inteiros fornecidos.*/
			Console.WriteLine("Digite três números: ");
			int num1 = int.Parse(Console.ReadLine());
			int num2 = int.Parse(Console.ReadLine());
			int num3 = int.Parse(Console.ReadLine());
			
			Max(num1, num2,num3);
			
			Console.ReadKey();
		}
		
		public static void Max(int num1, int num2, int num3){
			if (num1 > num2 && num1 > num3) {
				Console.WriteLine("O maior número é {0}", num1);
				
			} else if (num2 > num1 && num2 > num3) {
				Console.WriteLine("O maior número é {0}", num2);
				
			} else if (num3 > num1 && num3 > num2) {
				Console.WriteLine("O maior número é {0}", num3);
			}
		}
		
	}
}