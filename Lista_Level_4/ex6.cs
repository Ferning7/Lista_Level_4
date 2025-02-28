
using System;

namespace Lista_Level_4
{
	
	public class ex6
	{
		/*6 - Escreva um programa em C# para verificar dois números inteiros
		fornecidos e retorne true se um deles for 30 ou se sua soma for 30.*/
		
		public static bool verifyBool(int num1, int num2){
			
			int soma = num1 + num2;
			
			if (num1 == 30 || num2 == 30 || soma == 30) {
				return true;
			} 
			return false;
		}
		
		public static void Main()
		{
			Console.WriteLine("Digite dois números");
			int num1 = int.Parse(Console.ReadLine());
			int num2 = int.Parse(Console.ReadLine());
			
			Console.WriteLine(verifyBool(num1, num2));
			
			Console.ReadKey();
		}
	}
}
