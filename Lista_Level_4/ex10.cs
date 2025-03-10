
using System;

namespace Lista_Level_4
{
	
	public class ex10
	{
		public static void Main()
		{
			/*10 - Escreva um programa em C# para verificar se três valores inteiros
			fornecidos estão no intervalo entre 20 e 50 inclusive. Retorna true se 1 ou
			mais deles estiverem no intervalo mencionado, caso contrário, false.*/
			
			Console.WriteLine("Digite três números: ");
			int num1 = int.Parse(Console.ReadLine());
			int num2 = int.Parse(Console.ReadLine());
			int num3 = int.Parse(Console.ReadLine());
			
			intervalos(num1, num2, num3);
			
			Console.ReadKey();
		}
		
		public static bool intervalos(int num1, int num2, int num3){
			if ((num1 >= 20 && num1 <= 50) || (num2 >= 20 && num2 <= 50) || (num3 >= 20 && num3 <= 50))
			{
				Console.WriteLine("Pelo menos um número está no intervalo de 20 a 50.");
				return true;
			}
			else
			{
				Console.WriteLine("Nenhum número está no intervalo de 20 a 50.");
				return false;
			}
			
			
		}
	}
}
