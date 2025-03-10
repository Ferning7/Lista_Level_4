
using System;

namespace Lista_Level_4
{
	
	public class ex7
	{
		public static void Main()
		{
			/*7 - Escreva um programa em C# para verificar se um determinado número
			positivo é um múltiplo de 3 ou um múltiplo de 7.*/
			
			
			Console.WriteLine("Digite um número: ");
			int num = int.Parse(Console.ReadLine());
			
			multiplo(num);
			Console.ReadKey(true);
		}
		
		public static void multiplo(int n){
			if (n % 3 == 0 && n % 7 == 0)
			{
				Console.WriteLine("{0} é múltiplo de 3 e de 7.", n);
			}
			else if (n % 3 == 0)
			{
				Console.WriteLine("{0} é múltiplo de 3.", n);
			}
			else if (n % 7 == 0)
			{
				Console.WriteLine("{0} é múltiplo de 7.", n);
			}
			else
			{
				Console.WriteLine("{0} não é múltiplo nem de 3 nem de 7.", n);
			}
		}
	}
}
