
using System;

namespace Lista_Level_4
{
	
	public class ex13
	{
		public static void Main()
		{
			/*13 - Escreva um programa em C# para verificar se dois inteiros fornecidos
			estão no intervalo entre 40 e 50 inclusive, ou ambos estando no intervalo
			entre 50 e 60 inclusive.*/
			
			Console.WriteLine("Digite dois números: ");
			int num1 = int.Parse(Console.ReadLine());
			int num2 = int.Parse(Console.ReadLine());
			
			intervalo(num1, num2);
			
			Console.ReadKey();
		}
		
		public static void intervalo(int num1, int num2){
			if ((num1 >= 40 && num1 <= 50 && num2 >= 40 && num2 <= 50)
			    || (num1 >= 50 && num1 <= 60 && num2 >= 50 && num2 <= 60))
			{
				Console.WriteLine("Os números estão dentro do intervalo");
				
			}
			else
			{
				Console.WriteLine("Os números não estão dentro do intervalo");
				
			}
		}
	}
}
