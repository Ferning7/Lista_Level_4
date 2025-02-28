
using System;

namespace Lista_Level_4
{
	
	class ex3
	{
		/*3 - Escreva um programa em C# para criar uma função para a soma de
		dois números.*/
		
		public static int Somar(int num1, int num2){
			return num1 + num2;
		}
		
		public static void Main()
		{
			Console.WriteLine("Digite dois números: ");
			int numero1 = int.Parse(Console.ReadLine());
			int numero2 = int.Parse(Console.ReadLine());
			
			
			Console.WriteLine("Soma dos números: {0}", Somar(numero1, numero2));
			
			
			Console.ReadKey();
		}
	}
}
