
using System;

namespace Lista_Level_4
{
	
	public class ex8
	{
		public static void Main()
		{
			/*8 - Escreva um programa em C# para verificar se uma das temperaturas
		dadas é menor que 0 e a outra é maior que 100 se sim return true.*/
							
			Console.WriteLine("Digite duas temperaturas:");
			float temp1 = float.Parse(Console.ReadLine());
			float temp2 = float.Parse(Console.ReadLine());
			
			Console.WriteLine(temperaturas(temp1, temp2));
			Console.ReadKey(true);
		}
		
		public static bool temperaturas(float temp1, float temp2){
			if (temp1 < 0 && temp2 > 100) {
				return true;
			}
			return false;
		}
	}
}
