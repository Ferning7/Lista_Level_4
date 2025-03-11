
using System;

namespace Lista_Level_4
{
	
	public class ex14
	{
		public static void Main()
		{
			/*14 - Escreva um programa em C# para verificar se a soma de dois inteiros
			é igual ao terceiro inteiro fornecido pelo usuário se sim return true.*/
			Console.WriteLine("Digite 3 números: ");
			int num1 = int.Parse(Console.ReadLine());
			int num2 = int.Parse(Console.ReadLine());
			int num3 = int.Parse(Console.ReadLine());
			
			Console.WriteLine(igualTerceiro(num1, num2, num3));
			
			Console.ReadKey();
		}
		
		public static bool igualTerceiro(int n1, int n2, int n3){
			if ((n1 + n2) == n3) {
				return true;
			}
			return false;
		}
	}
}
