
using System;

namespace Lista_Level_4
{
	
	class ex2
	{
		/*2 - Escreva um programa em C# para criar uma função definida pelo
		usuário com parâmetros para escrever um nome qualquer.*/
		
		public static void Nome(string nome)
		{
			Console.WriteLine("Nome digitado: {0}", nome);
			
		}
		
		public static void Main()
		{
			
			Console.Write("Digite seu nome: ");
			string nomeInserido = Console.ReadLine();
			
			Nome(nomeInserido);
			
			Console.ReadKey();
		}
		
		
	}
}
