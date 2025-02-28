
using System;

namespace Lista_Level_4
{
	
	public class ex5
	{
		/*5 - Escreva um programa em C# para obter a diferença absoluta entre n e
		51. Se n for maior que 51, retorne o triplo da diferença absoluta.*/
		
		public static int diffAbs(int n){
			
			int diff = Math.Abs(n - 51);
			
			if (n > 51) {
				return diff * 3;
			}
			return diff;
		}
		
		public static void Main()
		{
			Console.WriteLine("Digite um número: ");
			int num = int.Parse(Console.ReadLine());
			
			Console.WriteLine("Resultado {0}", diffAbs(num));
			
			Console.ReadKey();
		}
	}
}
