
using System;

namespace Lista_Level_4
{
	
	public class ex9
	{
		public static void Main()
		{
			/*9 - Escreva um programa em C# para verificar dois inteiros dados, se
			algum deles está no intervalo entre 100 e 200 inclusive.*/
			
		}
		
		public static bool intervalo(int num1, int num2){
			if (num1 >= 100 && num1 <= 200 && num2 >= 100 && num2 <= 200) {
				Console.WriteLine("Estão no intervalo de 100 e 200");
			}
			return false;
		}
	}
}
